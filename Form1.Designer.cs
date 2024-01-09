namespace Blockchain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Blockchain Ledger...");
            ListViewItem listViewItem2 = new ListViewItem("Mining (every 50000th hash)...");
            startHostingButton = new Button();
            mineButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nodeNameTextBox = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            connectPortButton = new Button();
            label4 = new Label();
            label5 = new Label();
            hostPort = new Label();
            hostIP = new Label();
            label6 = new Label();
            statusLabel = new Label();
            blockChainLedgerlistView = new ListView();
            miningListView = new ListView();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // startHostingButton
            // 
            startHostingButton.Location = new Point(245, 49);
            startHostingButton.Name = "startHostingButton";
            startHostingButton.Size = new Size(106, 23);
            startHostingButton.TabIndex = 0;
            startHostingButton.Text = "Start Hosting";
            startHostingButton.UseVisualStyleBackColor = true;
            // 
            // mineButton
            // 
            mineButton.Location = new Point(354, 49);
            mineButton.Name = "mineButton";
            mineButton.Size = new Size(75, 23);
            mineButton.TabIndex = 1;
            mineButton.Text = "Mine";
            mineButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Node name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(541, 32);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Hosts IP";
            // 
            // nodeNameTextBox
            // 
            nodeNameTextBox.Location = new Point(89, 50);
            nodeNameTextBox.Name = "nodeNameTextBox";
            nodeNameTextBox.Size = new Size(150, 23);
            nodeNameTextBox.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(647, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(541, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // connectPortButton
            // 
            connectPortButton.Location = new Point(753, 50);
            connectPortButton.Name = "connectPortButton";
            connectPortButton.Size = new Size(96, 23);
            connectPortButton.TabIndex = 8;
            connectPortButton.Text = "Connect to port";
            connectPortButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(647, 32);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 9;
            label4.Text = "PORT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 27);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 10;
            label5.Text = "Hosts Port";
            // 
            // hostPort
            // 
            hostPort.AutoSize = true;
            hostPort.Location = new Point(81, 27);
            hostPort.Name = "hostPort";
            hostPort.Size = new Size(62, 15);
            hostPort.TabIndex = 12;
            hostPort.Text = "Hosts Port";
            // 
            // hostIP
            // 
            hostIP.AutoSize = true;
            hostIP.Location = new Point(81, 5);
            hostIP.Name = "hostIP";
            hostIP.Size = new Size(50, 15);
            hostIP.TabIndex = 11;
            hostIP.Text = "Hosts IP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 105);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(60, 105);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(48, 15);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "-status-";
            // 
            // blockChainLedgerlistView
            // 
            blockChainLedgerlistView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            blockChainLedgerlistView.Location = new Point(12, 148);
            blockChainLedgerlistView.Name = "blockChainLedgerlistView";
            blockChainLedgerlistView.Size = new Size(349, 271);
            blockChainLedgerlistView.TabIndex = 21;
            blockChainLedgerlistView.UseCompatibleStateImageBehavior = false;
            blockChainLedgerlistView.View = View.List;
            // 
            // miningListView
            // 
            miningListView.Items.AddRange(new ListViewItem[] { listViewItem2 });
            miningListView.Location = new Point(541, 148);
            miningListView.Name = "miningListView";
            miningListView.Size = new Size(349, 271);
            miningListView.TabIndex = 22;
            miningListView.UseCompatibleStateImageBehavior = false;
            miningListView.View = View.List;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 27);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 23;
            label7.Text = "Server side of app";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(647, 9);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 24;
            label8.Text = "Client side of app";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(miningListView);
            Controls.Add(blockChainLedgerlistView);
            Controls.Add(statusLabel);
            Controls.Add(label6);
            Controls.Add(hostPort);
            Controls.Add(hostIP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(connectPortButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(nodeNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mineButton);
            Controls.Add(startHostingButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startHostingButton;
        private Button mineButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nodeNameTextBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button connectPortButton;
        private Label label4;
        private Label label5;
        private Label hostPort;
        private Label hostIP;
        private Label label6;
        private Label statusLabel;
        private ListView blockChainLedgerlistView;
        private ListView miningListView;
        private Label label7;
        private Label label8;
    }
}
