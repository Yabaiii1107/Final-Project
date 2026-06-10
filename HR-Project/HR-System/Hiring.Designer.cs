namespace FinalHiringDecisionForm
{
    partial class Hiring
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
            this.grpDossier = new System.Windows.Forms.GroupBox();
            this.lblPosLabel = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScreenLabel = new System.Windows.Forms.Label();
            this.txtScreenStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInterviewScore = new System.Windows.Forms.TextBox();
            this.txtPanelRec = new System.Windows.Forms.TextBox();
            this.grpResolution = new System.Windows.Forms.GroupBox();
            this.lblDecisionHeading = new System.Windows.Forms.Label();
            this.pnlActionRadioGroup = new System.Windows.Forms.Panel();
            this.rbAccept = new System.Windows.Forms.RadioButton();
            this.rbHold = new System.Windows.Forms.RadioButton();
            this.rbReject = new System.Windows.Forms.RadioButton();
            this.lblRemarksHeading = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnCommitResolution = new System.Windows.Forms.Button();
            this.grpDossier.SuspendLayout();
            this.grpResolution.SuspendLayout();
            this.pnlActionRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDossier
            // 
            this.grpDossier.BackColor = System.Drawing.Color.Transparent;
            this.grpDossier.Controls.Add(this.txtPanelRec);
            this.grpDossier.Controls.Add(this.txtInterviewScore);
            this.grpDossier.Controls.Add(this.label3);
            this.grpDossier.Controls.Add(this.label2);
            this.grpDossier.Controls.Add(this.txtScreenStatus);
            this.grpDossier.Controls.Add(this.lblScreenLabel);
            this.grpDossier.Controls.Add(this.label1);
            this.grpDossier.Controls.Add(this.txtPosition);
            this.grpDossier.Controls.Add(this.lblPosLabel);
            this.grpDossier.Controls.Add(this.lblApplicantName);
            this.grpDossier.Controls.Add(this.txtApplicantName);
            this.grpDossier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDossier.Location = new System.Drawing.Point(30, 148);
            this.grpDossier.Name = "grpDossier";
            this.grpDossier.Size = new System.Drawing.Size(492, 417);
            this.grpDossier.TabIndex = 0;
            this.grpDossier.TabStop = false;
            this.grpDossier.Text = "📂 Candidate History Summary Dossier";
            // 
            // lblPosLabel
            // 
            this.lblPosLabel.AutoSize = true;
            this.lblPosLabel.Location = new System.Drawing.Point(19, 112);
            this.lblPosLabel.Name = "lblPosLabel";
            this.lblPosLabel.Size = new System.Drawing.Size(85, 25);
            this.lblPosLabel.TabIndex = 2;
            this.lblPosLabel.Text = "Position:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(19, 57);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(154, 25);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "Applicant Name:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(179, 57);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(290, 31);
            this.txtApplicantName.TabIndex = 0;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(110, 112);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(290, 31);
            this.txtPosition.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "📊 Pipeline Performance:";
            // 
            // lblScreenLabel
            // 
            this.lblScreenLabel.AutoSize = true;
            this.lblScreenLabel.Location = new System.Drawing.Point(19, 258);
            this.lblScreenLabel.Name = "lblScreenLabel";
            this.lblScreenLabel.Size = new System.Drawing.Size(101, 25);
            this.lblScreenLabel.TabIndex = 5;
            this.lblScreenLabel.Text = "Screening:";
            // 
            // txtScreenStatus
            // 
            this.txtScreenStatus.Location = new System.Drawing.Point(126, 258);
            this.txtScreenStatus.Name = "txtScreenStatus";
            this.txtScreenStatus.ReadOnly = true;
            this.txtScreenStatus.Size = new System.Drawing.Size(290, 31);
            this.txtScreenStatus.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Panel Rec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interview:";
            // 
            // txtInterviewScore
            // 
            this.txtInterviewScore.Location = new System.Drawing.Point(126, 315);
            this.txtInterviewScore.Name = "txtInterviewScore";
            this.txtInterviewScore.ReadOnly = true;
            this.txtInterviewScore.Size = new System.Drawing.Size(290, 31);
            this.txtInterviewScore.TabIndex = 9;
            // 
            // txtPanelRec
            // 
            this.txtPanelRec.Location = new System.Drawing.Point(126, 364);
            this.txtPanelRec.Name = "txtPanelRec";
            this.txtPanelRec.ReadOnly = true;
            this.txtPanelRec.Size = new System.Drawing.Size(290, 31);
            this.txtPanelRec.TabIndex = 10;
            // 
            // grpResolution
            // 
            this.grpResolution.BackColor = System.Drawing.Color.Transparent;
            this.grpResolution.Controls.Add(this.txtRemarks);
            this.grpResolution.Controls.Add(this.lblRemarksHeading);
            this.grpResolution.Controls.Add(this.pnlActionRadioGroup);
            this.grpResolution.Controls.Add(this.lblDecisionHeading);
            this.grpResolution.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResolution.Location = new System.Drawing.Point(576, 148);
            this.grpResolution.Name = "grpResolution";
            this.grpResolution.Size = new System.Drawing.Size(558, 417);
            this.grpResolution.TabIndex = 1;
            this.grpResolution.TabStop = false;
            this.grpResolution.Text = "⚖️ Executive Status and Resolution Engine";
            // 
            // lblDecisionHeading
            // 
            this.lblDecisionHeading.AutoSize = true;
            this.lblDecisionHeading.Location = new System.Drawing.Point(19, 57);
            this.lblDecisionHeading.Name = "lblDecisionHeading";
            this.lblDecisionHeading.Size = new System.Drawing.Size(251, 25);
            this.lblDecisionHeading.TabIndex = 0;
            this.lblDecisionHeading.Text = "Select Final Action Decision:";
            // 
            // pnlActionRadioGroup
            // 
            this.pnlActionRadioGroup.Controls.Add(this.rbReject);
            this.pnlActionRadioGroup.Controls.Add(this.rbHold);
            this.pnlActionRadioGroup.Controls.Add(this.rbAccept);
            this.pnlActionRadioGroup.Location = new System.Drawing.Point(24, 95);
            this.pnlActionRadioGroup.Name = "pnlActionRadioGroup";
            this.pnlActionRadioGroup.Size = new System.Drawing.Size(506, 134);
            this.pnlActionRadioGroup.TabIndex = 1;
            // 
            // rbAccept
            // 
            this.rbAccept.AutoSize = true;
            this.rbAccept.Location = new System.Drawing.Point(31, 15);
            this.rbAccept.Name = "rbAccept";
            this.rbAccept.Size = new System.Drawing.Size(266, 29);
            this.rbAccept.TabIndex = 0;
            this.rbAccept.TabStop = true;
            this.rbAccept.Text = "Accept and Generate Offer";
            this.rbAccept.UseVisualStyleBackColor = true;
            // 
            // rbHold
            // 
            this.rbHold.AutoSize = true;
            this.rbHold.Location = new System.Drawing.Point(31, 50);
            this.rbHold.Name = "rbHold";
            this.rbHold.Size = new System.Drawing.Size(229, 29);
            this.rbHold.TabIndex = 1;
            this.rbHold.TabStop = true;
            this.rbHold.Text = "Put Applicant On Hold";
            this.rbHold.UseVisualStyleBackColor = true;
            // 
            // rbReject
            // 
            this.rbReject.AutoSize = true;
            this.rbReject.Location = new System.Drawing.Point(31, 85);
            this.rbReject.Name = "rbReject";
            this.rbReject.Size = new System.Drawing.Size(276, 29);
            this.rbReject.TabIndex = 2;
            this.rbReject.TabStop = true;
            this.rbReject.Text = "Reject Application / Archive";
            this.rbReject.UseVisualStyleBackColor = true;
            // 
            // lblRemarksHeading
            // 
            this.lblRemarksHeading.AutoSize = true;
            this.lblRemarksHeading.Location = new System.Drawing.Point(19, 264);
            this.lblRemarksHeading.Name = "lblRemarksHeading";
            this.lblRemarksHeading.Size = new System.Drawing.Size(309, 25);
            this.lblRemarksHeading.TabIndex = 2;
            this.lblRemarksHeading.Text = "✍️ Executive Board Final Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(24, 292);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(506, 119);
            this.txtRemarks.TabIndex = 3;
            // 
            // btnCommitResolution
            // 
            this.btnCommitResolution.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCommitResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommitResolution.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommitResolution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCommitResolution.Location = new System.Drawing.Point(848, 606);
            this.btnCommitResolution.Name = "btnCommitResolution";
            this.btnCommitResolution.Size = new System.Drawing.Size(277, 45);
            this.btnCommitResolution.TabIndex = 2;
            this.btnCommitResolution.Text = "🔒 Commit Resolution";
            this.btnCommitResolution.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalHiringDecisionForm.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(1191, 808);
            this.Controls.Add(this.btnCommitResolution);
            this.Controls.Add(this.grpResolution);
            this.Controls.Add(this.grpDossier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDossier.ResumeLayout(false);
            this.grpDossier.PerformLayout();
            this.grpResolution.ResumeLayout(false);
            this.grpResolution.PerformLayout();
            this.pnlActionRadioGroup.ResumeLayout(false);
            this.pnlActionRadioGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDossier;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.Label lblPosLabel;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblScreenLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScreenStatus;
        private System.Windows.Forms.TextBox txtPanelRec;
        private System.Windows.Forms.TextBox txtInterviewScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpResolution;
        private System.Windows.Forms.Panel pnlActionRadioGroup;
        private System.Windows.Forms.RadioButton rbHold;
        private System.Windows.Forms.RadioButton rbAccept;
        private System.Windows.Forms.Label lblDecisionHeading;
        private System.Windows.Forms.RadioButton rbReject;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarksHeading;
        private System.Windows.Forms.Button btnCommitResolution;
    }
}

