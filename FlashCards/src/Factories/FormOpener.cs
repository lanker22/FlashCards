using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace src
{
    public class FormOpener : IFormOpener
    {
        private readonly IHost host;
        private readonly Dictionary<Type, Form> openedForms;

        public FormOpener(IHost host)
        {
            this.host = host;
            openedForms = new Dictionary<Type, Form>();
        }
        public Form ShowModelessForm<TForm>() where TForm : Form
        {
            Form form;
            if (openedForms.ContainsKey(typeof(TForm)))
            {
                form = openedForms[typeof(TForm)];
            }
            else
            {
                form = GetForm<TForm>();
                openedForms.Add(form.GetType(), form);
                form.FormClosed += (s, e) => openedForms.Remove(form.GetType());
            }
            form.Show();
            return form;
        }

        private Form GetForm<TForm>() where TForm : Form
        {
            return ActivatorUtilities.GetServiceOrCreateInstance<TForm>(host.Services);
        }

        public DialogResult ShowModalForm<TForm>() where TForm : Form
        {
            using(var form = GetForm<TForm>())
            {
                return form.ShowDialog();
            }
        }
    }
}
