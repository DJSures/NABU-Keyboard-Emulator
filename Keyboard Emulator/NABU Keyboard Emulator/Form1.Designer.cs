namespace NABU_Keyboard_Emulator {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cbPort = new System.Windows.Forms.ComboBox();
      this.btnConnect = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cbJoy1 = new System.Windows.Forms.ComboBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.cbJoy2 = new System.Windows.Forms.ComboBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.tbInput = new System.Windows.Forms.TextBox();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cbPort);
      this.groupBox1.Controls.Add(this.btnConnect);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(397, 52);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Port";
      // 
      // cbPort
      // 
      this.cbPort.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbPort.FormattingEnabled = true;
      this.cbPort.Location = new System.Drawing.Point(78, 16);
      this.cbPort.Name = "cbPort";
      this.cbPort.Size = new System.Drawing.Size(316, 21);
      this.cbPort.TabIndex = 0;
      // 
      // btnConnect
      // 
      this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConnect.Location = new System.Drawing.Point(3, 16);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 33);
      this.btnConnect.TabIndex = 1;
      this.btnConnect.Text = "Open";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cbJoy1);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(0, 52);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(397, 49);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Joystick 1";
      // 
      // cbJoy1
      // 
      this.cbJoy1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbJoy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbJoy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbJoy1.FormattingEnabled = true;
      this.cbJoy1.Location = new System.Drawing.Point(3, 16);
      this.cbJoy1.Name = "cbJoy1";
      this.cbJoy1.Size = new System.Drawing.Size(391, 21);
      this.cbJoy1.TabIndex = 1;
      this.cbJoy1.SelectedIndexChanged += new System.EventHandler(this.cbJoy1_SelectedIndexChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.cbJoy2);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox3.Location = new System.Drawing.Point(0, 101);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(397, 48);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Joystick 2";
      // 
      // cbJoy2
      // 
      this.cbJoy2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbJoy2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbJoy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbJoy2.FormattingEnabled = true;
      this.cbJoy2.Location = new System.Drawing.Point(3, 16);
      this.cbJoy2.Name = "cbJoy2";
      this.cbJoy2.Size = new System.Drawing.Size(391, 21);
      this.cbJoy2.TabIndex = 1;
      this.cbJoy2.SelectedIndexChanged += new System.EventHandler(this.cbJoy2_SelectedIndexChanged);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.tbInput);
      this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox4.Location = new System.Drawing.Point(0, 149);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(397, 53);
      this.groupBox4.TabIndex = 3;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Input";
      // 
      // tbInput
      // 
      this.tbInput.BackColor = System.Drawing.Color.Black;
      this.tbInput.Cursor = System.Windows.Forms.Cursors.Hand;
      this.tbInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.tbInput.Location = new System.Drawing.Point(3, 16);
      this.tbInput.Multiline = true;
      this.tbInput.Name = "tbInput";
      this.tbInput.Size = new System.Drawing.Size(391, 34);
      this.tbInput.TabIndex = 0;
      this.tbInput.Enter += new System.EventHandler(this.tbInput_Enter);
      this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
      this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
      this.tbInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyUp);
      this.tbInput.Leave += new System.EventHandler(this.tbInput_Leave);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.tbLog);
      this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox5.Location = new System.Drawing.Point(0, 202);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(397, 208);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Log";
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.tbLog.Location = new System.Drawing.Point(3, 16);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.Size = new System.Drawing.Size(391, 189);
      this.tbLog.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 410);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "DJ\'s NABU Keyboard Emulator (v0.2b)";
      this.Activated += new System.EventHandler(this.Form1_Activated);
      this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox cbPort;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ComboBox cbJoy1;
    private System.Windows.Forms.ComboBox cbJoy2;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox tbInput;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.TextBox tbLog;
  }
}

