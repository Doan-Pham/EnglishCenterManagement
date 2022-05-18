
namespace EnglishCenterManagemenent.GUI
{
    partial class UserControlCourses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPaletteGeneral = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.buttonAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearchIcon = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.buttonGradeSchemes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(35, 37);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Palette = this.kryptonPaletteGeneral;
            this.textBoxSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.textBoxSearch.Size = new System.Drawing.Size(477, 67);
            this.textBoxSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxSearch.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.textBoxSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSearch.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Nhập tên, lớp";
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
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 1;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(25)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Width = 1;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(184)))), ((int)(((byte)(124)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(184)))), ((int)(((byte)(124)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Width = 1;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.OverrideFocus.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(139)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(139)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Border.Rounding = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Border.Width = 1;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Content.AdjacentGap = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lexend", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(184)))), ((int)(((byte)(124)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(184)))), ((int)(((byte)(124)))));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Border.Rounding = 10;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonCustom2.StateTracking.Border.Width = 1;
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
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideDefault.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.kryptonPaletteGeneral.ButtonStyles.ButtonStandalone.OverrideFocus.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
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
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Border.Width = 2;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.HeaderColumn.Border.Width = 0;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(168)))), ((int)(((byte)(47)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(168)))), ((int)(((byte)(47)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateSelected.DataCell.Border.Width = 0;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(115)))), ((int)(((byte)(53)))));
            this.kryptonPaletteGeneral.GridStyles.GridCustom1.StateTracking.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
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
            // buttonAdd
            // 
            this.buttonAdd.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(583, 37);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(139)))));
            this.buttonAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(199)))), ((int)(((byte)(139)))));
            this.buttonAdd.Palette = this.kryptonPaletteGeneral;
            this.buttonAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonAdd.Size = new System.Drawing.Size(137, 67);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_plus_24px_white;
            this.buttonAdd.Values.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Location = new System.Drawing.Point(918, 37);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.buttonUpdate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.buttonUpdate.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            this.buttonUpdate.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(152)))), ((int)(((byte)(228)))));
            this.buttonUpdate.Palette = this.kryptonPaletteGeneral;
            this.buttonUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonUpdate.Size = new System.Drawing.Size(149, 67);
            this.buttonUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.buttonUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(231)))));
            this.buttonUpdate.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.buttonUpdate.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.buttonUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonUpdate.StateTracking.Border.Rounding = 10;
            this.buttonUpdate.StateTracking.Border.Width = 1;
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_update_24px_white;
            this.buttonUpdate.Values.Text = "Update";
            // 
            // buttonDelete
            // 
            this.buttonDelete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(750, 37);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonDelete.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(67)))), ((int)(((byte)(62)))));
            this.buttonDelete.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(67)))), ((int)(((byte)(62)))));
            this.buttonDelete.Palette = this.kryptonPaletteGeneral;
            this.buttonDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonDelete.Size = new System.Drawing.Size(137, 67);
            this.buttonDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_trashcan_24px_white;
            this.buttonDelete.Values.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeight = 60;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Custom1;
            this.dataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.dataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridView.HideOuterBorders = true;
            this.dataGridView.Location = new System.Drawing.Point(35, 225);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Palette = this.kryptonPaletteGeneral;
            this.dataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 100;
            this.dataGridView.RowTemplate.Height = 60;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1032, 511);
            this.dataGridView.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dataGridView.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dataGridView.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dataGridView.StateNormal.HeaderColumn.Border.Width = 2;
            this.dataGridView.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.dataGridView.StateNormal.HeaderColumn.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.dataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number of Lessons";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 265;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Number of Weeks";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 252;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tuition";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Standard Grade";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 234;
            // 
            // panelSearchIcon
            // 
            this.panelSearchIcon.Location = new System.Drawing.Point(48, 47);
            this.panelSearchIcon.Name = "panelSearchIcon";
            this.panelSearchIcon.Size = new System.Drawing.Size(48, 48);
            this.panelSearchIcon.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSearchIcon.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelSearchIcon.StateNormal.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_search_32px_gray;
            this.panelSearchIcon.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.panelSearchIcon.TabIndex = 6;
            // 
            // buttonGradeSchemes
            // 
            this.buttonGradeSchemes.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.buttonGradeSchemes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGradeSchemes.Location = new System.Drawing.Point(666, 132);
            this.buttonGradeSchemes.Name = "buttonGradeSchemes";
            this.buttonGradeSchemes.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonGradeSchemes.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonGradeSchemes.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(67)))), ((int)(((byte)(62)))));
            this.buttonGradeSchemes.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(67)))), ((int)(((byte)(62)))));
            this.buttonGradeSchemes.Palette = this.kryptonPaletteGeneral;
            this.buttonGradeSchemes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonGradeSchemes.Size = new System.Drawing.Size(304, 67);
            this.buttonGradeSchemes.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.buttonGradeSchemes.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(90)))), ((int)(((byte)(86)))));
            this.buttonGradeSchemes.TabIndex = 7;
            this.buttonGradeSchemes.Values.Image = global::EnglishCenterManagemenent.Properties.Resources.ic_student_24px_white;
            this.buttonGradeSchemes.Values.Text = "View grade scheme";
            this.buttonGradeSchemes.Click += new System.EventHandler(this.buttonGradeSchemes_Click);
            // 
            // UserControlCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonGradeSchemes);
            this.Controls.Add(this.panelSearchIcon);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSearch);
            this.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UserControlCourses";
            this.Size = new System.Drawing.Size(1110, 788);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteGeneral;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelSearchIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonGradeSchemes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
