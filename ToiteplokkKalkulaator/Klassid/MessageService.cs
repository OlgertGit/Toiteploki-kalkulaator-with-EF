using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToiteplokkKalkulaator.Klassid
{

public interface IMessageService
{
    void MessageInformation(string text, string caption);
    void MessageExclamation(string text, string caption);
    void MessageError(string text, string caption);

}

public class MessageService: IMessageService
{
    public void MessageInformation(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public void MessageExclamation(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    public void MessageError(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
}
