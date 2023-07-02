using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using FastColoredTextBoxNS;

namespace Regex_Prime_Numbers
{
    public partial class RPN : Form
    {
        public RPN()
        {
            InitializeComponent();
            tmrNumberUpdateTimer.Tick += async (sender, e) => await UpdateNumbersAsync(sender, e);

            // Subscribe to Enter events
            fctbNumbers.Enter += FastColoredTextBox_Enter;
            fctbOnes.Enter += FastColoredTextBox_Enter;
            fctbPrimes.Enter += FastColoredTextBox_Enter;
        }

        private void FastColoredTextBox_Enter(object sender, EventArgs e)
        {
            lastFocusedTextBox = (FastColoredTextBox)sender;
        }

        private CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

        private async Task UpdateNumbersAsync(object sender, EventArgs e)
        {
            tmrNumberUpdateTimer.Stop();
            cancelTokenSource.Cancel();
            cancelTokenSource = new CancellationTokenSource();
            await Task.Run(() => CreateNumberRange(cancelTokenSource.Token), cancelTokenSource.Token);
        }

        private void nudStart_ValueChanged(object sender, EventArgs e)
        {
            tmrNumberUpdateTimer.Stop();
            tmrNumberUpdateTimer.Start();
        }

        private void nudEnd_ValueChanged(object sender, EventArgs e)
        {
            tmrNumberUpdateTimer.Stop();
            tmrNumberUpdateTimer.Start();
        }

        private void CreateNumberRange(CancellationToken ct)
        {
            int start = (int)nudStart.Value;
            int end = (int)nudEnd.Value;

            if (start > end)
            {
                MessageBox.Show("Start value should be less than or equal to end value!");
                return;
            }

            var sbNumbers = new StringBuilder();
            var sbOnes = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                if (ct.IsCancellationRequested)
                {
                    // Operation was cancelled, do not continue further.
                    return;
                }

                sbNumbers.AppendLine(i.ToString());
                sbOnes.AppendLine(new string('1', i));
            }

            // Since we need to update UI, ensure this is done on the UI thread
            this.Invoke((Action)(() =>
            {
                fctbNumbers.Text = sbNumbers.ToString();
                fctbOnes.Text = sbOnes.ToString();
            }));

            // Kick off the prime calculation - this is now outside the Invoke call and won't block the UI responsiveness
            CalculatePrimesAsync(ct);
        }

        private void RPN_Load(object sender, EventArgs e)
        {
        }


        FastColoredTextBox lastFocusedTextBox;




        private void tsbStart_Click(object sender, EventArgs e)
        {
            tmrNumberUpdateTimer.Stop();
            tmrNumberUpdateTimer.Start();
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel(); // Cancel any running task
        }


        private async Task CalculatePrimesAsync(CancellationToken ct)
        {
            // Grab the number lines and corresponding ones lines
            string[] numberLines = fctbNumbers.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] onesLines = fctbOnes.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            if (numberLines.Length != onesLines.Length)
            {
                MessageBox.Show("Numbers and ones do not match!");
                return;
            }

            var sbPrimes = new StringBuilder();

            // Regex pattern for prime checking
            var regex = new Regex(@"^1?$|^(11+?)\1+$");

            for (int i = 0; i < numberLines.Length; i++)
            {
                if (ct.IsCancellationRequested)
                {
                    // Operation was cancelled, do not continue further.
                    return;
                }

                // Check if the ones representation is a prime number
                if (!regex.IsMatch(onesLines[i]))
                {
                    // The number is prime, so add it to the list
                    sbPrimes.AppendLine(numberLines[i]);
                }
            }

            // Since we need to update UI, ensure this is done on the UI thread
            this.Invoke((Action)(() =>
            {
                fctbPrimes.Text = sbPrimes.ToString();
            }));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.youtube.com/watch?v=B9H0TyApBtU");
        }

        private void OpenUrl(string url)
        {
            try
            {
                using (var process = new System.Diagnostics.Process())
                {
                    process.StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true, // Use the operating system shell to start the process
                    };

                    process.Start();
                }
            }
            catch (Exception ex)
            {
                // An error occurred, possibly due to no default browser being set
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void miArticle_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.noulakaz.net/2007/03/18/a-regular-expression-to-check-for-prime-numbers/");
        }

        private void miVideo_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.youtube.com/watch?v=B9H0TyApBtU");
        }


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ResetUI();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetUI();
        }

        private void ResetUI()
        {
            // Cancel any ongoing calculations
            cancelTokenSource.Cancel();

            // Unsubscribe from ValueChanged events
            nudStart.ValueChanged -= nudStart_ValueChanged;
            nudEnd.ValueChanged -= nudEnd_ValueChanged;

            // Reset the UI
            fctbNumbers.Text = string.Empty;
            fctbOnes.Text = string.Empty;
            fctbPrimes.Text = string.Empty;
            nudStart.Value = 1;
            nudEnd.Value = 100;

            // Resubscribe to ValueChanged events
            nudStart.ValueChanged += nudStart_ValueChanged;
            nudEnd.ValueChanged += nudEnd_ValueChanged;
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if (lastFocusedTextBox != null)
            {
                // Remember the original selection
                var originalStart = lastFocusedTextBox.SelectionStart;
                var originalLength = lastFocusedTextBox.SelectionLength;

                // Select all and copy
                lastFocusedTextBox.SelectAll();
                lastFocusedTextBox.Copy();

                // Restore the original selection
                lastFocusedTextBox.SelectionStart = originalStart;
                lastFocusedTextBox.SelectionLength = originalLength;

                // Temporarily shift focus to another control and shift it back
                msMenu.Focus();
                lastFocusedTextBox.Focus();
            }
        }

        private void SavePrimesToFile()
        {
            // Specify the filename
            var timestamp = DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss");
            var filename = $"Primes-{timestamp}.txt";

            // Get the full path to the application folder
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

            // Write all text to the file
            File.WriteAllText(path, fctbPrimes.Text);

            // Open the folder and select the file
            string argument = "/select, \"" + path + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SavePrimesToFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePrimesToFile();
        }


    }
}