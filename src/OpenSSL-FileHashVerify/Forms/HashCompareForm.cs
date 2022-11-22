namespace OpenSSL_FileHashVerify.Forms;

public partial class HashCompareForm : Form
{
    public HashCompareForm(string hash)
    {
        InitializeComponent();

        txtHash.Text = hash;
    }

    private void txtInputHash_TextChanged(object sender, EventArgs e)
    {
        string equalityResult = (txtHash.Text == txtInputHash.Text) ? "Equal" : "NOT Equal";
        lblResult.Text = string.Format("The hashes are {0}", equalityResult);
    }
}
