using System.Windows.Forms;

namespace src
{
    public interface IFormOpener
    {
        Form ShowModelessForm<TForm>() where TForm : Form;
        DialogResult ShowModalForm<TForm>() where TForm : Form;    
    }
}