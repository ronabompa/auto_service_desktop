namespace ServiceAutoDESKTOP.GUI
{
    partial class AppointmentsForm
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
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.CreateServiceAgentButton = new System.Windows.Forms.Button();
            this.ViewAll2DatesAppointmentsButton = new System.Windows.Forms.Button();
            this.ViewClientAppointmentsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewAppointmentsBetween2DatesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutGoodButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.viewAppointmentsBetween2DatesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.CreateServiceAgentButton);
            this.buttonsPanel.Controls.Add(this.ViewAll2DatesAppointmentsButton);
            this.buttonsPanel.Controls.Add(this.ViewClientAppointmentsButton);
            this.buttonsPanel.Location = new System.Drawing.Point(-238, -23);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(235, 470);
            this.buttonsPanel.TabIndex = 11;
            // 
            // CreateServiceAgentButton
            // 
            this.CreateServiceAgentButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateServiceAgentButton.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateServiceAgentButton.Location = new System.Drawing.Point(21, 251);
            this.CreateServiceAgentButton.Name = "CreateServiceAgentButton";
            this.CreateServiceAgentButton.Size = new System.Drawing.Size(180, 63);
            this.CreateServiceAgentButton.TabIndex = 3;
            this.CreateServiceAgentButton.Text = "Create Service Agent account";
            this.CreateServiceAgentButton.UseVisualStyleBackColor = false;
            // 
            // ViewAll2DatesAppointmentsButton
            // 
            this.ViewAll2DatesAppointmentsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewAll2DatesAppointmentsButton.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAll2DatesAppointmentsButton.Location = new System.Drawing.Point(21, 54);
            this.ViewAll2DatesAppointmentsButton.Name = "ViewAll2DatesAppointmentsButton";
            this.ViewAll2DatesAppointmentsButton.Size = new System.Drawing.Size(180, 54);
            this.ViewAll2DatesAppointmentsButton.TabIndex = 0;
            this.ViewAll2DatesAppointmentsButton.Text = "View all appointments between 2 dates";
            this.ViewAll2DatesAppointmentsButton.UseVisualStyleBackColor = false;
            // 
            // ViewClientAppointmentsButton
            // 
            this.ViewClientAppointmentsButton.BackColor = System.Drawing.Color.GhostWhite;
            this.ViewClientAppointmentsButton.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewClientAppointmentsButton.Location = new System.Drawing.Point(21, 145);
            this.ViewClientAppointmentsButton.Name = "ViewClientAppointmentsButton";
            this.ViewClientAppointmentsButton.Size = new System.Drawing.Size(180, 60);
            this.ViewClientAppointmentsButton.TabIndex = 1;
            this.ViewClientAppointmentsButton.Text = "View client\'s appointments";
            this.ViewClientAppointmentsButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(915, 455);
            this.dataGridView1.TabIndex = 9;
            // 
            // viewAppointmentsBetween2DatesPanel
            // 
            this.viewAppointmentsBetween2DatesPanel.Controls.Add(this.label1);
            this.viewAppointmentsBetween2DatesPanel.Controls.Add(this.logOutGoodButton);
            this.viewAppointmentsBetween2DatesPanel.Controls.Add(this.showButton);
            this.viewAppointmentsBetween2DatesPanel.Controls.Add(this.dataGridView1);
            this.viewAppointmentsBetween2DatesPanel.Location = new System.Drawing.Point(-6, -117);
            this.viewAppointmentsBetween2DatesPanel.Name = "viewAppointmentsBetween2DatesPanel";
            this.viewAppointmentsBetween2DatesPanel.Size = new System.Drawing.Size(1047, 932);
            this.viewAppointmentsBetween2DatesPanel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "PROGRAMARI";
            // 
            // logOutGoodButton
            // 
            this.logOutGoodButton.Font = new System.Drawing.Font("Montserrat Alternates Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutGoodButton.Location = new System.Drawing.Point(51, 154);
            this.logOutGoodButton.Name = "logOutGoodButton";
            this.logOutGoodButton.Size = new System.Drawing.Size(113, 47);
            this.logOutGoodButton.TabIndex = 16;
            this.logOutGoodButton.Text = "logout";
            this.logOutGoodButton.UseVisualStyleBackColor = true;
            this.logOutGoodButton.Click += new System.EventHandler(this.logOutGoodButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showButton.Font = new System.Drawing.Font("Montserrat Alternates Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(100, 749);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(830, 29);
            this.showButton.TabIndex = 15;
            this.showButton.Text = "SHOW";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 693);
            this.Controls.Add(this.viewAppointmentsBetween2DatesPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsForm";
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.viewAppointmentsBetween2DatesPanel.ResumeLayout(false);
            this.viewAppointmentsBetween2DatesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button CreateServiceAgentButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button ViewAll2DatesAppointmentsButton;
        private System.Windows.Forms.Button ViewClientAppointmentsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel viewAppointmentsBetween2DatesPanel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button logOutGoodButton;
        private System.Windows.Forms.Label label1;
    }
}