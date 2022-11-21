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
}
