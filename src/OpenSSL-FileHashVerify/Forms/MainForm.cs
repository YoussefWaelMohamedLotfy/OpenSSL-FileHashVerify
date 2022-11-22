using CliWrap;
using CliWrap.Buffered;
using OpenSSL_FileHashVerify.Forms;
using System.Text;

namespace OpenSSL_FileHashVerify;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        => Application.Exit();

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using OpenFileDialog ofd = new();

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            txtFilePath.Clear();
            txtFilePath.Text = ofd.FileName;
        }
    }

    private async void btnCalculateHashes_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtFilePath.Text))
        {
            MessageBox.Show("Select a file first.", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        StringBuilder outputStringBuilder = new();
        string hashResult;

        txtSHA1Hash.Clear();
        txtSHA256Hash.Clear();
        txtSHA512Hash.Clear();

        await Cli.Wrap("openssl")
            .WithArguments($"sha1 \"{txtFilePath.Text}\"")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(outputStringBuilder))
            .ExecuteBufferedAsync();

        hashResult = outputStringBuilder.ToString().Split("= ".ToCharArray()).Last().Replace(Environment.NewLine, string.Empty);
        txtSHA1Hash.Text = hashResult;

        await Cli.Wrap("openssl")
            .WithArguments($"sha256 \"{txtFilePath.Text}\"")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(outputStringBuilder))
            .ExecuteBufferedAsync();

        hashResult = outputStringBuilder.ToString().Split("= ".ToCharArray()).Last().Replace(Environment.NewLine, string.Empty);
        txtSHA256Hash.Text = hashResult;

        await Cli.Wrap("openssl")
            .WithArguments($"sha512 \"{txtFilePath.Text}\"")
            .WithStandardOutputPipe(PipeTarget.ToStringBuilder(outputStringBuilder))
            .ExecuteBufferedAsync();

        hashResult = outputStringBuilder.ToString().Split("= ".ToCharArray()).Last().Replace(Environment.NewLine, string.Empty);
        txtSHA512Hash.Text = hashResult;
    }

    private void btnCompareSHA1_Click(object sender, EventArgs e)
    {
        HashCompareForm form = new(txtSHA1Hash.Text);
        form.ShowDialog();
    }
}
