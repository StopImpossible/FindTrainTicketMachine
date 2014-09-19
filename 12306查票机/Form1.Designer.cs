using System.Windows.Forms;
namespace _12306查票机
{
    partial class LookInto
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LeaveStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AimStation = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LeaveDate = new System.Windows.Forms.TextBox();
            this.GTrain = new System.Windows.Forms.CheckBox();
            this.DTrain = new System.Windows.Forms.CheckBox();
            this.ZTrain = new System.Windows.Forms.CheckBox();
            this.TTrain = new System.Windows.Forms.CheckBox();
            this.KTrain = new System.Windows.Forms.CheckBox();
            this.OTrain = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.DeepSearch = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.trainTicket = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.look = new System.Windows.Forms.Button();
            this.State = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yw_num = new System.Windows.Forms.CheckBox();
            this.yz_num = new System.Windows.Forms.CheckBox();
            this.rw_num = new System.Windows.Forms.CheckBox();
            this.wz_num = new System.Windows.Forms.CheckBox();
            this.FirstSeat = new System.Windows.Forms.CheckBox();
            this.SecondSeat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaveStation
            // 
            this.LeaveStation.Location = new System.Drawing.Point(74, 73);
            this.LeaveStation.Name = "LeaveStation";
            this.LeaveStation.Size = new System.Drawing.Size(100, 21);
            this.LeaveStation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "出发地";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(233, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "目的地";
            // 
            // AimStation
            // 
            this.AimStation.Location = new System.Drawing.Point(298, 74);
            this.AimStation.Name = "AimStation";
            this.AimStation.Size = new System.Drawing.Size(100, 21);
            this.AimStation.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(503, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "出发日";
            // 
            // LeaveDate
            // 
            this.LeaveDate.Location = new System.Drawing.Point(568, 80);
            this.LeaveDate.Name = "LeaveDate";
            this.LeaveDate.Size = new System.Drawing.Size(100, 21);
            this.LeaveDate.TabIndex = 6;
            this.LeaveDate.TextChanged += new System.EventHandler(this.LeaveDate_TextChanged);
            // 
            // GTrain
            // 
            this.GTrain.AutoSize = true;
            this.GTrain.Location = new System.Drawing.Point(114, 114);
            this.GTrain.Name = "GTrain";
            this.GTrain.Size = new System.Drawing.Size(96, 16);
            this.GTrain.TabIndex = 7;
            this.GTrain.Text = "GC-高铁/城际";
            this.GTrain.UseVisualStyleBackColor = true;
            // 
            // DTrain
            // 
            this.DTrain.AutoSize = true;
            this.DTrain.Location = new System.Drawing.Point(232, 115);
            this.DTrain.Name = "DTrain";
            this.DTrain.Size = new System.Drawing.Size(60, 16);
            this.DTrain.TabIndex = 8;
            this.DTrain.Text = "D-动车";
            this.DTrain.UseVisualStyleBackColor = true;
            // 
            // ZTrain
            // 
            this.ZTrain.AutoSize = true;
            this.ZTrain.Location = new System.Drawing.Point(385, 115);
            this.ZTrain.Name = "ZTrain";
            this.ZTrain.Size = new System.Drawing.Size(60, 16);
            this.ZTrain.TabIndex = 9;
            this.ZTrain.Text = "Z-直达";
            this.ZTrain.UseVisualStyleBackColor = true;
            // 
            // TTrain
            // 
            this.TTrain.AutoSize = true;
            this.TTrain.Location = new System.Drawing.Point(506, 115);
            this.TTrain.Name = "TTrain";
            this.TTrain.Size = new System.Drawing.Size(60, 16);
            this.TTrain.TabIndex = 10;
            this.TTrain.Text = "T-特快";
            this.TTrain.UseVisualStyleBackColor = true;
            // 
            // KTrain
            // 
            this.KTrain.AutoSize = true;
            this.KTrain.Location = new System.Drawing.Point(625, 115);
            this.KTrain.Name = "KTrain";
            this.KTrain.Size = new System.Drawing.Size(60, 16);
            this.KTrain.TabIndex = 11;
            this.KTrain.Text = "K-快速";
            this.KTrain.UseVisualStyleBackColor = true;
            // 
            // OTrain
            // 
            this.OTrain.AutoSize = true;
            this.OTrain.Location = new System.Drawing.Point(733, 113);
            this.OTrain.Name = "OTrain";
            this.OTrain.Size = new System.Drawing.Size(48, 16);
            this.OTrain.TabIndex = 12;
            this.OTrain.Text = "其它";
            this.OTrain.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(114, 146);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(60, 16);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "直达票";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // DeepSearch
            // 
            this.DeepSearch.AutoSize = true;
            this.DeepSearch.Location = new System.Drawing.Point(232, 146);
            this.DeepSearch.Name = "DeepSearch";
            this.DeepSearch.Size = new System.Drawing.Size(72, 16);
            this.DeepSearch.TabIndex = 14;
            this.DeepSearch.Text = "深度查票";
            this.DeepSearch.UseVisualStyleBackColor = true;
            this.DeepSearch.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(385, 145);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(96, 16);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Text = "最优乘车方案";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // trainTicket
            // 
            this.trainTicket.AllowUserToAddRows = false;
            this.trainTicket.AllowUserToDeleteRows = false;
            this.trainTicket.AllowUserToResizeColumns = false;
            this.trainTicket.AllowUserToResizeRows = false;
            this.trainTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.trainTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.trainTicket.Location = new System.Drawing.Point(12, 170);
            this.trainTicket.Name = "trainTicket";
            this.trainTicket.ReadOnly = true;
            this.trainTicket.RowTemplate.Height = 23;
            this.trainTicket.Size = new System.Drawing.Size(1013, 280);
            this.trainTicket.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "车次";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 88.26086F;
            this.Column2.HeaderText = "出发站到达站";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "出发时间到达时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "历时";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 70F;
            this.Column5.HeaderText = "商务座";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "特等座";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 70F;
            this.Column7.HeaderText = "一等座";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 70F;
            this.Column8.HeaderText = "二等座";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 60F;
            this.Column9.HeaderText = "高级软卧";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 60F;
            this.Column10.HeaderText = "软卧";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.FillWeight = 60F;
            this.Column11.HeaderText = "硬卧";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 60F;
            this.Column12.HeaderText = "软座";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 60;
            // 
            // Column13
            // 
            this.Column13.FillWeight = 60F;
            this.Column13.HeaderText = "硬座";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 60;
            // 
            // Column14
            // 
            this.Column14.FillWeight = 60F;
            this.Column14.HeaderText = "无座";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.FillWeight = 60F;
            this.Column15.HeaderText = "其它";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "车次类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "车票方案";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(561, 113);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // look
            // 
            this.look.Location = new System.Drawing.Point(867, 90);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(75, 23);
            this.look.TabIndex = 21;
            this.look.Text = "查询";
            this.look.UseVisualStyleBackColor = true;
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(781, 147);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(0, 12);
            this.State.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 12);
            this.button1.MaximumSize = new System.Drawing.Size(30, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yw_num
            // 
            this.yw_num.AutoSize = true;
            this.yw_num.Location = new System.Drawing.Point(433, 170);
            this.yw_num.Name = "yw_num";
            this.yw_num.Size = new System.Drawing.Size(48, 20);
            this.yw_num.TabIndex = 24;
            this.yw_num.Text = "硬卧";
            this.yw_num.UseCompatibleTextRendering = true;
            this.yw_num.UseVisualStyleBackColor = true;
            // 
            // yz_num
            // 
            this.yz_num.AutoSize = true;
            this.yz_num.Location = new System.Drawing.Point(568, 172);
            this.yz_num.Name = "yz_num";
            this.yz_num.Size = new System.Drawing.Size(48, 16);
            this.yz_num.TabIndex = 25;
            this.yz_num.Text = "硬座";
            this.yz_num.UseVisualStyleBackColor = true;
            // 
            // rw_num
            // 
            this.rw_num.AutoSize = true;
            this.rw_num.Location = new System.Drawing.Point(318, 172);
            this.rw_num.Name = "rw_num";
            this.rw_num.Size = new System.Drawing.Size(48, 16);
            this.rw_num.TabIndex = 26;
            this.rw_num.Text = "软卧";
            this.rw_num.UseVisualStyleBackColor = true;
            // 
            // wz_num
            // 
            this.wz_num.AutoSize = true;
            this.wz_num.Location = new System.Drawing.Point(691, 174);
            this.wz_num.Name = "wz_num";
            this.wz_num.Size = new System.Drawing.Size(48, 16);
            this.wz_num.TabIndex = 27;
            this.wz_num.Text = "无座";
            this.wz_num.UseVisualStyleBackColor = true;
            // 
            // FirstSeat
            // 
            this.FirstSeat.AutoSize = true;
            this.FirstSeat.Location = new System.Drawing.Point(74, 176);
            this.FirstSeat.Name = "FirstSeat";
            this.FirstSeat.Size = new System.Drawing.Size(60, 16);
            this.FirstSeat.TabIndex = 28;
            this.FirstSeat.Text = "一等座";
            this.FirstSeat.UseVisualStyleBackColor = true;
            this.FirstSeat.Visible = false;
            // 
            // SecondSeat
            // 
            this.SecondSeat.AutoSize = true;
            this.SecondSeat.Location = new System.Drawing.Point(195, 172);
            this.SecondSeat.Name = "SecondSeat";
            this.SecondSeat.Size = new System.Drawing.Size(60, 16);
            this.SecondSeat.TabIndex = 29;
            this.SecondSeat.Text = "二等座";
            this.SecondSeat.UseVisualStyleBackColor = true;
            this.SecondSeat.Visible = false;
            // 
            // LookInto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.SecondSeat);
            this.Controls.Add(this.FirstSeat);
            this.Controls.Add(this.wz_num);
            this.Controls.Add(this.rw_num);
            this.Controls.Add(this.yz_num);
            this.Controls.Add(this.yw_num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.look);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trainTicket);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.DeepSearch);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.OTrain);
            this.Controls.Add(this.KTrain);
            this.Controls.Add(this.TTrain);
            this.Controls.Add(this.ZTrain);
            this.Controls.Add(this.DTrain);
            this.Controls.Add(this.GTrain);
            this.Controls.Add(this.LeaveDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AimStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeaveStation);
            this.Name = "LookInto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LeaveStation;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AimStation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LeaveDate;
        private System.Windows.Forms.CheckBox GTrain;
        private System.Windows.Forms.CheckBox DTrain;
        private System.Windows.Forms.CheckBox ZTrain;
        private System.Windows.Forms.CheckBox TTrain;
        private System.Windows.Forms.CheckBox KTrain;
        private System.Windows.Forms.CheckBox OTrain;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox DeepSearch;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.DataGridView trainTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Collections.Generic.List<Station> stationList;
        private System.Windows.Forms.Button look;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox yw_num;
        private System.Windows.Forms.CheckBox yz_num;
        private System.Windows.Forms.CheckBox rw_num;
        private System.Windows.Forms.CheckBox wz_num;
        private System.Collections.Generic.List<CheckBox> First;
        private System.Collections.Generic.List<CheckBox> Second;
        private CheckBox FirstSeat;
        private CheckBox SecondSeat;
    }
}

