namespace InterviewManagementForm
{
    partial class InterviewEvalutaion
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
            this.components = new System.ComponentModel.Container();
            this.grpCandidateContext = new System.Windows.Forms.GroupBox();
            this.lblCandidate = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblInterviewer = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.grpVerdict = new System.Windows.Forms.GroupBox();
            this.cmbRecommendation = new System.Windows.Forms.ComboBox();
            this.lblPanelAssessment = new System.Windows.Forms.Label();
            this.grpScoring = new System.Windows.Forms.GroupBox();
            this.lblTechSkill = new System.Windows.Forms.Label();
            this.lblProblemSolving = new System.Windows.Forms.Label();
            this.lblCommunication = new System.Windows.Forms.Label();
            this.numTechScore = new System.Windows.Forms.NumericUpDown();
            this.numCommScore = new System.Windows.Forms.NumericUpDown();
            this.numProblemScore = new System.Windows.Forms.NumericUpDown();
            this.lblEvalRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPassFailGroup = new System.Windows.Forms.Panel();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.btnSubmitEvaluation = new System.Windows.Forms.Button();
            this.grpCandidateContext.SuspendLayout();
            this.grpVerdict.SuspendLayout();
            this.grpScoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTechScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProblemScore)).BeginInit();
            this.pnlPassFailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCandidateContext
            // 
            this.grpCandidateContext.BackColor = System.Drawing.Color.Transparent;
            this.grpCandidateContext.Controls.Add(this.txtInterviewer);
            this.grpCandidateContext.Controls.Add(this.txtPosition);
            this.grpCandidateContext.Controls.Add(this.txtApplicantName);
            this.grpCandidateContext.Controls.Add(this.lblInterviewer);
            this.grpCandidateContext.Controls.Add(this.lblPosition);
            this.grpCandidateContext.Controls.Add(this.lblCandidate);
            this.grpCandidateContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCandidateContext.Location = new System.Drawing.Point(36, 146);
            this.grpCandidateContext.Name = "grpCandidateContext";
            this.grpCandidateContext.Size = new System.Drawing.Size(474, 236);
            this.grpCandidateContext.TabIndex = 0;
            this.grpCandidateContext.TabStop = false;
            this.grpCandidateContext.Text = "👤 Candidate Data Context";
            // 
            // lblCandidate
            // 
            this.lblCandidate.AutoSize = true;
            this.lblCandidate.Location = new System.Drawing.Point(24, 59);
            this.lblCandidate.Name = "lblCandidate";
            this.lblCandidate.Size = new System.Drawing.Size(103, 25);
            this.lblCandidate.TabIndex = 1;
            this.lblCandidate.Text = "Candidate:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(24, 116);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(85, 25);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // lblInterviewer
            // 
            this.lblInterviewer.AutoSize = true;
            this.lblInterviewer.Location = new System.Drawing.Point(24, 174);
            this.lblInterviewer.Name = "lblInterviewer";
            this.lblInterviewer.Size = new System.Drawing.Size(116, 25);
            this.lblInterviewer.TabIndex = 3;
            this.lblInterviewer.Text = "Interviewer:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(133, 59);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(315, 31);
            this.txtApplicantName.TabIndex = 4;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(115, 116);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(315, 31);
            this.txtPosition.TabIndex = 5;
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(146, 174);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.ReadOnly = true;
            this.txtInterviewer.Size = new System.Drawing.Size(315, 31);
            this.txtInterviewer.TabIndex = 6;
            // 
            // grpVerdict
            // 
            this.grpVerdict.BackColor = System.Drawing.Color.Transparent;
            this.grpVerdict.Controls.Add(this.lblPanelAssessment);
            this.grpVerdict.Controls.Add(this.cmbRecommendation);
            this.grpVerdict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerdict.Location = new System.Drawing.Point(36, 418);
            this.grpVerdict.Name = "grpVerdict";
            this.grpVerdict.Size = new System.Drawing.Size(474, 139);
            this.grpVerdict.TabIndex = 2;
            this.grpVerdict.TabStop = false;
            this.grpVerdict.Text = "💼 Sourcing Recommendation";
            // 
            // cmbRecommendation
            // 
            this.cmbRecommendation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecommendation.FormattingEnabled = true;
            this.cmbRecommendation.Items.AddRange(new object[] {
            "HIre",
            "Consider for other role",
            "Hold for future vacancy"});
            this.cmbRecommendation.Location = new System.Drawing.Point(29, 79);
            this.cmbRecommendation.Name = "cmbRecommendation";
            this.cmbRecommendation.Size = new System.Drawing.Size(296, 33);
            this.cmbRecommendation.TabIndex = 0;
            // 
            // lblPanelAssessment
            // 
            this.lblPanelAssessment.AutoSize = true;
            this.lblPanelAssessment.Location = new System.Drawing.Point(24, 51);
            this.lblPanelAssessment.Name = "lblPanelAssessment";
            this.lblPanelAssessment.Size = new System.Drawing.Size(168, 25);
            this.lblPanelAssessment.TabIndex = 7;
            this.lblPanelAssessment.Text = "Panel Assessment:";
            // 
            // grpScoring
            // 
            this.grpScoring.BackColor = System.Drawing.Color.Transparent;
            this.grpScoring.Controls.Add(this.pnlPassFailGroup);
            this.grpScoring.Controls.Add(this.label1);
            this.grpScoring.Controls.Add(this.txtRemarks);
            this.grpScoring.Controls.Add(this.lblEvalRemarks);
            this.grpScoring.Controls.Add(this.numProblemScore);
            this.grpScoring.Controls.Add(this.numCommScore);
            this.grpScoring.Controls.Add(this.numTechScore);
            this.grpScoring.Controls.Add(this.lblCommunication);
            this.grpScoring.Controls.Add(this.lblProblemSolving);
            this.grpScoring.Controls.Add(this.lblTechSkill);
            this.grpScoring.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScoring.Location = new System.Drawing.Point(596, 146);
            this.grpScoring.Name = "grpScoring";
            this.grpScoring.Size = new System.Drawing.Size(567, 618);
            this.grpScoring.TabIndex = 3;
            this.grpScoring.TabStop = false;
            this.grpScoring.Text = "📊 Evaluation Scores Tracker";
            // 
            // lblTechSkill
            // 
            this.lblTechSkill.AutoSize = true;
            this.lblTechSkill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechSkill.Location = new System.Drawing.Point(6, 59);
            this.lblTechSkill.Name = "lblTechSkill";
            this.lblTechSkill.Size = new System.Drawing.Size(136, 25);
            this.lblTechSkill.TabIndex = 7;
            this.lblTechSkill.Text = "Technical Skill:";
            // 
            // lblProblemSolving
            // 
            this.lblProblemSolving.AutoSize = true;
            this.lblProblemSolving.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemSolving.Location = new System.Drawing.Point(6, 174);
            this.lblProblemSolving.Name = "lblProblemSolving";
            this.lblProblemSolving.Size = new System.Drawing.Size(156, 25);
            this.lblProblemSolving.TabIndex = 8;
            this.lblProblemSolving.Text = "Problem Solving:";
            // 
            // lblCommunication
            // 
            this.lblCommunication.AutoSize = true;
            this.lblCommunication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommunication.Location = new System.Drawing.Point(6, 116);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new System.Drawing.Size(151, 25);
            this.lblCommunication.TabIndex = 9;
            this.lblCommunication.Text = "Communication:";
            // 
            // numTechScore
            // 
            this.numTechScore.Location = new System.Drawing.Point(148, 59);
            this.numTechScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTechScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTechScore.Name = "numTechScore";
            this.numTechScore.Size = new System.Drawing.Size(120, 29);
            this.numTechScore.TabIndex = 10;
            this.numTechScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCommScore
            // 
            this.numCommScore.Location = new System.Drawing.Point(163, 116);
            this.numCommScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCommScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCommScore.Name = "numCommScore";
            this.numCommScore.Size = new System.Drawing.Size(120, 29);
            this.numCommScore.TabIndex = 11;
            this.numCommScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numProblemScore
            // 
            this.numProblemScore.Location = new System.Drawing.Point(163, 176);
            this.numProblemScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numProblemScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProblemScore.Name = "numProblemScore";
            this.numProblemScore.Size = new System.Drawing.Size(120, 29);
            this.numProblemScore.TabIndex = 12;
            this.numProblemScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEvalRemarks
            // 
            this.lblEvalRemarks.AutoSize = true;
            this.lblEvalRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvalRemarks.Location = new System.Drawing.Point(6, 259);
            this.lblEvalRemarks.Name = "lblEvalRemarks";
            this.lblEvalRemarks.Size = new System.Drawing.Size(294, 25);
            this.lblEvalRemarks.TabIndex = 13;
            this.lblEvalRemarks.Text = "✍️ Evaluator Notes and Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(11, 287);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(536, 109);
            this.txtRemarks.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "⚡ Pass / Fail Status Trigger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlPassFailGroup
            // 
            this.pnlPassFailGroup.Controls.Add(this.rbFail);
            this.pnlPassFailGroup.Controls.Add(this.rbPass);
            this.pnlPassFailGroup.Location = new System.Drawing.Point(11, 489);
            this.pnlPassFailGroup.Name = "pnlPassFailGroup";
            this.pnlPassFailGroup.Size = new System.Drawing.Size(536, 100);
            this.pnlPassFailGroup.TabIndex = 4;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbPass.Location = new System.Drawing.Point(50, 36);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(180, 25);
            this.rbPass.TabIndex = 0;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "PASS APPLICATION";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.ForeColor = System.Drawing.Color.Firebrick;
            this.rbFail.Location = new System.Drawing.Point(321, 36);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(173, 25);
            this.rbFail.TabIndex = 1;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "FAIL APPLICATION";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // btnSubmitEvaluation
            // 
            this.btnSubmitEvaluation.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmitEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEvaluation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEvaluation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmitEvaluation.Location = new System.Drawing.Point(928, 797);
            this.btnSubmitEvaluation.Name = "btnSubmitEvaluation";
            this.btnSubmitEvaluation.Size = new System.Drawing.Size(248, 37);
            this.btnSubmitEvaluation.TabIndex = 5;
            this.btnSubmitEvaluation.Text = "💾 Submit Evaluation";
            this.btnSubmitEvaluation.UseVisualStyleBackColor = false;
            // 
            // InterviewEvalutaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterviewManagementForm.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(1268, 907);
            this.Controls.Add(this.btnSubmitEvaluation);
            this.Controls.Add(this.grpScoring);
            this.Controls.Add(this.grpVerdict);
            this.Controls.Add(this.grpCandidateContext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterviewEvalutaion";
            this.Text = "Form1";
            this.grpCandidateContext.ResumeLayout(false);
            this.grpCandidateContext.PerformLayout();
            this.grpVerdict.ResumeLayout(false);
            this.grpVerdict.PerformLayout();
            this.grpScoring.ResumeLayout(false);
            this.grpScoring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTechScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProblemScore)).EndInit();
            this.pnlPassFailGroup.ResumeLayout(false);
            this.pnlPassFailGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCandidateContext;
        private System.Windows.Forms.Label lblInterviewer;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCandidate;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpVerdict;
        private System.Windows.Forms.ComboBox cmbRecommendation;
        private System.Windows.Forms.Label lblPanelAssessment;
        private System.Windows.Forms.GroupBox grpScoring;
        private System.Windows.Forms.Label lblCommunication;
        private System.Windows.Forms.Label lblProblemSolving;
        private System.Windows.Forms.Label lblTechSkill;
        private System.Windows.Forms.Label lblEvalRemarks;
        private System.Windows.Forms.NumericUpDown numProblemScore;
        private System.Windows.Forms.NumericUpDown numCommScore;
        private System.Windows.Forms.NumericUpDown numTechScore;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel pnlPassFailGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.Button btnSubmitEvaluation;
    }
}

