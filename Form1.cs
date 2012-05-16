using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResourceInspector
{
  public partial class Form1 : Form
  {
    System.Reflection.Assembly m_assembly;
    public Form1()
    {
      InitializeComponent();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        string path = ofd.FileName;
        var asm = System.Reflection.Assembly.LoadFrom(path);
        string[] resources = asm.GetManifestResourceNames();
        m_assembly = asm;
        m_combo_resource_names.Items.Clear();
        List<string> items = new List<string>();
        foreach (string resource in resources)
        {
          if( resource.EndsWith(".xml",StringComparison.InvariantCultureIgnoreCase) )
            items.Add(resource);
        }
        m_combo_resource_names.Items.AddRange(items.ToArray());
      }
    }

    private void OnResourceSelect(object sender, EventArgs e)
    {
      string resource = m_combo_resource_names.SelectedItem as string;
      if (m_assembly!=null && !string.IsNullOrEmpty(resource))
      {
        var resourceStream = m_assembly.GetManifestResourceStream(resource);
        System.IO.StreamReader stream = new System.IO.StreamReader(resourceStream);
        string s = stream.ReadToEnd();
        m_text_box.Text = s;
        stream.Close();
      }
    }
  }
}
