namespace ResourceInspector
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.Button m_btnOpen;
      this.m_combo_resource_names = new System.Windows.Forms.ComboBox();
      this.m_text_box = new System.Windows.Forms.TextBox();
      m_btnOpen = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // m_btnOpen
      // 
      m_btnOpen.Location = new System.Drawing.Point(13, 13);
      m_btnOpen.Name = "m_btnOpen";
      m_btnOpen.Size = new System.Drawing.Size(75, 23);
      m_btnOpen.TabIndex = 0;
      m_btnOpen.Text = "Open";
      m_btnOpen.UseVisualStyleBackColor = true;
      m_btnOpen.Click += new System.EventHandler(this.OpenFile);
      // 
      // m_combo_resource_names
      // 
      this.m_combo_resource_names.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_combo_resource_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.m_combo_resource_names.FormattingEnabled = true;
      this.m_combo_resource_names.Location = new System.Drawing.Point(126, 14);
      this.m_combo_resource_names.Name = "m_combo_resource_names";
      this.m_combo_resource_names.Size = new System.Drawing.Size(622, 21);
      this.m_combo_resource_names.TabIndex = 1;
      this.m_combo_resource_names.SelectedIndexChanged += new System.EventHandler(this.OnResourceSelect);
      // 
      // m_text_box
      // 
      this.m_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_text_box.Location = new System.Drawing.Point(13, 43);
      this.m_text_box.Multiline = true;
      this.m_text_box.Name = "m_text_box";
      this.m_text_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.m_text_box.Size = new System.Drawing.Size(735, 571);
      this.m_text_box.TabIndex = 2;
      this.m_text_box.WordWrap = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(760, 626);
      this.Controls.Add(this.m_text_box);
      this.Controls.Add(this.m_combo_resource_names);
      this.Controls.Add(m_btnOpen);
      this.Name = "Form1";
      this.Text = "XML Resource Inspector";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox m_combo_resource_names;
    private System.Windows.Forms.TextBox m_text_box;
  }
}

