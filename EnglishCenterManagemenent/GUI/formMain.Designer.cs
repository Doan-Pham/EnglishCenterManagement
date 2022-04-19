
namespace EnglishCenterManagemenent
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStudent = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPaletteGeneral = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.buttonEmployee = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonClass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonCourse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonDashboard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelCurrentUser = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.pictureBoxCurrentUser = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCurrentUserControl = new System.Windows.Forms.Panel();
            this.labelCurrentUserControl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.userControlDashboard = new EnglishCenterManagemenent.GUI.UserControlDashboard();
            this.userControlStudents = new EnglishCenterManagemenent.GUI.UserControlStudents();
            this.userControlStudentAttendance = new EnglishCenterManagemenent.GUI.UserControlStudentAttendance();
            this.userControlStudentGrades = new EnglishCenterManagemenent.GUI.UserControlStudentGrades();
            this.userControlCourses = new EnglishCenterManagemenent.GUI.UserControlCourses();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCurrentUser)).BeginInit();
            this.panelCurrentUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentUser)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelCurrentUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.buttonStudent);
            this.panelMenu.Controls.Add(this.buttonEmployee);
            this.panelMenu.Controls.Add(this.buttonClass);
            this.panelMenu.Controls.Add(this.buttonCourse);
            this.panelMenu.Controls.Add(this.buttonUser);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.panelCurrentUser);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(318, 894);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonStudent
            // 
            this.buttonStudent.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.buttonStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.Location = new System.Drawing.Point(0, 652);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Palette = this.kryptonPaletteGeneral;
            this.buttonStudent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStudent.Size = new System.Drawing.Size(318, 82);
            this.buttonStudent.TabIndex = 16;
            this.buttonStudent.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_student_32px_gray;
            this.buttonStudent.Values.Text = "Student";
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // kryptonPaletteGeneral
            // 
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Rounding = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Width = 0;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 0;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.OverrideFocus.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.AdjacentGap = 30;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.Padding = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.AdjacentGap = 30;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.Padding = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.AdjacentGap = 30;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.Padding = new System.Windows.Forms.Padding(40, 0, 50, 0);
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonNavigatorStack.StateTracking.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 0;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Be Vietnam ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateNormal.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateNormal.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorAngle = 45F;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.StateTracking.Border.Width = 0;
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(168)))), ((int)(((byte)(47)))));
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Border.Rounding = 10;
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Border.Width = 2;
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(60, 15, 0, 15);
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Inter Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.InputControlStyles.InputControlStandalone.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.ColorAngle = 45F;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.ColorAngle = 45F;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.LabelStyles.LabelCustom1.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.buttonEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployee.Location = new System.Drawing.Point(0, 570);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Palette = this.kryptonPaletteGeneral;
            this.buttonEmployee.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEmployee.Size = new System.Drawing.Size(318, 82);
            this.buttonEmployee.TabIndex = 15;
            this.buttonEmployee.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_education_32px_gray;
            this.buttonEmployee.Values.Text = "Employee";
            // 
            // buttonClass
            // 
            this.buttonClass.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.buttonClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClass.Location = new System.Drawing.Point(0, 488);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Palette = this.kryptonPaletteGeneral;
            this.buttonClass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonClass.Size = new System.Drawing.Size(318, 82);
            this.buttonClass.TabIndex = 14;
            this.buttonClass.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_pencil_32px_gray;
            this.buttonClass.Values.Text = "Class";
            // 
            // buttonCourse
            // 
            this.buttonCourse.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.buttonCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCourse.Location = new System.Drawing.Point(0, 406);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Palette = this.kryptonPaletteGeneral;
            this.buttonCourse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCourse.Size = new System.Drawing.Size(318, 82);
            this.buttonCourse.TabIndex = 13;
            this.buttonCourse.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_book_32px_gray;
            this.buttonCourse.Values.Text = "Course";
            this.buttonCourse.Click += new System.EventHandler(this.buttonCourse_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.buttonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.Location = new System.Drawing.Point(0, 324);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Palette = this.kryptonPaletteGeneral;
            this.buttonUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUser.Size = new System.Drawing.Size(318, 82);
            this.buttonUser.TabIndex = 12;
            this.buttonUser.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_user_thin_32px_gray;
            this.buttonUser.Values.Text = "User";
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 242);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Palette = this.kryptonPaletteGeneral;
            this.buttonDashboard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDashboard.Size = new System.Drawing.Size(318, 82);
            this.buttonDashboard.TabIndex = 11;
            this.buttonDashboard.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_home_32px_gray;
            this.buttonDashboard.Values.Text = "Dashboard";
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelCurrentUser
            // 
            this.panelCurrentUser.Controls.Add(this.labelCurrentUser);
            this.panelCurrentUser.Controls.Add(this.pictureBoxCurrentUser);
            this.panelCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.panelCurrentUser.Name = "panelCurrentUser";
            this.panelCurrentUser.Size = new System.Drawing.Size(318, 242);
            this.panelCurrentUser.StateNormal.Color1 = System.Drawing.Color.White;
            this.panelCurrentUser.StateNormal.Color2 = System.Drawing.Color.White;
            this.panelCurrentUser.StateNormal.ColorAngle = 45F;
            this.panelCurrentUser.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.panelCurrentUser.TabIndex = 0;
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentUser.ForeColor = System.Drawing.Color.Black;
            this.labelCurrentUser.Location = new System.Drawing.Point(93, 186);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(131, 39);
            this.labelCurrentUser.TabIndex = 0;
            this.labelCurrentUser.Text = "Username";
            // 
            // pictureBoxCurrentUser
            // 
            this.pictureBoxCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCurrentUser.Image")));
            this.pictureBoxCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCurrentUser.Name = "pictureBoxCurrentUser";
            this.pictureBoxCurrentUser.Size = new System.Drawing.Size(318, 225);
            this.pictureBoxCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCurrentUser.TabIndex = 1;
            this.pictureBoxCurrentUser.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.userControlDashboard);
            this.panelMain.Controls.Add(this.userControlStudents);
            this.panelMain.Controls.Add(this.userControlStudentAttendance);
            this.panelMain.Controls.Add(this.userControlStudentGrades);
            this.panelMain.Controls.Add(this.userControlCourses);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(318, 106);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1110, 788);
            this.panelMain.TabIndex = 1;
            // 
            // panelCurrentUserControl
            // 
            this.panelCurrentUserControl.BackColor = System.Drawing.Color.Transparent;
            this.panelCurrentUserControl.Controls.Add(this.labelCurrentUserControl);
            this.panelCurrentUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentUserControl.Location = new System.Drawing.Point(318, 0);
            this.panelCurrentUserControl.Name = "panelCurrentUserControl";
            this.panelCurrentUserControl.Size = new System.Drawing.Size(1110, 100);
            this.panelCurrentUserControl.TabIndex = 2;
            // 
            // labelCurrentUserControl
            // 
            this.labelCurrentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentUserControl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.labelCurrentUserControl.Location = new System.Drawing.Point(0, 0);
            this.labelCurrentUserControl.Name = "labelCurrentUserControl";
            this.labelCurrentUserControl.Palette = this.kryptonPaletteGeneral;
            this.labelCurrentUserControl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.labelCurrentUserControl.Size = new System.Drawing.Size(1110, 100);
            this.labelCurrentUserControl.StateNormal.Padding = new System.Windows.Forms.Padding(30, -1, -1, -1);
            this.labelCurrentUserControl.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.labelCurrentUserControl.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.labelCurrentUserControl.TabIndex = 0;
            this.labelCurrentUserControl.Values.Text = "Dashboard";
            // 
            // userControlDashboard
            // 
            this.userControlDashboard.BackColor = System.Drawing.Color.White;
            this.userControlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashboard.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userControlDashboard.Name = "userControlDashboard";
            this.userControlDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.userControlDashboard.Size = new System.Drawing.Size(1110, 788);
            this.userControlDashboard.TabIndex = 2;
            // 
            // userControlStudents
            // 
            this.userControlStudents.BackColor = System.Drawing.Color.White;
            this.userControlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStudents.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlStudents.Location = new System.Drawing.Point(0, 0);
            this.userControlStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userControlStudents.Name = "userControlStudents";
            this.userControlStudents.Size = new System.Drawing.Size(1110, 788);
            this.userControlStudents.TabIndex = 1;
            // 
            // userControlStudentAttendance
            // 
            this.userControlStudentAttendance.BackColor = System.Drawing.Color.White;
            this.userControlStudentAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStudentAttendance.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlStudentAttendance.Location = new System.Drawing.Point(0, 0);
            this.userControlStudentAttendance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userControlStudentAttendance.Name = "userControlStudentAttendance";
            this.userControlStudentAttendance.Size = new System.Drawing.Size(1110, 788);
            this.userControlStudentAttendance.TabIndex = 4;
            // 
            // userControlStudentGrades
            // 
            this.userControlStudentGrades.BackColor = System.Drawing.Color.White;
            this.userControlStudentGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStudentGrades.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlStudentGrades.Location = new System.Drawing.Point(0, 0);
            this.userControlStudentGrades.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userControlStudentGrades.Name = "userControlStudentGrades";
            this.userControlStudentGrades.Size = new System.Drawing.Size(1110, 788);
            this.userControlStudentGrades.TabIndex = 3;
            // 
            // userControlCourses
            // 
            this.userControlCourses.BackColor = System.Drawing.Color.White;
            this.userControlCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCourses.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlCourses.Location = new System.Drawing.Point(0, 0);
            this.userControlCourses.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userControlCourses.Name = "userControlCourses";
            this.userControlCourses.Size = new System.Drawing.Size(1110, 788);
            this.userControlCourses.TabIndex = 0;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 894);
            this.Controls.Add(this.panelCurrentUserControl);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Center Management Application";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCurrentUser)).EndInit();
            this.panelCurrentUser.ResumeLayout(false);
            this.panelCurrentUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentUser)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelCurrentUserControl.ResumeLayout(false);
            this.panelCurrentUserControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelCurrentUser;
        private System.Windows.Forms.PictureBox pictureBoxCurrentUser;
        private System.Windows.Forms.Label labelCurrentUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonDashboard;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteGeneral;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonStudent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonClass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonCourse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonUser;
        private System.Windows.Forms.Panel panelMain;
        private GUI.UserControlCourses userControlCourses;
        private System.Windows.Forms.Panel panelCurrentUserControl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelCurrentUserControl;
        private GUI.UserControlStudents userControlStudents;
        private GUI.UserControlDashboard userControlDashboard;
        private GUI.UserControlStudentGrades userControlStudentGrades;
        private GUI.UserControlStudentAttendance userControlStudentAttendance;
    }
}