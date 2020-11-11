namespace MENU
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panelformulario = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.labelletraslogo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnres = new System.Windows.Forms.PictureBox();
            this.btnhome = new FontAwesome.Sharp.IconPictureBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btnmax = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panelgrup = new System.Windows.Forms.Panel();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btndoc = new FontAwesome.Sharp.IconButton();
            this.btndocente = new FontAwesome.Sharp.IconButton();
            this.btnmaterial = new FontAwesome.Sharp.IconButton();
            this.btnsala = new FontAwesome.Sharp.IconButton();
            this.btnadmin = new FontAwesome.Sharp.IconButton();
            this.btntutor = new FontAwesome.Sharp.IconButton();
            this.btnalumno = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelbienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timermenu = new System.Windows.Forms.Timer(this.components);
            this.panelcontenedor.SuspendLayout();
            this.panelformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelgrup.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelcontenedor.Controls.Add(this.panelformulario);
            this.panelcontenedor.Controls.Add(this.paneltitulo);
            this.panelcontenedor.Controls.Add(this.panelgrup);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 0);
            this.panelcontenedor.MaximumSize = new System.Drawing.Size(1200, 720);
            this.panelcontenedor.MinimumSize = new System.Drawing.Size(1080, 620);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1200, 720);
            this.panelcontenedor.TabIndex = 0;
            // 
            // panelformulario
            // 
            this.panelformulario.BackColor = System.Drawing.Color.White;
            this.panelformulario.Controls.Add(this.lblfecha);
            this.panelformulario.Controls.Add(this.lblhora);
            this.panelformulario.Controls.Add(this.labelletraslogo);
            this.panelformulario.Controls.Add(this.pictureBox2);
            this.panelformulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformulario.Location = new System.Drawing.Point(220, 50);
            this.panelformulario.Name = "panelformulario";
            this.panelformulario.Size = new System.Drawing.Size(980, 670);
            this.panelformulario.TabIndex = 2;
            this.panelformulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformulario_Paint);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(342, 610);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(90, 32);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "fecha";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(169, 610);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(75, 32);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "hora";
            // 
            // labelletraslogo
            // 
            this.labelletraslogo.AutoSize = true;
            this.labelletraslogo.BackColor = System.Drawing.Color.Transparent;
            this.labelletraslogo.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelletraslogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.labelletraslogo.Location = new System.Drawing.Point(191, 21);
            this.labelletraslogo.Name = "labelletraslogo";
            this.labelletraslogo.Size = new System.Drawing.Size(617, 109);
            this.labelletraslogo.TabIndex = 1;
            this.labelletraslogo.Text = "S . C . E . I . P";
            this.labelletraslogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(980, 436);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.paneltitulo.Controls.Add(this.btnres);
            this.paneltitulo.Controls.Add(this.btnhome);
            this.paneltitulo.Controls.Add(this.labeltitle);
            this.paneltitulo.Controls.Add(this.btnmin);
            this.paneltitulo.Controls.Add(this.btnmax);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(220, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(980, 50);
            this.paneltitulo.TabIndex = 1;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // btnres
            // 
            this.btnres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnres.Image = ((System.Drawing.Image)(resources.GetObject("btnres.Image")));
            this.btnres.Location = new System.Drawing.Point(917, 15);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(20, 20);
            this.btnres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnres.TabIndex = 5;
            this.btnres.TabStop = false;
            this.btnres.Visible = false;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnhome.IconColor = System.Drawing.Color.White;
            this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhome.IconSize = 50;
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(68, 50);
            this.btnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhome.TabIndex = 4;
            this.btnhome.TabStop = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.Color.Transparent;
            this.labeltitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(134, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(703, 36);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "Sistema de Control de la Estancia Infantil Pumitas";
            this.labeltitle.Click += new System.EventHandler(this.labeltitle_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(891, 15);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(20, 20);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 2;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.Location = new System.Drawing.Point(917, 15);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(20, 20);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmax.TabIndex = 1;
            this.btnmax.TabStop = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(943, 15);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelgrup
            // 
            this.panelgrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panelgrup.Controls.Add(this.btnsalir);
            this.panelgrup.Controls.Add(this.btndoc);
            this.panelgrup.Controls.Add(this.btndocente);
            this.panelgrup.Controls.Add(this.btnmaterial);
            this.panelgrup.Controls.Add(this.btnsala);
            this.panelgrup.Controls.Add(this.btnadmin);
            this.panelgrup.Controls.Add(this.btntutor);
            this.panelgrup.Controls.Add(this.btnalumno);
            this.panelgrup.Controls.Add(this.panelLogo);
            this.panelgrup.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelgrup.Location = new System.Drawing.Point(0, 0);
            this.panelgrup.Name = "panelgrup";
            this.panelgrup.Size = new System.Drawing.Size(220, 720);
            this.panelgrup.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 50;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(0, 660);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(220, 60);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "CERRAR SESIÓN";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btndoc
            // 
            this.btndoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndoc.FlatAppearance.BorderSize = 0;
            this.btndoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoc.ForeColor = System.Drawing.Color.White;
            this.btndoc.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btndoc.IconColor = System.Drawing.Color.White;
            this.btndoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndoc.IconSize = 50;
            this.btndoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndoc.Location = new System.Drawing.Point(0, 500);
            this.btndoc.Name = "btndoc";
            this.btndoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btndoc.Size = new System.Drawing.Size(220, 60);
            this.btndoc.TabIndex = 7;
            this.btndoc.Text = "DOCUMENTOS";
            this.btndoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndoc.UseVisualStyleBackColor = true;
            this.btndoc.Click += new System.EventHandler(this.btndoc_Click);
            // 
            // btndocente
            // 
            this.btndocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndocente.FlatAppearance.BorderSize = 0;
            this.btndocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndocente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocente.ForeColor = System.Drawing.Color.White;
            this.btndocente.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btndocente.IconColor = System.Drawing.Color.White;
            this.btndocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndocente.IconSize = 50;
            this.btndocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndocente.Location = new System.Drawing.Point(0, 440);
            this.btndocente.Name = "btndocente";
            this.btndocente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btndocente.Size = new System.Drawing.Size(220, 60);
            this.btndocente.TabIndex = 6;
            this.btndocente.Text = "DOCENTES";
            this.btndocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndocente.UseVisualStyleBackColor = true;
            this.btndocente.Click += new System.EventHandler(this.btndocente_Click);
            // 
            // btnmaterial
            // 
            this.btnmaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmaterial.FlatAppearance.BorderSize = 0;
            this.btnmaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaterial.ForeColor = System.Drawing.Color.White;
            this.btnmaterial.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnmaterial.IconColor = System.Drawing.Color.White;
            this.btnmaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmaterial.IconSize = 50;
            this.btnmaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmaterial.Location = new System.Drawing.Point(0, 380);
            this.btnmaterial.Name = "btnmaterial";
            this.btnmaterial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnmaterial.Size = new System.Drawing.Size(220, 60);
            this.btnmaterial.TabIndex = 5;
            this.btnmaterial.Text = "MATERIALES";
            this.btnmaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmaterial.UseVisualStyleBackColor = true;
            this.btnmaterial.Click += new System.EventHandler(this.btnmaterial_Click);
            // 
            // btnsala
            // 
            this.btnsala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsala.FlatAppearance.BorderSize = 0;
            this.btnsala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsala.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsala.ForeColor = System.Drawing.Color.White;
            this.btnsala.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnsala.IconColor = System.Drawing.Color.White;
            this.btnsala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsala.IconSize = 50;
            this.btnsala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsala.Location = new System.Drawing.Point(0, 320);
            this.btnsala.Name = "btnsala";
            this.btnsala.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnsala.Size = new System.Drawing.Size(220, 60);
            this.btnsala.TabIndex = 4;
            this.btnsala.Text = "SALAS";
            this.btnsala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsala.UseVisualStyleBackColor = true;
            this.btnsala.Click += new System.EventHandler(this.btnsala_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadmin.FlatAppearance.BorderSize = 0;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.Color.White;
            this.btnadmin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnadmin.IconColor = System.Drawing.Color.White;
            this.btnadmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnadmin.IconSize = 50;
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Location = new System.Drawing.Point(0, 260);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnadmin.Size = new System.Drawing.Size(220, 60);
            this.btnadmin.TabIndex = 3;
            this.btnadmin.Text = "ADMINISTRADOR";
            this.btnadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btntutor
            // 
            this.btntutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntutor.FlatAppearance.BorderSize = 0;
            this.btntutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntutor.ForeColor = System.Drawing.Color.White;
            this.btntutor.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btntutor.IconColor = System.Drawing.Color.White;
            this.btntutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntutor.IconSize = 50;
            this.btntutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntutor.Location = new System.Drawing.Point(0, 200);
            this.btntutor.Name = "btntutor";
            this.btntutor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btntutor.Size = new System.Drawing.Size(220, 60);
            this.btntutor.TabIndex = 2;
            this.btntutor.Text = "TUTORES";
            this.btntutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntutor.UseVisualStyleBackColor = true;
            this.btntutor.Click += new System.EventHandler(this.btntutor_Click);
            // 
            // btnalumno
            // 
            this.btnalumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnalumno.FlatAppearance.BorderSize = 0;
            this.btnalumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalumno.ForeColor = System.Drawing.Color.White;
            this.btnalumno.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.btnalumno.IconColor = System.Drawing.Color.White;
            this.btnalumno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnalumno.IconSize = 50;
            this.btnalumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalumno.Location = new System.Drawing.Point(0, 140);
            this.btnalumno.Name = "btnalumno";
            this.btnalumno.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnalumno.Size = new System.Drawing.Size(220, 60);
            this.btnalumno.TabIndex = 1;
            this.btnalumno.Text = "ALUMNOS";
            this.btnalumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnalumno.UseVisualStyleBackColor = true;
            this.btnalumno.Click += new System.EventHandler(this.btnalumno_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panelLogo.Controls.Add(this.labelusuario);
            this.panelLogo.Controls.Add(this.labelbienvenida);
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.ForeColor = System.Drawing.Color.White;
            this.labelusuario.Location = new System.Drawing.Point(78, 114);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(53, 20);
            this.labelusuario.TabIndex = 2;
            this.labelusuario.Text = "label2";
            // 
            // labelbienvenida
            // 
            this.labelbienvenida.AutoSize = true;
            this.labelbienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbienvenida.ForeColor = System.Drawing.Color.White;
            this.labelbienvenida.Location = new System.Drawing.Point(69, 91);
            this.labelbienvenida.Name = "labelbienvenida";
            this.labelbienvenida.Size = new System.Drawing.Size(78, 15);
            this.labelbienvenida.TabIndex = 1;
            this.labelbienvenida.Text = "Bienvenido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 76);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timermenu
            // 
            this.timermenu.Tick += new System.EventHandler(this.timermenu_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelcontenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 725);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelcontenedor.ResumeLayout(false);
            this.panelformulario.ResumeLayout(false);
            this.panelformulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelgrup.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Panel panelformulario;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Panel panelgrup;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btndoc;
        private FontAwesome.Sharp.IconButton btndocente;
        private FontAwesome.Sharp.IconButton btnmaterial;
        private FontAwesome.Sharp.IconButton btnsala;
        private FontAwesome.Sharp.IconButton btnadmin;
        private FontAwesome.Sharp.IconButton btntutor;
        private FontAwesome.Sharp.IconButton btnalumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btnmax;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label labeltitle;
        private FontAwesome.Sharp.IconPictureBox btnhome;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelbienvenida;
        private System.Windows.Forms.PictureBox btnres;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label labelletraslogo;
        private System.Windows.Forms.Timer timermenu;
    }
}

