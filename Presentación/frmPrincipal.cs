using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Presentación.Informes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmPrincipal : Form
    {
		#region Propiedades
		
        System.Windows.Forms.ListView lstInstituciones = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstJugadores = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstArbitros = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstTorneos = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstCuotas = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstTipos = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstCategorias = new System.Windows.Forms.ListView();

        System.Windows.Forms.ListView lstJugAsociados = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstCuotasAPagar = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstCuotasPagadas = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstInstitucionesConDeudas = new System.Windows.Forms.ListView();
        System.Windows.Forms.ListView lstInscripciones = new System.Windows.Forms.ListView();

        private ListViewColumnSorter lvwColumnSorterInst, lvwColumnSorterJug, lvwColumnSorterArb, lvwColumnSorterTorn, lvwColumnSorterCuot, lvwColumnSorterTip, lvwColumnSorterCat;
        private ListViewColumnSorter lvwColumnSorterJugAs, lvwColumnSorterCuotAPag, lvwColumnSorterCuotPag, lvwColumnSorterInstDeu, lvwColumnSorterInsc;
		
		#endregion
		
        #region Constructores
		
        public frmPrincipal()
        {
            InitializeComponent();

            InicOrdCol();
        }

        #endregion

        #region Eventos de formulario

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
			InicializarListas();
        }

        private void ColumnClickGrillaPrincipal(object o, ColumnClickEventArgs e)
        {
            #region Instituciones

            if (ribMenu.SelectedPage.Name.Equals("tabInstituciones"))
            {
                if (e.Column == lvwColumnSorterInst.SortColumn)
                {
                    if (lvwColumnSorterInst.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterInst.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterInst.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterInst.SortColumn = e.Column;
                    lvwColumnSorterInst.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                this.lstInstituciones.Sort();
            }

            #endregion

            #region Jugadores

            else if (ribMenu.SelectedPage.Name.Equals("tabJugadores"))
            {
                if (e.Column == lvwColumnSorterJug.SortColumn)
                {
                    if (lvwColumnSorterJug.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterJug.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterJug.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterJug.SortColumn = e.Column;
                    lvwColumnSorterJug.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                if (e.Column == 11)
                {
                    lvwColumnSorterJug.Tipo = "Fecha";
                }
                else
                {
                    lvwColumnSorterJug.Tipo = "String";
                }

                this.lstJugadores.Sort();
            }

            #endregion

            #region Arbitros

            else if (ribMenu.SelectedPage.Name.Equals("tabArbitros"))
            {
                if (e.Column == lvwColumnSorterArb.SortColumn)
                {
                    if (lvwColumnSorterArb.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterArb.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterArb.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterArb.SortColumn = e.Column;
                    lvwColumnSorterArb.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                if (e.Column == 10)
                {
                    lvwColumnSorterJug.Tipo = "Fecha";
                }
                else
                {
                    lvwColumnSorterJug.Tipo = "String";
                }

                this.lstArbitros.Sort();
            }

            #endregion

            #region Cuotas

            else if (ribMenu.SelectedPage.Name.Equals("tabCuotas"))
            {
                if (e.Column == lvwColumnSorterCuot.SortColumn)
                {
                    if (lvwColumnSorterCuot.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterCuot.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterCuot.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterCuot.SortColumn = e.Column;
                    lvwColumnSorterCuot.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                if (e.Column == 0)
                {
                    lvwColumnSorterJug.Tipo = "Fecha";
                }
                else
                {
                    lvwColumnSorterJug.Tipo = "String";
                }

                this.lstCuotas.Sort();
            }

            #endregion

            #region Torneos

            else if (ribMenu.SelectedPage.Name.Equals("tabTorneos"))
            {
                if (e.Column == lvwColumnSorterCuot.SortColumn)
                {
                    if (lvwColumnSorterTorn.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterTorn.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterTorn.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterTorn.SortColumn = e.Column;
                    lvwColumnSorterTorn.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                if (e.Column == 4)
                {
                    lvwColumnSorterJug.Tipo = "Fecha";
                }
                else
                {
                    lvwColumnSorterJug.Tipo = "String";
                }

                this.lstTorneos.Sort();
            }

            #endregion

            #region Categoria

            else if (ribMenu.SelectedPage.Name.Equals("tabCategorías"))
            {
                if (e.Column == lvwColumnSorterCat.SortColumn)
                {
                    if (lvwColumnSorterCat.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterCat.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterCat.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterCat.SortColumn = e.Column;
                    lvwColumnSorterCat.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                this.lstCategorias.Sort();
            }

            #endregion

            #region Tipo

            else if (ribMenu.SelectedPage.Name.Equals("tabTipos"))
            {
                if (e.Column == lvwColumnSorterTip.SortColumn)
                {
                    if (lvwColumnSorterTip.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterTip.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterTip.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterTip.SortColumn = e.Column;
                    lvwColumnSorterTip.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                this.lstTipos.Sort();
            }

            #endregion
        }

        private void ColumnClickGrillaSecundaria(object o, ColumnClickEventArgs e)
        {
            #region Instituciones

            if (ribMenu.SelectedPage.Name.Equals("tabInstituciones"))
            {
                if (chkCuotasAPagar.Checked)
                {
                    if (e.Column == lvwColumnSorterCuotAPag.SortColumn)
                    {
                        if (lvwColumnSorterCuotAPag.Order == System.Windows.Forms.SortOrder.Ascending)
                        {
                            lvwColumnSorterCuotAPag.Order = System.Windows.Forms.SortOrder.Descending;
                        }
                        else
                        {
                            lvwColumnSorterCuotAPag.Order = System.Windows.Forms.SortOrder.Ascending;
                        }
                    }
                    else
                    {
                        lvwColumnSorterCuotAPag.SortColumn = e.Column;
                        lvwColumnSorterCuotAPag.Order = System.Windows.Forms.SortOrder.Ascending;
                    }

                    if (e.Column == 0)
                    {
                        lvwColumnSorterJug.Tipo = "Fecha";
                    }
                    else
                    {
                        lvwColumnSorterJug.Tipo = "String";
                    }

                    this.lstCuotasAPagar.Sort();
                }
                else if (chkCuotasPagadas.Checked)
                {
                    if (e.Column == lvwColumnSorterCuotPag.SortColumn)
                    {
                        if (lvwColumnSorterCuotPag.Order == System.Windows.Forms.SortOrder.Ascending)
                        {
                            lvwColumnSorterCuotPag.Order = System.Windows.Forms.SortOrder.Descending;
                        }
                        else
                        {
                            lvwColumnSorterCuotPag.Order = System.Windows.Forms.SortOrder.Ascending;
                        }
                    }
                    else
                    {
                        lvwColumnSorterCuotPag.SortColumn = e.Column;
                        lvwColumnSorterCuotPag.Order = System.Windows.Forms.SortOrder.Ascending;
                    }

                    if (e.Column == 0 || e.Column == 1)
                    {
                        lvwColumnSorterJug.Tipo = "Fecha";
                    }
                    else
                    {
                        lvwColumnSorterJug.Tipo = "String";
                    }

                    this.lstCuotasPagadas.Sort();
                }
                else if (!chkCuotasAPagar.Checked && !chkCuotasPagadas.Checked)
                {
                    if (e.Column == lvwColumnSorterJugAs.SortColumn)
                    {
                        if (lvwColumnSorterJugAs.Order == System.Windows.Forms.SortOrder.Ascending)
                        {
                            lvwColumnSorterJugAs.Order = System.Windows.Forms.SortOrder.Descending;
                        }
                        else
                        {
                            lvwColumnSorterJugAs.Order = System.Windows.Forms.SortOrder.Ascending;
                        }
                    }
                    else
                    {
                        lvwColumnSorterJugAs.SortColumn = e.Column;
                        lvwColumnSorterJugAs.Order = System.Windows.Forms.SortOrder.Ascending;
                    }

                    if (e.Column == 10)
                    {
                        lvwColumnSorterJug.Tipo = "Fecha";
                    }
                    else
                    {
                        lvwColumnSorterJug.Tipo = "String";
                    }

                    this.lstJugAsociados.Sort();
                }
            }

            #endregion

            #region Cuotas

            else if (ribMenu.SelectedPage.Name.Equals("tabCuotas"))
            {
                if (e.Column == lvwColumnSorterInstDeu.SortColumn)
                {
                    if (lvwColumnSorterInstDeu.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterInstDeu.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterInstDeu.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterInstDeu.SortColumn = e.Column;
                    lvwColumnSorterInstDeu.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                if (e.Column == 1)
                {
                    lvwColumnSorterJug.Tipo = "Fecha";
                }
                else
                {
                    lvwColumnSorterJug.Tipo = "String";
                }

                this.lstInstitucionesConDeudas.Sort();
            }

            #endregion

            #region Torneos

            else if (ribMenu.SelectedPage.Name.Equals("tabTorneos"))
            {
                if (e.Column == lvwColumnSorterInsc.SortColumn)
                {
                    if (lvwColumnSorterInsc.Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        lvwColumnSorterInsc.Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorterInsc.Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    lvwColumnSorterInsc.SortColumn = e.Column;
                    lvwColumnSorterInsc.Order = System.Windows.Forms.SortOrder.Ascending;
                }

                this.lstInscripciones.Sort();
            }

            #endregion
        }

        #endregion

        #region Métodos de formulario
		
        public void InicOrdCol()
        {
            lvwColumnSorterInst = new ListViewColumnSorter();
            lvwColumnSorterJug = new ListViewColumnSorter();
            lvwColumnSorterArb = new ListViewColumnSorter();
            lvwColumnSorterTorn = new ListViewColumnSorter();
            lvwColumnSorterCuot = new ListViewColumnSorter();
            lvwColumnSorterTip = new ListViewColumnSorter();
            lvwColumnSorterCat = new ListViewColumnSorter();

            lvwColumnSorterJugAs = new ListViewColumnSorter();
            lvwColumnSorterCuotAPag = new ListViewColumnSorter();
            lvwColumnSorterCuotPag = new ListViewColumnSorter();
            lvwColumnSorterInstDeu = new ListViewColumnSorter();
            lvwColumnSorterInsc = new ListViewColumnSorter();

            this.lstInstituciones.ListViewItemSorter = lvwColumnSorterInst;
            this.lstJugadores.ListViewItemSorter = lvwColumnSorterJug;
            this.lstArbitros.ListViewItemSorter = lvwColumnSorterArb;
            this.lstCuotas.ListViewItemSorter = lvwColumnSorterCuot;
            this.lstTorneos.ListViewItemSorter = lvwColumnSorterTorn;
            this.lstCategorias.ListViewItemSorter = lvwColumnSorterCat;
            this.lstTipos.ListViewItemSorter = lvwColumnSorterTip;

            this.lstJugAsociados.ListViewItemSorter = lvwColumnSorterJugAs;
            this.lstCuotasAPagar.ListViewItemSorter = lvwColumnSorterCuotAPag;
            this.lstCuotasPagadas.ListViewItemSorter = lvwColumnSorterCuotPag;
            this.lstInstitucionesConDeudas.ListViewItemSorter = lvwColumnSorterInstDeu;
            this.lstInscripciones.ListViewItemSorter = lvwColumnSorterInsc;
        }

        public void InicializarListas()
        {
            this.sctPaneles.Panel1.Controls.Add(this.lstInstituciones);
            this.sctPaneles.Panel1.Controls.Add(this.lstJugadores);
            this.sctPaneles.Panel1.Controls.Add(this.lstArbitros);
            this.sctPaneles.Panel1.Controls.Add(this.lstCuotas);
            this.sctPaneles.Panel1.Controls.Add(this.lstTorneos);
            this.sctPaneles.Panel1.Controls.Add(this.lstTipos);
            this.sctPaneles.Panel1.Controls.Add(this.lstCategorias);

            this.sctPaneles.Panel2.Controls.Add(this.lstJugAsociados);
            this.sctPaneles.Panel2.Controls.Add(this.lstCuotasAPagar);
            this.sctPaneles.Panel2.Controls.Add(this.lstCuotasPagadas);
            this.sctPaneles.Panel2.Controls.Add(this.lstInstitucionesConDeudas);
            this.sctPaneles.Panel2.Controls.Add(this.lstInscripciones);

            #region Lista instituciones

            lstInstituciones.Dock = System.Windows.Forms.DockStyle.Fill;
            lstInstituciones.FullRowSelect = true;
            lstInstituciones.GridLines = true;
            lstInstituciones.Location = new System.Drawing.Point(0, 0);
            lstInstituciones.MultiSelect = false;
            lstInstituciones.Name = "lstInstituciones";
            lstInstituciones.ShowItemToolTips = true;
            lstInstituciones.Size = new System.Drawing.Size(1008, 612);
            lstInstituciones.TabIndex = 1;
            lstInstituciones.UseCompatibleStateImageBehavior = false;
            lstInstituciones.View = System.Windows.Forms.View.Details;
            lstInstituciones.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstInstituciones.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstInstituciones.Visible = true;

            System.Windows.Forms.ColumnHeader colIdInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colCuitInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colRazonSocialInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDireccionInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNombreContactoInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelefonoInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelCelularInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colEmailInst = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colLocalidadInst = new System.Windows.Forms.ColumnHeader();

            lstInstituciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colIdInst, colCuitInst, colRazonSocialInst, colDireccionInst, colLocalidadInst, colTelefonoInst, colTelCelularInst, colEmailInst, colNombreContactoInst
            });

            colIdInst.Text = "Nro";
            colCuitInst.Text = "CUIT";
            colRazonSocialInst.Text = "Razón social";
            colDireccionInst.Text = "Dirección";
            colLocalidadInst.Text = "Localidad";
            colNombreContactoInst.Text = "Nombre del contacto";
            colTelefonoInst.Text = "Teléfono";
            colTelCelularInst.Text = "Teléfono celular";
            colEmailInst.Text = "Email";

            colIdInst.Width = 50;
            colCuitInst.Width = 100;
            colRazonSocialInst.Width = 250;
            colDireccionInst.Width = 150;
            colLocalidadInst.Width = 100;
            colNombreContactoInst.Width = 120;
            colTelefonoInst.Width = 90;
            colTelCelularInst.Width = 100;
            colEmailInst.Width = 150;

            // Obtener instituciones desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Instituciones oInstituciones;
            SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios las instituciones existentes
                oInstituciones = oInstitucionesNegocio.GetAll();

                CargarGrilla(oInstituciones);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oInstituciones = null;
                oInstitucionesNegocio = null;
            }

            #endregion

            #region Lista jugadores

            lstJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            lstJugadores.FullRowSelect = true;
            lstJugadores.GridLines = true;
            lstJugadores.Location = new System.Drawing.Point(0, 0);
            lstJugadores.MultiSelect = false;
            lstJugadores.Name = "lstJugadores";
            lstJugadores.ShowItemToolTips = true;
            lstJugadores.Size = new System.Drawing.Size(1008, 612);
            lstJugadores.TabIndex = 1;
            lstJugadores.UseCompatibleStateImageBehavior = false;
            lstJugadores.View = System.Windows.Forms.View.Details;
            lstJugadores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstJugadores.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstJugadores.Visible = false;

            System.Windows.Forms.ColumnHeader colIdJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNroDocJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTipoDocJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colApellidoJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNombreJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colSexoJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDirecciónJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colLocalidadJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelefonoJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelCelularJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colEmailJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colFechaNacimientoJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colInstitucionJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colEloLocalJug = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colIdFideJug = new System.Windows.Forms.ColumnHeader();

            lstJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colIdJug, colNroDocJug, colTipoDocJug, colApellidoJug, colNombreJug, colSexoJug, colDirecciónJug, colLocalidadJug,colTelefonoJug, colTelCelularJug, colEmailJug, colFechaNacimientoJug, colInstitucionJug, colEloLocalJug, colIdFideJug
            });

            colIdJug.Text = "Nro";
            colTipoDocJug.Text = "Tipo documento";
            colNroDocJug.Text = "Nº documento";
            colNombreJug.Text = "Nombre";
            colApellidoJug.Text = "Apellido";
            colSexoJug.Text = "Sexo";
            colDirecciónJug.Text = "Dirección";
            colLocalidadJug.Text = "Localidad";
            colTelefonoJug.Text = "Teléfono";
            colTelCelularJug.Text = "Tel. celular";
            colEmailJug.Text = "Email";
            colFechaNacimientoJug.Text = "Fecha de nacimiento";
            colInstitucionJug.Text = "Institución";
            colEloLocalJug.Text = "Elo local";
            colIdFideJug.Text = "ID FIDE";

            colIdJug.Width = 50;
            colTipoDocJug.Width = -2;
            colNroDocJug.Width = -2;
            colNombreJug.Width = 80;
            colApellidoJug.Width = 80;
            colSexoJug.Width = 50;
            colDirecciónJug.Width = 150;
            colLocalidadJug.Width = 150;
            colTelefonoJug.Width = 90;
            colTelCelularJug.Width = 100;
            colEmailJug.Width = 150;
            colFechaNacimientoJug.Width = -2;
            colEloLocalJug.Width = -2;
            colIdFideJug.Width = -2;
            colInstitucionJug.Width = 250;

            // Obtener jugadores desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Jugadores oJugadores;
            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios los jugadores existentes
                oJugadores = oJugadoresNegocio.GetAll();

                CargarGrilla(oJugadores);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oJugadores = null;
                oJugadoresNegocio = null;
            }

            #endregion

            #region Lista arbitros

            lstArbitros.Dock = System.Windows.Forms.DockStyle.Fill;
            lstArbitros.FullRowSelect = true;
            lstArbitros.GridLines = true;
            lstArbitros.Location = new System.Drawing.Point(0, 0);
            lstArbitros.MultiSelect = false;
            lstArbitros.Name = "lstArbitros";
            lstArbitros.ShowItemToolTips = true;
            lstArbitros.Size = new System.Drawing.Size(1008, 612);
            lstArbitros.TabIndex = 1;
            lstArbitros.UseCompatibleStateImageBehavior = false;
            lstArbitros.View = System.Windows.Forms.View.Details;
            lstArbitros.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstArbitros.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstArbitros.Visible = false;

            System.Windows.Forms.ColumnHeader colIdArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNroDocArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTipoDocArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNombreArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colApellidoArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDirecciónArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colLocalidadArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelefonoArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelCelularArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colEmailArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colFechaNacimientoArb = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colCategoriaArb = new System.Windows.Forms.ColumnHeader();

            lstArbitros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colIdArb, colNroDocArb, colTipoDocArb, colApellidoArb, colNombreArb, colDirecciónArb, colLocalidadArb,colTelefonoArb, colTelCelularArb, colEmailArb, colFechaNacimientoArb, colCategoriaArb
			});

            colIdArb.Text = "Nro";
            colTipoDocArb.Text = "Tipo documento";
            colNroDocArb.Text = "Nº documento";
            colNombreArb.Text = "Nombre";
            colApellidoArb.Text = "Apellido";
            colDirecciónArb.Text = "Dirección";
            colLocalidadArb.Text = "Localidad";
            colTelefonoArb.Text = "Teléfono";
            colTelCelularArb.Text = "Teléfono celular";
            colEmailArb.Text = "Email";
            colFechaNacimientoArb.Text = "Fecha de nacimiento";
            colCategoriaArb.Text = "Categoria";

            colIdArb.Width = 50;
            colTipoDocArb.Width = -2;
            colNroDocArb.Width = -2;
            colNombreArb.Width = 100;
            colApellidoArb.Width = 100;
            colDirecciónArb.Width = 120;
            colLocalidadArb.Width = 120;
            colTelefonoArb.Width = 90;
            colTelCelularArb.Width = 100;
            colEmailArb.Width = 150;
            colFechaNacimientoArb.Width = -2;
            colCategoriaArb.Width = -2;

            // Obtener árbitros desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Arbitros oArbitros;
            SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios los árbitros existentes
                oArbitros = oArbitrosNegocio.GetAll();

                CargarGrilla(oArbitros);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oArbitros = null;
                oArbitrosNegocio = null;
            }

            #endregion

            #region Lista torneos

            lstTorneos.Dock = System.Windows.Forms.DockStyle.Fill;
            lstTorneos.FullRowSelect = true;
            lstTorneos.GridLines = true;
            lstTorneos.Location = new System.Drawing.Point(0, 0);
            lstTorneos.MultiSelect = false;
            lstTorneos.Name = "lstTorneos";
            lstTorneos.ShowItemToolTips = true;
            lstTorneos.Size = new System.Drawing.Size(1008, 612);
            lstTorneos.TabIndex = 1;
            lstTorneos.UseCompatibleStateImageBehavior = false;
            lstTorneos.View = System.Windows.Forms.View.Details;
            lstTorneos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstTorneos.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstTorneos.Visible = false;

            System.Windows.Forms.ColumnHeader colIdTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNombreTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colLugarTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDireccionTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colFechaHoraTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTipoTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colArbitroTorn = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader costoEstandarTorn = new System.Windows.Forms.ColumnHeader();

            lstTorneos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colIdTorn, colNombreTorn, colLugarTorn, colDireccionTorn, colFechaHoraTorn, colTipoTorn, colArbitroTorn, costoEstandarTorn
            });

            colIdTorn.Text = "Nro";
            colNombreTorn.Text = "Nombre";
            colLugarTorn.Text = "Lugar";
            colDireccionTorn.Text = "Direccion";
            colFechaHoraTorn.Text = "Fecha y hora";
            colTipoTorn.Text = "Tipo";
            colArbitroTorn.Text = "Árbitro";
            costoEstandarTorn.Text = "Costo base inscripción";

            colIdTorn.Width = 30;
            colNombreTorn.Width = 170;
            colLugarTorn.Width = 150;
            colDireccionTorn.Width = 180;
            colFechaHoraTorn.Width = 150;
            colTipoTorn.Width = 90;
            colArbitroTorn.Width = 130;
            costoEstandarTorn.Width = 130;

            // Obtener árbitros desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Torneos oTorneos;
            SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios los árbitros existentes
                oTorneos = oTorneosNegocio.GetAll();

                CargarGrilla(oTorneos);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oTorneos = null;
                oTorneosNegocio = null;
            }

            #endregion

            #region Lista cuotas

            lstCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            lstCuotas.FullRowSelect = true;
            lstCuotas.GridLines = true;
            lstCuotas.Location = new System.Drawing.Point(0, 0);
            lstCuotas.MultiSelect = false;
            lstCuotas.Name = "lstCuotas";
            lstCuotas.ShowItemToolTips = true;
            lstCuotas.Size = new System.Drawing.Size(1008, 612);
            lstCuotas.TabIndex = 1;
            lstCuotas.UseCompatibleStateImageBehavior = false;
            lstCuotas.View = System.Windows.Forms.View.Details;
            lstCuotas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstCuotas.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstCuotas.Visible = false;

            System.Windows.Forms.ColumnHeader colFechaCuota = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colImporteCuota = new System.Windows.Forms.ColumnHeader();

            lstCuotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colFechaCuota, colImporteCuota
            });

            colFechaCuota.Text = "Fecha";
            colImporteCuota.Text = "Importe";

            colFechaCuota.Width = 100;
            colImporteCuota.Width = 50;

            // Obtener cuotas desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Cuotas oCuotas;
            SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios las caregorías existentes
                oCuotas = oCuotasNegocio.GetCuotasAño(DateTime.Today.Year.ToString());

                CargarGrilla(oCuotas);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oCuotas = null;
                oCuotasNegocio = null;
            }

            #endregion

            #region Lista tipos

            lstTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            lstTipos.FullRowSelect = true;
            lstTipos.GridLines = true;
            lstTipos.Location = new System.Drawing.Point(0, 0);
            lstTipos.MultiSelect = false;
            lstTipos.Name = "lstTipos";
            lstTipos.ShowItemToolTips = true;
            lstTipos.Size = new System.Drawing.Size(1008, 612);
            lstTipos.TabIndex = 1;
            lstTipos.UseCompatibleStateImageBehavior = false;
            lstTipos.View = System.Windows.Forms.View.Details;
            lstTipos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstTipos.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstTipos.Visible = false;

            System.Windows.Forms.ColumnHeader colIdTipo = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDescripcionTipo = new System.Windows.Forms.ColumnHeader();

            lstTipos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colIdTipo, colDescripcionTipo
            });

            colIdTipo.Text = "Nro";
            colDescripcionTipo.Text = "Tipo";

            colIdTipo.Width = 50;
            colDescripcionTipo.Width = 150;

            // Obtener tipos desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Tipos oTipos;
            SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios los tipos existentes
                oTipos = oTiposNegocio.GetAll();

                CargarGrilla(oTipos);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oTipos = null;
                oTiposNegocio = null;
            }

            #endregion

            #region Lista categorias

            lstCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            lstCategorias.FullRowSelect = true;
            lstCategorias.GridLines = true;
            lstCategorias.Location = new System.Drawing.Point(0, 0);
            lstCategorias.MultiSelect = false;
            lstCategorias.Name = "lstCategorias";
            lstCategorias.ShowItemToolTips = true;
            lstCategorias.Size = new System.Drawing.Size(1008, 612);
            lstCategorias.TabIndex = 1;
            lstCategorias.UseCompatibleStateImageBehavior = false;
            lstCategorias.View = System.Windows.Forms.View.Details;
            lstCategorias.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPrincipal_ItemSelectionChanged);
            lstCategorias.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaPrincipal);
            lstCategorias.Visible = false;

            System.Windows.Forms.ColumnHeader colIdCat = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDescripcionCat = new System.Windows.Forms.ColumnHeader();

            lstCategorias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
			{
				colIdCat, colDescripcionCat
			});

            colIdCat.Text = "Nro";
            colDescripcionCat.Text = "Categoría";

            colIdCat.Width = 50;
            colDescripcionCat.Width = 150;

            // Obtener categorías desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Categorias oCategorias;
            SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                // Le pido a la capa de negocios las caregorías existentes
                oCategorias = oCategoriasNegocio.GetAll();

                CargarGrilla(oCategorias);
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oCategorias = null;
                oCategoriasNegocio = null;
            }

            #endregion

            #region Lista jugadores asociados

            this.lstJugAsociados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstJugAsociados.FullRowSelect = true;
            this.lstJugAsociados.GridLines = true;
            this.lstJugAsociados.Location = new System.Drawing.Point(0, 0);
            this.lstJugAsociados.MultiSelect = false;
            this.lstJugAsociados.Name = "lstJugAsociados";
            this.lstJugAsociados.ShowItemToolTips = true;
            this.lstJugAsociados.Size = new System.Drawing.Size(150, 46);
            this.lstJugAsociados.TabIndex = 0;
            this.lstJugAsociados.UseCompatibleStateImageBehavior = false;
            this.lstJugAsociados.View = System.Windows.Forms.View.Details;
            this.lstJugAsociados.SelectedIndexChanged += new System.EventHandler(this.lstSecundaria_SelectedIndexChanged);
            lstJugAsociados.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaSecundaria);

            //Agrego las columnas correspondientes
            System.Windows.Forms.ColumnHeader colIdJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNroDocJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTipoDocJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colNombreJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colApellidoJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colSexoJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colDirecciónJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelefonoJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colTelCelularJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colEmailJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colFechaNacimientoJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colEloLocalJugAsoc = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colIdFideJugAsoc = new System.Windows.Forms.ColumnHeader();

            this.lstJugAsociados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                    {
                        colIdJugAsoc, colNroDocJugAsoc, colTipoDocJugAsoc, colNombreJugAsoc, colApellidoJugAsoc, colSexoJugAsoc, colDirecciónJugAsoc, colTelefonoJugAsoc, colTelCelularJugAsoc, colEmailJugAsoc, colFechaNacimientoJugAsoc, colEloLocalJugAsoc, colIdFideJugAsoc
                    });

            colIdJugAsoc.Text = "Nro";
            colTipoDocJugAsoc.Text = "Tipo documento";
            colNroDocJugAsoc.Text = "Nº documento";
            colNombreJugAsoc.Text = "Nombre";
            colApellidoJugAsoc.Text = "Apellido";
            colSexoJugAsoc.Text = "Sexo";
            colDirecciónJugAsoc.Text = "Dirección";
            colTelefonoJugAsoc.Text = "Teléfono";
            colTelCelularJugAsoc.Text = "Tel. celular";
            colEmailJugAsoc.Text = "Email";
            colFechaNacimientoJugAsoc.Text = "Fecha de nacimiento";
            colEloLocalJugAsoc.Text = "Elo local";
            colIdFideJugAsoc.Text = "ID FIDE";

            colIdJugAsoc.Width = 50;
            colTipoDocJugAsoc.Width = -2;
            colNroDocJugAsoc.Width = -2;
            colNombreJugAsoc.Width = 80;
            colApellidoJugAsoc.Width = 80;
            colSexoJugAsoc.Width = 50;
            colDirecciónJugAsoc.Width = 150;
            colTelefonoJugAsoc.Width = 75;
            colTelCelularJugAsoc.Width = 75;
            colEmailJugAsoc.Width = 150;
            colFechaNacimientoJugAsoc.Width = -2;
            colEloLocalJugAsoc.Width = -2;
            colIdFideJugAsoc.Width = -2;

            #endregion

            #region Lista cuotas a pagar

            this.lstCuotasAPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuotasAPagar.FullRowSelect = true;
            this.lstCuotasAPagar.GridLines = true;
            this.lstCuotasAPagar.Location = new System.Drawing.Point(0, 0);
            this.lstCuotasAPagar.MultiSelect = false;
            this.lstCuotasAPagar.Name = "lstCuotasAPagar";
            this.lstCuotasAPagar.ShowItemToolTips = true;
            this.lstCuotasAPagar.Size = new System.Drawing.Size(150, 46);
            this.lstCuotasAPagar.TabIndex = 0;
            this.lstCuotasAPagar.UseCompatibleStateImageBehavior = false;
            this.lstCuotasAPagar.View = System.Windows.Forms.View.Details;
            this.lstCuotasAPagar.SelectedIndexChanged += new System.EventHandler(this.lstSecundaria_SelectedIndexChanged);
            lstCuotasAPagar.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaSecundaria);

            //Agrego las columnas correspondientes
            System.Windows.Forms.ColumnHeader colFechaCuotAPag = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colImporteCuotAPag = new System.Windows.Forms.ColumnHeader();

            this.lstCuotasAPagar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                    {
                        colFechaCuotAPag, colImporteCuotAPag
                    });

            colFechaCuotAPag.Text = "Fecha de la cuota";
            colImporteCuotAPag.Text = "Importe";

            colFechaCuotAPag.Width = 100;
            colImporteCuotAPag.Width = 50;

            #endregion

            #region Lista cuotas pagadas

            this.lstCuotasPagadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuotasPagadas.FullRowSelect = true;
            this.lstCuotasPagadas.GridLines = true;
            this.lstCuotasPagadas.Location = new System.Drawing.Point(0, 0);
            this.lstCuotasPagadas.MultiSelect = false;
            this.lstCuotasPagadas.Name = "lstCuotasPagadas";
            this.lstCuotasPagadas.ShowItemToolTips = true;
            this.lstCuotasPagadas.Size = new System.Drawing.Size(150, 46);
            this.lstCuotasPagadas.TabIndex = 0;
            this.lstCuotasPagadas.UseCompatibleStateImageBehavior = false;
            this.lstCuotasPagadas.View = System.Windows.Forms.View.Details;
            this.lstCuotasPagadas.SelectedIndexChanged += new System.EventHandler(this.lstSecundaria_SelectedIndexChanged);
            lstCuotasPagadas.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaSecundaria);

            //Agrego las columnas correspondientes
            System.Windows.Forms.ColumnHeader colFechaCuotPag = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colImporteCuotPag = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colFechaPagoCuotPag = new System.Windows.Forms.ColumnHeader();

            this.lstCuotasPagadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {
                    colFechaCuotPag, colFechaPagoCuotPag, colImporteCuotPag
                });

            colFechaCuotPag.Text = "Fecha de la cuota";
            colFechaPagoCuotPag.Text = "Fecha de pago";
            colImporteCuotPag.Text = "Importe";

            colFechaCuotPag.Width = 100;
            colFechaPagoCuotPag.Width = 100;
            colImporteCuotPag.Width = 50;

            #endregion

            #region Lista instituciones con deudas

            this.lstInstitucionesConDeudas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInstitucionesConDeudas.FullRowSelect = true;
            this.lstInstitucionesConDeudas.GridLines = true;
            this.lstInstitucionesConDeudas.Location = new System.Drawing.Point(0, 0);
            this.lstInstitucionesConDeudas.MultiSelect = false;
            this.lstInstitucionesConDeudas.Name = "lstInstitucionesConDeudas";
            this.lstInstitucionesConDeudas.ShowItemToolTips = true;
            this.lstInstitucionesConDeudas.Size = new System.Drawing.Size(150, 46);
            this.lstInstitucionesConDeudas.TabIndex = 0;
            this.lstInstitucionesConDeudas.UseCompatibleStateImageBehavior = false;
            this.lstInstitucionesConDeudas.View = System.Windows.Forms.View.Details;
            this.lstInstitucionesConDeudas.SelectedIndexChanged += new System.EventHandler(this.lstSecundaria_SelectedIndexChanged);
            lstInstitucionesConDeudas.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaSecundaria);

            //Agrego las columnas correspondientes
            System.Windows.Forms.ColumnHeader colInstitucionDeuda = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colCantCuotas = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colImporteDeuda = new System.Windows.Forms.ColumnHeader();

            this.lstInstitucionesConDeudas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                    {
                        colInstitucionDeuda, colCantCuotas, colImporteDeuda
                    });

            colInstitucionDeuda.Text = "Institución";
            colCantCuotas.Text = "Cantidad de cuotas sin pagar";
            colImporteDeuda.Text = "Importe total";

            colInstitucionDeuda.Width = 200;
            colCantCuotas.Width = 180;
            colImporteDeuda.Width = 80;

            #endregion

            #region Lista inscripciones

            this.lstInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInscripciones.FullRowSelect = true;
            this.lstInscripciones.GridLines = true;
            this.lstInscripciones.Location = new System.Drawing.Point(0, 0);
            this.lstInscripciones.MultiSelect = false;
            this.lstInscripciones.Name = "lstInscripciones";
            this.lstInscripciones.ShowItemToolTips = true;
            this.lstInscripciones.Size = new System.Drawing.Size(150, 46);
            this.lstInscripciones.TabIndex = 0;
            this.lstInscripciones.UseCompatibleStateImageBehavior = false;
            this.lstInscripciones.View = System.Windows.Forms.View.Details;
            this.lstInscripciones.SelectedIndexChanged += new System.EventHandler(this.lstSecundaria_SelectedIndexChanged);
            lstInscripciones.ColumnClick += new ColumnClickEventHandler(this.ColumnClickGrillaSecundaria);

            //Agrego las columnas correspondientes
            System.Windows.Forms.ColumnHeader colDocJugadorInscr = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colJugadorInscr = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colInstitucionInscr = new System.Windows.Forms.ColumnHeader();
            System.Windows.Forms.ColumnHeader colCostoInscripciónInscr = new System.Windows.Forms.ColumnHeader();

            this.lstInscripciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                    {
                        colDocJugadorInscr, colJugadorInscr, colInstitucionInscr, colCostoInscripciónInscr
                    });

            colDocJugadorInscr.Text = "Nro. documento";
            colJugadorInscr.Text = "Jugador";
            colInstitucionInscr.Text = "Institución";
            colCostoInscripciónInscr.Text = "Costo inscripción";

            colDocJugadorInscr.Width = 100;
            colJugadorInscr.Width = 150;
            colInstitucionInscr.Width = 150;
            colCostoInscripciónInscr.Width = 100;

            #endregion
        }

        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de controles

        #region Eventos botones de la cinta

        //Eventos disparados al hacer clic en los botones de las pestañas correspondientes.

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo(e.Item.Caption);
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Editar(e.Item.Caption);
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Eliminar(e.Item.Caption);
        }

        private void btnActualizarDatos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Actualizar(ribMenu.SelectedPage.Name);
        }

        private void btnAdmCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpcCategorias.Visible = true;
            tabCategorias.Visible = true;

            ribMenu.SelectedPage = tabCategorias;
        }

        private void btnAdministrarTipos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpcTipos.Visible = true;
            tabTipos.Visible = true;

            ribMenu.SelectedPage = tabTipos;
        }

        private void cmbTorneosAño_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtener torneos desde la base de datos.
            // Siempre retorna una coleccion de objetos.
            SistemaARA.Entidades.Torneos oTorneos;
            SistemaARA.Negocio.Torneos TorneosNegocio = new SistemaARA.Negocio.Torneos();

            DevExpress.XtraBars.BarItemLinkCollection links = cmbTorneosAño.ItemLinks;

            string año = "";

            // Estoy en la interfaz de usuario
            // Capturar siempre el error si ocurre
            try
            {
                foreach (DevExpress.XtraBars.BarCheckItemLink item in links)
                {
                    if (item.Item.Down)
                    {
                        año = item.Caption;
                        break;
                    }
                }

                if (año == "Todos")
                {
                    oTorneos = TorneosNegocio.GetAll();
                }
                else
                {
                    // Le pido a la capa de negocios las caregorías existentes
                    oTorneos = TorneosNegocio.GetTorneosAño(año);
                }

                CargarGrilla(oTorneos);

                ActualizarEstadoBotones();
            }
            catch (Exception ex)
            {
                // Muestro cualquier error que ocurra
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Libero memoria de objetos
                oTorneos = null;
                TorneosNegocio = null;
            }
        }

        private void cmbCuotasAño_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Actualizar("tabCuotas");
        }

        private void btnCargarGrillaSecundaria_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarGrillaSecundaria(e.Item.Name);
        }

        private void cargarInstitucionesCombos(object sender, DevExpress.XtraBars.ItemCancelEventArgs e)
        {
            CargarInstituciones();
        }

        private void cargarJugadoresCombos(object sender, DevExpress.XtraBars.ItemCancelEventArgs e)
        {
            CargarJugadores();
        }

        private void cargarArbitrosCombos(object sender, DevExpress.XtraBars.ItemCancelEventArgs e)
        {
            CargarArbitros();
        }

        private void cmbBuscarRazonSocial_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbe = (ComboBoxEdit)sender;

            object item = cbe.SelectedItem;

            if (item.ToString().Equals(""))
            {
                beiCuit.EditValue = "";
                Actualizar("tabInstituciones");
            }
            else
            {
                // Obtener instituciones desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Instituciones oInstituciones;
                SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las instituciones existentes
                    oInstituciones = oInstitucionesNegocio.GetOneRS(item.ToString());

                    if (oInstituciones.Count > 0)
                    {
                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstInstituciones.BeginUpdate();
                        
                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstInstituciones.Items.Count > 0)
                            lstInstituciones.Items.Clear();

                        SistemaARA.Entidades.Institucion oInstitucion = oInstituciones[0];

                        ListViewItem oItem;

                        oItem = lstInstituciones.Items.Add(oInstitucion.idInstitucion.ToString());

                        if (oInstitucion.cuit != "-        -")
                        {
                            oItem.SubItems.Add(oInstitucion.cuit);
                        }
                        else
                        {
                            oItem.SubItems.Add("S/D");
                        }
                        oItem.SubItems.Add(oInstitucion.razonSocial);
                        oItem.SubItems.Add(oInstitucion.direccion);
                        oItem.SubItems.Add(oInstitucion.nombreContacto);
                        oItem.SubItems.Add(oInstitucion.telefono);
                        oItem.SubItems.Add(oInstitucion.telCelular);
                        oItem.SubItems.Add(oInstitucion.email);

                        // Guardar la decripcion para utilzarla en citas
                        oItem.Tag = oInstitucion.ToString();

                        if (oInstitucion.cuit != "-        -")
                        {
                            beiCuit.EditValue = oInstitucion.cuit;
                        }

                        // Le indico al listview que puede repintar el control
                        lstInstituciones.EndUpdate();
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oInstituciones = null;
                    oInstitucionesNegocio = null;
                }
            }
        }

        private void cmbBuscarCuit_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbe = (ComboBoxEdit)sender;

            object item = cbe.SelectedItem;

            if (item.ToString().Equals(""))
            {
                beiBuscarRazonSocial.EditValue = "";
                Actualizar("tabInstituciones");
            }
            else
            {
                // Obtener instituciones desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Instituciones oInstituciones;
                SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las instituciones existentes
                    oInstituciones = oInstitucionesNegocio.GetOne(item.ToString());

                    if (oInstituciones.Count > 0)
                    {
                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstInstituciones.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstInstituciones.Items.Count > 0)
                            lstInstituciones.Items.Clear();

                        // Recorro cada institución y agrego los datos a la grilla
                        foreach (SistemaARA.Entidades.Institucion oInstitucion in oInstituciones)
                        {
                            ListViewItem oItem;

                            oItem = lstInstituciones.Items.Add(oInstitucion.idInstitucion.ToString());

                            oItem.SubItems.Add(oInstitucion.cuit);
                            oItem.SubItems.Add(oInstitucion.razonSocial);
                            oItem.SubItems.Add(oInstitucion.direccion);
                            oItem.SubItems.Add(oInstitucion.nombreContacto);
                            oItem.SubItems.Add(oInstitucion.telefono);
                            oItem.SubItems.Add(oInstitucion.telCelular);
                            oItem.SubItems.Add(oInstitucion.email);

                            // Guardar la decripcion para utilizarla en citas
                            oItem.Tag = oInstitucion.ToString();

                            beiBuscarRazonSocial.EditValue = oInstitucion.razonSocial;
                        }

                        // Le indico al listview que puede repintar el control
                        lstInstituciones.EndUpdate();
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oInstituciones = null;
                    oInstitucionesNegocio = null;
                }
            }
        }

        private void cmbBuscarJugNroDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbe = (ComboBoxEdit)sender;

            object item = cbe.SelectedItem;

            if (item.ToString().Equals(""))
            {
                beiBuscarJugApNom.EditValue = "";
                Actualizar("tabJugadores");
            }
            else
            {
                // Obtener Jugadores desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Jugadores oJugadores;
                SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las jugadores existentes
                    oJugadores = oJugadoresNegocio.GetOneNroDoc(item.ToString());

                    if (oJugadores.Count > 0)
                    {
                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstJugadores.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstJugadores.Items.Count > 0)
                            lstJugadores.Items.Clear();

                        SistemaARA.Entidades.Jugador oJugador = oJugadores[0];

                        ListViewItem oItem;

                        oItem = lstJugadores.Items.Add(oJugador.idJugador.ToString());

                        oItem.SubItems.Add(oJugador.nroDoc);
                        oItem.SubItems.Add(oJugador.tipoDoc);
                        oItem.SubItems.Add(oJugador.nombre);
                        oItem.SubItems.Add(oJugador.apellido);
                        oItem.SubItems.Add(oJugador.sexo);
                        oItem.SubItems.Add(oJugador.direccion);
                        oItem.SubItems.Add(oJugador.telefono);
                        oItem.SubItems.Add(oJugador.telCelular);
                        oItem.SubItems.Add(oJugador.email);
                        oItem.SubItems.Add(oJugador.fechaNacimiento.Date.ToShortDateString());

                        SistemaARA.Entidades.Instituciones oInstituciones;
                        SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                        oInstituciones = oInstitucionesNegocio.GetOne(oJugador.idInstitucion);

                        if (oInstituciones.Count > 0)
                        {
                            SistemaARA.Entidades.Institucion oInstitucion = oInstituciones[0];
                            oItem.SubItems.Add(oInstitucion.razonSocial);
                        }
                        else
                        {
                            oItem.SubItems.Add("");
                        }

                        oItem.SubItems.Add(oJugador.eloLocal);
                        oItem.SubItems.Add(oJugador.idFide);

                        // Guardar la decripcion para utilizarla en citas
                        oItem.Tag = oJugador.ToString();

                        beiBuscarJugApNom.EditValue = oJugador.apellido + ", " + oJugador.nombre;

                        // Le indico al listview que puede repintar el control
                        lstJugadores.EndUpdate();
                    }
                }
                catch (Exception ex)
                {
                    //Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oJugadores = null;
                    oJugadoresNegocio = null;
                }
            }
        }

        private void cmbBuscarJugApNom_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbe = (ComboBoxEdit)sender;

            object item = cbe.SelectedItem;

            if (item.ToString().Equals(""))
            {
                beiBuscarJugNroDoc.EditValue = "";
                Actualizar("tabJugadores");
            }
            else
            {
                // Obtener Jugadores desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Jugadores oJugadores;
                SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las jugadores existentes
                    oJugadores = oJugadoresNegocio.GetOne(item.ToString());

                    if (oJugadores.Count > 0)
                    {
                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstJugadores.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstJugadores.Items.Count > 0)
                            lstJugadores.Items.Clear();

                        SistemaARA.Entidades.Jugador oJugador = oJugadores[0];

                        ListViewItem oItem;

                        oItem = lstJugadores.Items.Add(oJugador.idJugador.ToString());

                        if (oJugador.nroDoc != ".   .")
                        {
                            oItem.SubItems.Add(oJugador.nroDoc);
                        }
                        else
                        {
                            oItem.SubItems.Add("S/D");
                        }

                        oItem.SubItems.Add(oJugador.tipoDoc);
                        oItem.SubItems.Add(oJugador.nombre);
                        oItem.SubItems.Add(oJugador.apellido);
                        oItem.SubItems.Add(oJugador.sexo);
                        oItem.SubItems.Add(oJugador.direccion);
                        oItem.SubItems.Add(oJugador.telefono);
                        oItem.SubItems.Add(oJugador.telCelular);
                        oItem.SubItems.Add(oJugador.email);
                        oItem.SubItems.Add(oJugador.fechaNacimiento.Date.ToShortDateString());

                        SistemaARA.Entidades.Instituciones oInstituciones;
                        SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                        oInstituciones = oInstitucionesNegocio.GetOne(oJugador.idInstitucion);

                        if (oInstituciones.Count > 0)
                        {
                            SistemaARA.Entidades.Institucion oInstitucion = oInstituciones[0];

                            oItem.SubItems.Add(oInstitucion.razonSocial);
                        }
                        else
                        {
                            oItem.SubItems.Add("");
                        }

                        oItem.SubItems.Add(oJugador.eloLocal);
                        oItem.SubItems.Add(oJugador.idFide);

                        // Guardar la decripcion para utilizarla en citas
                        oItem.Tag = oJugador.ToString();

                        if (oJugador.nroDoc != ".   .")
                        {
                            beiBuscarJugNroDoc.EditValue = oJugador.nroDoc;
                        }
                        else
                        {
                            beiBuscarJugNroDoc.EditValue = "";
                        }

                        // Le indico al listview que puede repintar el control
                        lstJugadores.EndUpdate();
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oJugadores = null;
                    oJugadoresNegocio = null;
                }
            }
        }

        private void cmbBuscarArbNroDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbe = (ComboBoxEdit)sender;

            object item = cbe.SelectedItem;

            if (item.ToString().Equals(""))
            {
                beiBuscarArbApNom.EditValue = "";
                Actualizar("tabArbitros");
            }
            else
            {
                // Obtener Jugadores desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Arbitros oArbitros;
                SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las jugadores existentes
                    oArbitros = oArbitrosNegocio.GetOneNroDoc(item.ToString());

                    if (oArbitros.Count > 0)
                    {
                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstArbitros.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstArbitros.Items.Count > 0)
                            lstArbitros.Items.Clear();

                        SistemaARA.Entidades.Arbitro oArbitro = oArbitros[0];

                        ListViewItem oItem;

                        oItem = lstArbitros.Items.Add(oArbitro.idArbitro.ToString());

                        oItem.SubItems.Add(oArbitro.nroDoc);
                        oItem.SubItems.Add(oArbitro.tipoDoc);
                        oItem.SubItems.Add(oArbitro.nombre);
                        oItem.SubItems.Add(oArbitro.apellido);
                        oItem.SubItems.Add(oArbitro.direccion);
                        oItem.SubItems.Add(oArbitro.localidad);
                        oItem.SubItems.Add(oArbitro.telefono);
                        oItem.SubItems.Add(oArbitro.telCelular);
                        oItem.SubItems.Add(oArbitro.email);
                        oItem.SubItems.Add(oArbitro.fechaNacimiento.Date.ToShortDateString());

                        SistemaARA.Entidades.Categorias oCategorias;
                        SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();

                        oCategorias = oCategoriasNegocio.GetOne(oArbitro.idCategoria);
                        SistemaARA.Entidades.Categoria oCategoria = oCategorias[0];

                        oItem.SubItems.Add(oCategoria.descripcion);

                        // Guardar la decripcion para utilizarla en citas
                        oItem.Tag = oArbitro.ToString();

                        beiBuscarArbApNom.EditValue = oArbitro.apellido + ", " + oArbitro.nombre;

                        // Le indico al listview que puede repintar el control
                        lstArbitros.EndUpdate();
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oArbitros = null;
                    oArbitrosNegocio = null;
                }
            }
        }

        private void cmbBuscarArbApNom_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbe = (ComboBoxEdit)sender;

            object item = cbe.SelectedItem;

            if (item.ToString().Equals(""))
            {
                beiBuscarArbNroDoc.EditValue = "";
                Actualizar("tabArbitros");
            }
            else
            {
                // Obtener Jugadores desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Arbitros oArbitros;
                SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las jugadores existentes
                    oArbitros = oArbitrosNegocio.GetOne(item.ToString());

                    if (oArbitros.Count > 0)
                    {
                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstArbitros.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstArbitros.Items.Count > 0)
                            lstArbitros.Items.Clear();

                        SistemaARA.Entidades.Arbitro oArbitro = oArbitros[0];

                        ListViewItem oItem;

                        oItem = lstArbitros.Items.Add(oArbitro.idArbitro.ToString());

                        oItem.SubItems.Add(oArbitro.nroDoc);
                        oItem.SubItems.Add(oArbitro.tipoDoc);
                        oItem.SubItems.Add(oArbitro.nombre);
                        oItem.SubItems.Add(oArbitro.apellido);
                        oItem.SubItems.Add(oArbitro.direccion);
                        oItem.SubItems.Add(oArbitro.localidad);
                        oItem.SubItems.Add(oArbitro.telefono);
                        oItem.SubItems.Add(oArbitro.telCelular);
                        oItem.SubItems.Add(oArbitro.email);
                        oItem.SubItems.Add(oArbitro.fechaNacimiento.Date.ToShortDateString());

                        SistemaARA.Entidades.Categorias oCategorias;
                        SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();

                        oCategorias = oCategoriasNegocio.GetOne(oArbitro.idCategoria);
                        SistemaARA.Entidades.Categoria oCategoria = oCategorias[0];

                        oItem.SubItems.Add(oCategoria.descripcion);

                        // Guardar la decripcion para utilizarla en citas
                        oItem.Tag = oArbitro.ToString();

                        beiBuscarArbNroDoc.EditValue = oArbitro.nroDoc;

                        // Le indico al listview que puede repintar el control
                        lstArbitros.EndUpdate();
                    }
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oArbitros = null;
                    oArbitrosNegocio = null;
                }
            }
        }

        private void btnInforme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fecha = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            string folderPath = string.Empty;

            using (FolderBrowserDialog fdb = new FolderBrowserDialog())
            {
                fdb.Description = "Seleccione la carpeta donde guardará el archivo.";

                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    folderPath = fdb.SelectedPath;
                }
            }

            if (folderPath != "")
            {
                string ruta = folderPath;

                if (e.Item.Name.Equals("btnExportarInstXLS"))
                {
                    ruta = ruta + "\\Sistema ARA - Instituciones registradas - " + fecha + ".xls";

                    try
                    {
                        infInstXLS informe = new infInstXLS();

                        informe.ExportToXls(ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (e.Item.Name.Equals("btnExportarXLS"))
                {
                    ruta = ruta + "\\Sistema ARA - Jugadores registrados - " + fecha + ".xls";

                    try
                    {
                        infJugExcel informe = new infJugExcel();

                        informe.ExportToXls(ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (e.Item.Name.Equals("btnInfInstRegistradas"))
                {
                    ruta = ruta + "\\Sistema ARA - Instituciones registradas - " + fecha + ".pdf";

                    try
                    {
                        infInstRegistradas informe = new infInstRegistradas();

                        informe.ExportToPdf(ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.Item.Name.Equals("btnInfJugInstitucion"))
                {
                    if (IsItemSelected(ribMenu.SelectedPage.Name))
                    {
                        ruta = ruta + "\\Sistema ARA - Jugadores de " + lstInstituciones.SelectedItems[0].SubItems[2].Text + " - " + fecha + ".pdf";

                        try
                        {
                            infJugInstitucion informe = new infJugInstitucion();

                            informe.idInstitucion.Value = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);

                            informe.ExportToPdf(ruta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una institución para generar este informe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.Item.Name.Equals("btnInfCuotasPagadas"))
                {
                    if (IsItemSelected(ribMenu.SelectedPage.Name))
                    {
                        ruta = ruta + "\\Sistema ARA - Cuotas pagadas de " + lstInstituciones.SelectedItems[0].SubItems[2].Text + " - " + fecha + ".pdf";

                        try
                        {
                            infCuotasPagadas informe = new infCuotasPagadas();

                            informe.idInstitucion.Value = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);

                            informe.ExportToPdf(ruta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Seleccione una institución para generar este informe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.Item.Name.Equals("btnInfJugRegistrados"))
                {
                    ruta = ruta + "\\Sistema ARA - Jugadores registrados - " + fecha + ".pdf";

                    try
                    {
                        infJugRegistrados informe = new infJugRegistrados();

                        informe.ExportToPdf(ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.Item.Name.Equals("btnInfDatosJugador"))
                {
                    if (IsItemSelected(ribMenu.SelectedPage.Name))
                    {
                        ruta = ruta + "\\Sistema ARA - Datos jugador " + lstJugadores.SelectedItems[0].SubItems[4].Text + ", " + lstJugadores.SelectedItems[0].SubItems[3].Text + " - " + fecha + ".pdf";

                        try
                        {
                            infDatosJugador informe = new infDatosJugador();

                            informe.idJugador.Value = Convert.ToInt32(lstJugadores.SelectedItems[0].Text);

                            informe.ExportToPdf(ruta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un jugador para generar este informe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.Item.Name.Equals("btnInfArbRegistrados"))
                {
                    ruta = ruta + "\\Sistema ARA - Árbitros registrados - " + fecha + ".pdf";

                    try
                    {
                        infArbRegistrados informe = new infArbRegistrados();

                        informe.ExportToPdf(ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.Item.Name.Equals("btnInfDatosArbitro"))
                {
                    if (IsItemSelected(ribMenu.SelectedPage.Name))
                    {
                        ruta = ruta + "\\Sistema ARA - Datos árbitro " + lstArbitros.SelectedItems[0].SubItems[4].Text + ", " + lstArbitros.SelectedItems[0].SubItems[3].Text + " - " + fecha + ".pdf";

                        try
                        {
                            infDatosArbitro informe = new infDatosArbitro();

                            informe.idArbitro.Value = Convert.ToInt32(lstArbitros.SelectedItems[0].Text);

                            informe.ExportToPdf(ruta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un árbitro para generar este informe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.Item.Name.Equals("btnInfInstCuotasPend"))
                {
                    ruta = ruta + "\\Sistema ARA - Instituciones con coutas pendientes - " + fecha + ".pdf";

                    try
                    {
                        infInstCuotasPend informe = new infInstCuotasPend();

                        informe.ExportToPdf(ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.Item.Name.Equals("btnInfJugInscriptos"))
                {
                    if (IsItemSelected(ribMenu.SelectedPage.Name))
                    {
                        ruta = ruta + "\\Sistema ARA - Inscripciones a " + lstTorneos.SelectedItems[0].SubItems[1].Text + " - " + fecha + ".pdf";

                        try
                        {
                            infJugInscriptos informe = new infJugInscriptos();

                            informe.idTorneo.Value = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

                            informe.ExportToPdf(ruta);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un torneo para generar este informe.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                StartProcess(ruta);
            }
        }

        private void btnExportarInscripciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFiltroCatInscripcion frmFiltroCatInscripcion = new frmFiltroCatInscripcion();

            frmFiltroCatInscripcion.IdTorneo = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

            frmFiltroCatInscripcion.NomTorneo = lstTorneos.SelectedItems[0].SubItems[1].Text;

            frmFiltroCatInscripcion.ShowDialog();

            frmFiltroCatInscripcion.Close();

            frmFiltroCatInscripcion = null;
        }

        private void btnAcercaDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAcercaDe frmAcercaDe = new frmAcercaDe();

            frmAcercaDe.ShowDialog();
        }

        private void btnAyuda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToString() + "\\Asociación Rosarina de Ajedrez\\Sistema de Gestión ARA\\Ayuda\\Ayuda Sistema de Gestión ARA.chm";

            StartProcess(path);
        }

        #endregion

        #region Eventos de cambios de selección de pestaña o ítem

        //Eventos que modifican la cinta.
        private void ribMenu_SelectedPageChanged(object sender, EventArgs e)
        {
            sctPaneles.Panel2Collapsed = true;

            if (!(ribMenu.SelectedPage.Name.Equals("tabCategorias")))
            {
                rpcCategorias.Visible = false;
                tabCategorias.Visible = false;
            }

            if (!(ribMenu.SelectedPage.Name.Equals("tabTipos")))
            {
                rpcTipos.Visible = false;
                tabTipos.Visible = false;
            }

            if (ribMenu.SelectedPage.Name.Equals("tabInstituciones"))
            {
                lstInstituciones.Visible = true;
                lstArbitros.Visible = false;
                lstJugadores.Visible = false;
                lstCuotas.Visible = false;
                lstTorneos.Visible = false;
                lstTipos.Visible = false;
                lstCategorias.Visible = false;
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabJugadores"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = false;
                lstJugadores.Visible = true;
                lstCuotas.Visible = false;
                lstTorneos.Visible = false;
                lstTipos.Visible = false;
                lstCategorias.Visible = false;
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabArbitros"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = true;
                lstJugadores.Visible = false;
                lstCuotas.Visible = false;
                lstTorneos.Visible = false;
                lstTipos.Visible = false;
                lstCategorias.Visible = false;
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabCuotas"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = false;
                lstJugadores.Visible = false;
                lstCuotas.Visible = true;
                lstTorneos.Visible = false;
                lstTipos.Visible = false;
                lstCategorias.Visible = false;
                chkDeudasInstituciones.Checked = false;

                CargarAñosCuotas();
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabCategorias"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = false;
                lstJugadores.Visible = false;
                lstCuotas.Visible = false;
                lstTorneos.Visible = false;
                lstTipos.Visible = false;
                lstCategorias.Visible = true;
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabTipos"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = false;
                lstJugadores.Visible = false;
                lstCuotas.Visible = false;
                lstTorneos.Visible = false;
                lstTipos.Visible = true;
                lstCategorias.Visible = false;
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabTorneos"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = false;
                lstJugadores.Visible = false;
                lstCuotas.Visible = false;
                lstTorneos.Visible = true;
                lstTipos.Visible = false;
                lstCategorias.Visible = false;

                CargarAñosTorneos();
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabAyuda"))
            {
                lstInstituciones.Visible = false;
                lstArbitros.Visible = false;
                lstJugadores.Visible = false;
                lstCuotas.Visible = false;
                lstTorneos.Visible = false;
                lstTipos.Visible = false;
                lstCategorias.Visible = false;
            }
        }

        //Evento que se ejecuta cuando se hace clic en un ítem de la grilla principal
        private void lstPrincipal_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ActualizarEstadoBotones();
        }

        //Evento que se ejecuta cuando se hace clic en un ítem de la grilla secundaria
        private void lstSecundaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotones2();
        }

        #endregion

        #endregion

        #region Métodos de controles

        /// <summary>
        /// Actualiza el estado de los botones de acuerdo a los eventos de la grilla principal
        /// </summary>
        private void ActualizarEstadoBotones()
        {
            if (ribMenu.SelectedPage.Name.Equals("tabInstituciones"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarInstitucion.Enabled = true;
                    btnEliminarInstitucion.Enabled = true;
                    pgpCuotasInstitucion.Enabled = true;
                    cmbVerCuotas.Enabled = true;
                    chkCuotasAPagar.Checked = false;
                    chkCuotasPagadas.Checked = false;
                    btnVerJugadoresAsociados.Enabled = true;
                    btnInfJugInstitucion.Enabled = true;
                    btnInfCuotasPagadas.Enabled = true;
                }
                else
                {
                    btnModificarInstitucion.Enabled = false;
                    btnEliminarInstitucion.Enabled = false;
                    pgpCuotasInstitucion.Enabled = false;
                    cmbVerCuotas.Enabled = false;
                    btnRegistrarPagoCuota.Enabled = false;
                    sctPaneles.Panel2Collapsed = true;
                    chkCuotasAPagar.Checked = false;
                    chkCuotasPagadas.Checked = false;
                    btnModificarPagoCuota.Enabled = false;
                    btnEliminarPagoCuota.Enabled = false;
                    btnVerJugadoresAsociados.Enabled = false;
                    btnInfJugInstitucion.Enabled = false;
                    btnInfCuotasPagadas.Enabled = false;
                }
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabJugadores"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarJugador.Enabled = true;
                    btnEliminarJugador.Enabled = true;
                    btnInfDatosJugador.Enabled = true;
                }
                else
                {
                    btnModificarJugador.Enabled = false;
                    btnEliminarJugador.Enabled = false;
                    btnInfDatosJugador.Enabled = false;
                }
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabArbitros"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarArbitro.Enabled = true;
                    btnEliminarArbitro.Enabled = true;
                    btnInfDatosArbitro.Enabled = true;
                }
                else
                {
                    btnModificarArbitro.Enabled = false;
                    btnEliminarArbitro.Enabled = false;
                    btnInfDatosArbitro.Enabled = false;
                }
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabCuotas"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarCuota.Enabled = true;
                    btnEliminarCuota.Enabled = true;
                }
                else
                {
                    btnModificarCuota.Enabled = false;
                    btnEliminarCuota.Enabled = false;
                }
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabCategorias"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarCategoria.Enabled = true;
                    btnEliminarCategoria.Enabled = true;
                }
                else
                {
                    btnModificarCategoria.Enabled = false;
                    btnEliminarCategoria.Enabled = false;
                }
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabTorneos"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarTorneo.Enabled = true;
                    btnEliminarTorneo.Enabled = true;
                    pgpInscripcionesTorneo.Enabled = true;
                    btnInfJugInscriptos.Enabled = true;
                    btnExportarInscripciones.Enabled = true;
                }
                else
                {
                    btnModificarTorneo.Enabled = false;
                    btnEliminarTorneo.Enabled = false;
                    pgpInscripcionesTorneo.Enabled = false;
                    sctPaneles.Panel2Collapsed = true;
                    btnInfJugInscriptos.Enabled = false;
                    btnExportarInscripciones.Enabled = false;
                    btnModificarInscripcion.Enabled = false;
                    btnEliminarInscripcion.Enabled = false;
                }
            }
            else if (ribMenu.SelectedPage.Name.Equals("tabTipos"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    btnModificarTipo.Enabled = true;
                    btnEliminarTipo.Enabled = true;
                }
                else
                {
                    btnModificarTipo.Enabled = false;
                    btnEliminarTipo.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Actualiza el estado de los botones de acuerdo a los eventos de la grilla secundaria
        /// </summary>
        private void ActualizarEstadoBotones2()
        {
            if (ribMenu.SelectedPage.Name.Equals("tabInstituciones"))
            {
                if (IsItemSelected2("chkCuotasAPagar") || IsItemSelected2("chkCuotasPagadas"))
                {
                    if (chkCuotasAPagar.Checked)
                    {
                        btnRegistrarPagoCuota.Enabled = true;
                        btnModificarPagoCuota.Enabled = false;
                        btnEliminarPagoCuota.Enabled = false;
                    }
                    else if (chkCuotasPagadas.Checked)
                    {
                        btnRegistrarPagoCuota.Enabled = false;
                        btnModificarPagoCuota.Enabled = true;
                        btnEliminarPagoCuota.Enabled = true;
                    }
                }
                else
                {
                    btnRegistrarPagoCuota.Enabled = false;
                    btnModificarPagoCuota.Enabled = false;
                    btnEliminarPagoCuota.Enabled = false;
                }
            }

            else if (ribMenu.SelectedPage.Name.Equals("tabTorneos"))
            {
                if (IsItemSelected2("btnVerInscripciones"))
                {
                    btnModificarInscripcion.Enabled = true;
                    btnEliminarInscripcion.Enabled = true;
                }
                else
                {
                    btnModificarInscripcion.Enabled = false;
                    btnEliminarInscripcion.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Carga los años del control cmbCuotasAño de la pestaña cuotas
        /// </summary>
        private void CargarAñosCuotas()
        {
            SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();
            SistemaARA.Entidades.Cuotas oCuotas;

            List<string> años = new List<string>();

            cmbCuotasAño.BeginUpdate();

            cmbCuotasAño.ClearLinks();

            DevExpress.XtraBars.BarCheckItem itemTodos = new DevExpress.XtraBars.BarCheckItem();
            itemTodos.Caption = "Todos";
            itemTodos.Name = "chkTodos";
            itemTodos.GroupIndex = 1;
            itemTodos.Checked = true;

            cmbCuotasAño.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(itemTodos));
            cmbCuotasAño.AddItem(itemTodos);
            itemTodos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmbCuotasAño_Click);

            oCuotas = oCuotasNegocio.GetAll();

            foreach (SistemaARA.Entidades.Cuota oCuota in oCuotas)
            {
                bool esta = false;

                foreach (string a in años)
                {
                    if (años.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (oCuota.fecha.Year.ToString().Equals(a))
                        {
                            esta = true;
                            break;
                        }
                    }
                }

                if (!esta)
                {
                    años.Add(oCuota.fecha.Year.ToString());
                }
            }

            foreach (string a in años)
            {
                DevExpress.XtraBars.BarCheckItem item = new DevExpress.XtraBars.BarCheckItem();

                item.Caption = a;
                item.Name = "chk" + a;
                item.GroupIndex = 1;

                cmbCuotasAño.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(item));
                cmbCuotasAño.AddItem(item);

                item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmbCuotasAño_Click);

                if (a.Equals(DateTime.Today.Year.ToString()))
                {
                    item.Checked = true;
                }
            }

            cmbCuotasAño.EndUpdate();
        }

        /// <summary>
        /// Carga los años del control cmbTorneosAño de la pestaña cuotas
        /// </summary>
        private void CargarAñosTorneos()
        {
            SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();
            SistemaARA.Entidades.Torneos oTorneos;

            List<string> años = new List<string>();

            cmbTorneosAño.BeginUpdate();

            cmbTorneosAño.ClearLinks();

            DevExpress.XtraBars.BarCheckItem itemTodos = new DevExpress.XtraBars.BarCheckItem();
            itemTodos.Caption = "Todos";
            itemTodos.Name = "chkTodos";
            itemTodos.GroupIndex = 1;
            itemTodos.Checked = true;

            cmbTorneosAño.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(itemTodos));
            cmbTorneosAño.AddItem(itemTodos);
            itemTodos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmbTorneosAño_Click);

            oTorneos = oTorneosNegocio.GetAll();

            foreach (SistemaARA.Entidades.Torneo oTorneo in oTorneos)
            {
                bool esta = false;

                foreach (string a in años)
                {
                    if (años.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (oTorneo.fechaHora.Year.ToString().Equals(a))
                        {
                            esta = true;
                            break;
                        }
                    }
                }

                if (!esta)
                {
                    años.Add(oTorneo.fechaHora.Year.ToString());
                }
            }

            foreach (string a in años)
            {
                DevExpress.XtraBars.BarCheckItem item = new DevExpress.XtraBars.BarCheckItem();

                item.Caption = a;
                item.Name = "chk" + a;
                item.GroupIndex = 1;

                cmbTorneosAño.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(item));
                cmbTorneosAño.AddItem(item);

                item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmbTorneosAño_Click);

                if (a.Equals(DateTime.Today.Year.ToString()))
                {
                    item.Checked = true;
                }
            }

            cmbCuotasAño.EndUpdate();
        }

        /// <summary>
        /// Carga los combo de búqueda de la pestaña instituciones
        /// </summary>
        private void CargarInstituciones()
        {
            SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();
            SistemaARA.Entidades.Instituciones oInstituciones;

            cmbBuscarRazonSocial.BeginUpdate();
            cmbBuscarRazonSocial.Items.Clear();
            cmbBuscarRazonSocial.Items.Add("");

            cmbBuscarCuit.BeginUpdate();
            cmbBuscarCuit.Items.Clear();
            cmbBuscarCuit.Items.Add("");

            oInstituciones = oInstitucionesNegocio.GetAll();

            foreach (SistemaARA.Entidades.Institucion oInstitucion in oInstituciones)
            {
                if (oInstitucion.cuit != "-        -")
                {
                    cmbBuscarCuit.Items.Add(oInstitucion.cuit);
                }
                cmbBuscarRazonSocial.Items.Add(oInstitucion.razonSocial);
            }

            cmbBuscarRazonSocial.EndUpdate();
            cmbBuscarCuit.EndUpdate();
        }

        /// <summary>
        /// Carga los combo de búqueda de la pestaña instituciones
        /// </summary>
        private void CargarJugadores()
        {
            SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
            SistemaARA.Entidades.Jugadores oJugadores;

            cmbBuscarJugNroDoc.BeginUpdate();
            cmbBuscarJugNroDoc.Items.Clear();
            cmbBuscarJugNroDoc.Items.Add("");

            cmbBuscarJugApNom.BeginUpdate();
            cmbBuscarJugApNom.Items.Clear();
            cmbBuscarJugApNom.Items.Add("");

            oJugadores = oJugadoresNegocio.GetAll();

            foreach (SistemaARA.Entidades.Jugador oJugador in oJugadores)
            {
                if (oJugador.nroDoc != ".   .")
                {
                    cmbBuscarJugNroDoc.Items.Add(oJugador.nroDoc);
                }

                cmbBuscarJugApNom.Items.Add(oJugador.apellido + ", " + oJugador.nombre);
            }

            cmbBuscarJugNroDoc.EndUpdate();
            cmbBuscarJugApNom.EndUpdate();
        }

        /// <summary>
        /// Carga los combo de búqueda de la pestaña árbitros
        /// </summary>
        private void CargarArbitros()
        {
            SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();
            SistemaARA.Entidades.Arbitros oArbitros;

            cmbBuscarArbNroDoc.BeginUpdate();
            cmbBuscarArbNroDoc.Items.Clear();
            cmbBuscarArbNroDoc.Items.Add("");

            cmbBuscarArbApNom.BeginUpdate();
            cmbBuscarArbApNom.Items.Clear();
            cmbBuscarArbApNom.Items.Add("");

            oArbitros = oArbitrosNegocio.GetAll();

            foreach (SistemaARA.Entidades.Arbitro oArbitro in oArbitros)
            {
                cmbBuscarArbNroDoc.Items.Add(oArbitro.nroDoc);
                cmbBuscarArbApNom.Items.Add(oArbitro.apellido + ", " + oArbitro.nombre);
            }

            cmbBuscarArbNroDoc.EndUpdate();
            cmbBuscarArbApNom.EndUpdate();
        }

        #region CargarGrilla

        /// <summary>
        /// Carga la grilla de instituciones con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Instituciones oInstituciones)
        {
            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstInstituciones.BeginUpdate();
            
            if (oInstituciones.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstInstituciones.Items.Count > 0)
                    lstInstituciones.Items.Clear();

                // Recorro cada institución y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Institucion oInstitucion in oInstituciones)
                {
                    ListViewItem oItem;

                    oItem = lstInstituciones.Items.Add(oInstitucion.idInstitucion.ToString());

                    if (oInstitucion.cuit.Equals("-        -"))
                    {
                        oItem.SubItems.Add("S/D");
                    }
                    else
                    {
                        oItem.SubItems.Add(oInstitucion.cuit);
                    }
                    oItem.SubItems.Add(oInstitucion.razonSocial);
                    oItem.SubItems.Add(oInstitucion.direccion);
                    oItem.SubItems.Add(oInstitucion.localidad);
                    oItem.SubItems.Add(oInstitucion.telefono);
                    oItem.SubItems.Add(oInstitucion.telCelular);
                    oItem.SubItems.Add(oInstitucion.email);
                    oItem.SubItems.Add(oInstitucion.nombreContacto);

                    // Guardar la decripcion para utilzarla en citas
                    oItem.Tag = oInstitucion.ToString();
                }
            }
            else
            {
                lstInstituciones.Items.Clear();
            }
            
            // Le indico al listview que puede repintar el control
            lstInstituciones.EndUpdate();
        }

        /// <summary>
        /// Carga la grilla de jugadores con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Jugadores oJugadores)
        {

            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstJugadores.BeginUpdate();

            if (oJugadores.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstJugadores.Items.Count > 0)
                    lstJugadores.Items.Clear();

                // Recorro cada jugador y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Jugador oJugador in oJugadores)
                {
                    ListViewItem oItem;

                    oItem = lstJugadores.Items.Add(oJugador.idJugador.ToString());

                    if (oJugador.nroDoc == "" || oJugador.nroDoc == ".   .")
                    {
                        oItem.SubItems.Add("");
                    }
                    else
                    {
                        oItem.SubItems.Add(oJugador.nroDoc);
                    }
                    oItem.SubItems.Add(oJugador.tipoDoc);
                    oItem.SubItems.Add(oJugador.apellido);
                    oItem.SubItems.Add(oJugador.nombre);
                    oItem.SubItems.Add(oJugador.sexo);
                    oItem.SubItems.Add(oJugador.direccion);
                    oItem.SubItems.Add(oJugador.localidad);
                    oItem.SubItems.Add(oJugador.telefono);
                    oItem.SubItems.Add(oJugador.telCelular);
                    oItem.SubItems.Add(oJugador.email);
                    oItem.SubItems.Add(oJugador.fechaNacimiento.Date.ToShortDateString());

                    SistemaARA.Entidades.Instituciones oInstituciones;
                    SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                    oInstituciones = oInstitucionesNegocio.GetOne(oJugador.idInstitucion);

                    if (oInstituciones.Count > 0)
                    {
                        SistemaARA.Entidades.Institucion oInstitucion = oInstituciones[0];

                        oItem.SubItems.Add(oInstitucion.razonSocial);
                    }
                    else
                    {
                        oItem.SubItems.Add("S/D");
                    }

                    oItem.SubItems.Add(oJugador.eloLocal);
                    oItem.SubItems.Add(oJugador.idFide);

                    // Guardar la decripcion para utilizarla en citas
                    oItem.Tag = oJugador.ToString();
                }
            }
            else
            {
                lstJugadores.Items.Clear();
            }

            // Le indico al listview que puede repintar el control
            lstJugadores.EndUpdate();
        }

        /// <summary>
        /// Carga la grilla de árbitros con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Arbitros oArbitros)
        {
            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstArbitros.BeginUpdate();

            if (oArbitros.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstArbitros.Items.Count > 0)
                    lstArbitros.Items.Clear();

                // Recorro cada árbitro y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Arbitro oArbitro in oArbitros)
                {
                    ListViewItem oItem;

                    oItem = lstArbitros.Items.Add(oArbitro.idArbitro.ToString());

                    oItem.SubItems.Add(oArbitro.nroDoc);
                    oItem.SubItems.Add(oArbitro.tipoDoc);
                    oItem.SubItems.Add(oArbitro.apellido);
                    oItem.SubItems.Add(oArbitro.nombre);
                    oItem.SubItems.Add(oArbitro.direccion);
                    oItem.SubItems.Add(oArbitro.localidad);
                    oItem.SubItems.Add(oArbitro.telefono);
                    oItem.SubItems.Add(oArbitro.telCelular);
                    oItem.SubItems.Add(oArbitro.email);
                    oItem.SubItems.Add(oArbitro.fechaNacimiento.Date.ToShortDateString());

                    SistemaARA.Entidades.Categorias oCategorias;
                    SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();

                    oCategorias = oCategoriasNegocio.GetOne(oArbitro.idCategoria);

                    if (oCategorias.Count() > 0)
                    {
                        SistemaARA.Entidades.Categoria oCategoria = oCategorias[0];

                        oItem.SubItems.Add(oCategoria.descripcion);
                    }
                    else
                    {
                        oItem.SubItems.Add("");
                    }                    

                    // Guardar la decripcion para utilizarla en citas
                    oItem.Tag = oArbitro.ToString();
                }
            }
            else
            {
                lstArbitros.Items.Clear();
            }

            // Le indico al listview que puede repintar el control
            lstArbitros.EndUpdate();
        }

        /// <summary>
        /// Carga la grilla de categorías con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Categorias oCategorias)
        {
            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstCategorias.BeginUpdate();

            if (oCategorias.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstCategorias.Items.Count > 0)
                    lstCategorias.Items.Clear();

                // Recorro cada categoría y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Categoria oCategoria in oCategorias)
                {
                    ListViewItem oItem;

                    oItem = lstCategorias.Items.Add(oCategoria.idCategoria.ToString());

                    oItem.SubItems.Add(oCategoria.descripcion);

                    // Guardar la decripcion para utilizarla en citas
                    oItem.Tag = oCategoria.ToString();
                }
            }
            else
            {
                lstCategorias.Items.Clear();
            }

            // Le indico al listview que puede repintar el control
            lstCategorias.EndUpdate();
        }

        /// <summary>
        /// Carga la grilla de tipos con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Tipos oTipos)
        {
            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstTipos.BeginUpdate();

            if (oTipos.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstTipos.Items.Count > 0)
                    lstTipos.Items.Clear();

                // Recorro cada tipo y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Tipo oTipo in oTipos)
                {
                    ListViewItem oItem;

                    oItem = lstTipos.Items.Add(oTipo.idTipo.ToString());

                    oItem.SubItems.Add(oTipo.descripcion);

                    // Guardar la decripcion para utilizarla en citas
                    oItem.Tag = oTipo.ToString();
                }
            }
            else
            {
                lstTipos.Items.Clear();
            }

            // Le indico al listview que puede repintar el control
            lstTipos.EndUpdate();
        }

        /// <summary>
        /// Carga la grilla de cuotas con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Cuotas oCuotas)
        {
            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstCuotas.BeginUpdate();

            if (oCuotas.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstCuotas.Items.Count > 0)
                    lstCuotas.Items.Clear();

                // Recorro cada categoría y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Cuota oCuota in oCuotas)
                {
                    ListViewItem oItem;

                    oItem = lstCuotas.Items.Add(oCuota.fecha.ToString("MM") + "/" + oCuota.fecha.Year.ToString());

                    oItem.SubItems.Add("$ " + oCuota.importe);

                    // Guardar la decripcion para utilizarla en citas
                    oItem.Tag = oCuota.ToString();
                }
            }
            else
            {
                lstCuotas.Items.Clear();
            }

            // Le indico al listview que puede repintar el control
            lstCuotas.EndUpdate();
        }

        /// <summary>
        /// Carga la grilla de torneos con datos
        /// </summary>
        private void CargarGrilla(SistemaARA.Entidades.Torneos oTorneos)
        {
            // Indicamos que no repinte el control hasta que terminemos
            // Esto acelera el proceso de carga en el control
            lstTorneos.BeginUpdate();

            if (oTorneos.Count > 0)
            {
                // Eliminamos los datos de la grilla si contiene algo
                if (lstTorneos.Items.Count > 0)
                    lstTorneos.Items.Clear();

                // Recorro cada árbitro y agrego los datos a la grilla
                foreach (SistemaARA.Entidades.Torneo oTorneo in oTorneos)
                {
                    ListViewItem oItem;

                    oItem = lstTorneos.Items.Add(oTorneo.idTorneo.ToString());

                    oItem.SubItems.Add(oTorneo.nombre);
                    oItem.SubItems.Add(oTorneo.lugar);
                    oItem.SubItems.Add(oTorneo.direccion);
                    oItem.SubItems.Add(oTorneo.fechaHora.ToString());

                    SistemaARA.Entidades.Tipos oTipos;
                    SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();

                    oTipos = oTiposNegocio.GetOne(oTorneo.idTipo);
                    SistemaARA.Entidades.Tipo oTipo = oTipos[0];

                    oItem.SubItems.Add(oTipo.descripcion);

                    SistemaARA.Entidades.Arbitros oArbitros;
                    SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                    oArbitros = oArbitrosNegocio.GetOne(oTorneo.idArbitro);

                    if (oArbitros.Count > 0)
                    {
                        SistemaARA.Entidades.Arbitro oArbitro = oArbitros[0];

                        oItem.SubItems.Add(oArbitro.apellido + ", " + oArbitro.nombre);
                    }
                    else
                    {
                        oItem.SubItems.Add("");
                    }

                    oItem.SubItems.Add("$ " + oTorneo.costoEstandar.ToString());

                    // Guardar la decripcion para utilizarla en citas
                    oItem.Tag = oTorneo.ToString();
                }
            }
            else
            {
                lstTorneos.Items.Clear();
            }

            // Le indico al listview que puede repintar el control
            lstTorneos.EndUpdate();
        }

        #endregion

        /// <summary>
        /// Carga la grilla secundaria con datos
        /// </summary>
        private void CargarGrillaSecundaria(string tipo)
        {
            #region Cuotas a pagar

            if (tipo.Equals("chkCuotasAPagar"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    sctPaneles.Panel2Collapsed = false;
                    lstCuotasAPagar.Visible = true;
                    lstCuotasPagadas.Visible = false;
                    lstInscripciones.Visible = false;
                    lstInstitucionesConDeudas.Visible = false;
                    lstJugAsociados.Visible = false;

                    // Obtener cuotas desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Cuotas oCuotas;
                    SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

                    try
                    {
                        oCuotas = oCuotasNegocio.GetCuotasAPagar(Convert.ToInt32(lstInstituciones.SelectedItems[0].Text));

                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstCuotasAPagar.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstCuotasAPagar.Items.Count > 0)
                            lstCuotasAPagar.Items.Clear();

                        // Recorro cada cuota y agrego los datos a la grilla
                        foreach (SistemaARA.Entidades.Cuota oCuota in oCuotas)
                        {
                            ListViewItem oItem;

                            oItem = lstCuotasAPagar.Items.Add(oCuota.fecha.ToString("MM") + "/" + oCuota.fecha.Year.ToString());

                            oItem.SubItems.Add("$ " + oCuota.importe);

                            // Guardar la decripcion para utilizarla en citas
                            oItem.Tag = oCuota.ToString();
                        }

                        // Le indico al listview que puede repintar el control
                        lstCuotasAPagar.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error que ocurra
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Libero memoria de objetos
                        oCuotas = null;
                        oCuotasNegocio = null;
                    }
                }
            }

            #endregion

            #region Cuotas pagadas

            else if (tipo.Equals("chkCuotasPagadas"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    sctPaneles.Panel2Collapsed = false;

                    lstCuotasAPagar.Visible = false;
                    lstCuotasPagadas.Visible = true;
                    lstInscripciones.Visible = false;
                    lstInstitucionesConDeudas.Visible = false;
                    lstJugAsociados.Visible = false;

                    // Obtener pagos desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Pagos oPagos;
                    SistemaARA.Negocio.Pagos oPagosNegocio = new SistemaARA.Negocio.Pagos();

                    // Obtener cuotas desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Cuotas oCuotas;
                    SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

                    try
                    {
                        oPagos = oPagosNegocio.GetAll(Convert.ToInt32(lstInstituciones.SelectedItems[0].Text));

                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstCuotasPagadas.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstCuotasPagadas.Items.Count > 0)
                            lstCuotasPagadas.Items.Clear();

                        // Recorro cada categoría y agrego los datos a la grilla
                        foreach (SistemaARA.Entidades.Pago oPago in oPagos)
                        {
                            ListViewItem oItem;

                            oItem = lstCuotasPagadas.Items.Add(oPago.fecha.ToString("MM") + "/" + oPago.fecha.Year.ToString());

                            oItem.SubItems.Add(oPago.fechaPago.ToShortDateString());

                            oCuotas = oCuotasNegocio.GetOne(oPago.fecha);

                            oItem.SubItems.Add("$ " + oCuotas[0].importe);

                            // Guardar la decripcion para utilizarla en citas
                            oItem.Tag = oPago.ToString();
                        }

                        // Le indico al listview que puede repintar el control
                        lstCuotasPagadas.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error que ocurra
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Libero memoria de objetos
                        oPagos = null;
                        oPagosNegocio = null;
                    }
                }
            }

            #endregion

            #region Inscripciones

            else if (tipo.Equals("btnVerInscripciones"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    sctPaneles.Panel2Collapsed = false;

                    lstCuotasAPagar.Visible = false;
                    lstCuotasPagadas.Visible = false;
                    lstInscripciones.Visible = true;
                    lstInstitucionesConDeudas.Visible = false;
                    lstJugAsociados.Visible = false;

                    // Obtener inscripciones desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Inscripciones oInscripciones;
                    SistemaARA.Negocio.Inscripciones oInscripcionesNegocio = new SistemaARA.Negocio.Inscripciones();

                    // Obtener jugadores desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Jugadores oJugador;
                    SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                    // Obtener instituciones desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Instituciones oInstitucion;
                    SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                    try
                    {
                        oInscripciones = oInscripcionesNegocio.GetAll(Convert.ToInt32(lstTorneos.SelectedItems[0].Text));

                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstInscripciones.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstInscripciones.Items.Count > 0)
                            lstInscripciones.Items.Clear();

                        // Recorro cada categoría y agrego los datos a la grilla
                        foreach (SistemaARA.Entidades.Inscripcion oInscripcion in oInscripciones)
                        {
                            ListViewItem oItem;

                            oJugador = oJugadoresNegocio.GetOne(oInscripcion.idJugador);

                            if (oJugador[0].nroDoc.ToString() == ".   .")
                            {
                                oItem = lstInscripciones.Items.Add("");
                            }
                            else
                            {
                                oItem = lstInscripciones.Items.Add(oJugador[0].nroDoc.ToString());
                            }

                            oItem.SubItems.Add(oJugador[0].apellido + ", " + oJugador[0].nombre);

                            oInstitucion = oInstitucionesNegocio.GetOne(oJugador[0].idInstitucion);

                            if (oInstitucion.Count > 0)
                            {
                                oItem.SubItems.Add(oInstitucion[0].razonSocial);
                            }
                            else
                            {
                                oItem.SubItems.Add("");
                            }

                            oItem.SubItems.Add("$ " + oInscripcion.costoInscripcion.ToString());

                            // Guardar la decripcion para utilizarla en citas
                            oItem.Tag = oInscripcion.ToString();
                        }

                        // Le indico al listview que puede repintar el control
                        lstInscripciones.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error que ocurra
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Libero memoria de objetos
                        oInscripciones = null;
                        oInscripcionesNegocio = null;
                    }
                }
            }

            #endregion

            #region Jugadores

            else if (tipo.Equals("btnVerJugadoresAsociados"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    sctPaneles.Panel2Collapsed = false;

                    lstCuotasAPagar.Visible = false;
                    lstCuotasPagadas.Visible = false;
                    lstInscripciones.Visible = false;
                    lstInstitucionesConDeudas.Visible = false;
                    lstJugAsociados.Visible = true;

                    // Obtener jugadores desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Jugadores oJugadores;
                    SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                    try
                    {
                        oJugadores = oJugadoresNegocio.GetAll(Convert.ToInt32(lstInstituciones.SelectedItems[0].Text));

                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstJugAsociados.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstJugAsociados.Items.Count > 0)
                            lstJugAsociados.Items.Clear();

                        // Recorro cada categoría y agrego los datos a la grilla
                        foreach (SistemaARA.Entidades.Jugador oJugador in oJugadores)
                        {
                            ListViewItem oItem;

                            oItem = lstJugAsociados.Items.Add(oJugador.idJugador.ToString());

                            if (oJugador.nroDoc == "" || oJugador.nroDoc == ".   .")
                            {
                                oItem.SubItems.Add("");
                            }
                            else
                            {
                                oItem.SubItems.Add(oJugador.nroDoc);
                            }
                            oItem.SubItems.Add(oJugador.tipoDoc);
                            oItem.SubItems.Add(oJugador.nombre);
                            oItem.SubItems.Add(oJugador.apellido);
                            oItem.SubItems.Add(oJugador.sexo);
                            oItem.SubItems.Add(oJugador.direccion);
                            oItem.SubItems.Add(oJugador.telefono);
                            oItem.SubItems.Add(oJugador.telCelular);
                            oItem.SubItems.Add(oJugador.email);
                            oItem.SubItems.Add(oJugador.fechaNacimiento.Date.ToShortDateString());
                            oItem.SubItems.Add(oJugador.eloLocal);
                            oItem.SubItems.Add(oJugador.idFide);

                            // Guardar la decripcion para utilizarla en citas
                            oItem.Tag = oJugador.ToString();
                        }

                        // Le indico al listview que puede repintar el control
                        lstJugAsociados.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error que ocurra
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Libero memoria de objetos
                        oJugadores = null;
                        oJugadoresNegocio = null;
                    }
                }
            }

            #endregion

            #region Instituciones con cuotas pendientes de pago

            else if (tipo.Equals("chkDeudasInstituciones"))
            {
                if (chkDeudasInstituciones.Checked)
                {
                    sctPaneles.Panel2Collapsed = false;

                    lstCuotasAPagar.Visible = false;
                    lstCuotasPagadas.Visible = false;
                    lstInscripciones.Visible = false;
                    lstInstitucionesConDeudas.Visible = true;
                    lstJugAsociados.Visible = false;

                    // Obtener cuotas desde la base de datos.
                    // Siempre retorna una coleccion de objetos.
                    SistemaARA.Entidades.Cuotas oCuotas;
                    SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

                    SistemaARA.Entidades.Instituciones oInstituciones;
                    SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                    try
                    {
                        oInstituciones = oInstitucionesNegocio.GetAll();

                        // Indicamos que no repinte el control hasta que terminemos
                        // Esto acelera el proceso de carga en el control
                        lstInstitucionesConDeudas.BeginUpdate();

                        // Eliminamos los datos de la grilla si contiene algo
                        if (lstInstitucionesConDeudas.Items.Count > 0)
                            lstInstitucionesConDeudas.Items.Clear();

                        if (oInstituciones.Count > 0)
                        {
                            foreach (SistemaARA.Entidades.Institucion oInstitucion in oInstituciones)
                            {
                                oCuotas = oCuotasNegocio.GetCuotasAPagar(oInstitucion.idInstitucion);

                                if (oCuotas.Count > 0)
                                {
                                    float importeTotal = 0;

                                    ListViewItem oItem;

                                    oItem = lstInstitucionesConDeudas.Items.Add(oInstitucion.razonSocial);
                                    oItem.SubItems.Add(oCuotas.Count.ToString());

                                    // Recorro cada cuota y agrego los datos a la grilla
                                    foreach (SistemaARA.Entidades.Cuota oCuota in oCuotas)
                                    {
                                        importeTotal = importeTotal + Convert.ToInt64(oCuota.importe);
                                    }

                                    oItem.SubItems.Add("$ " + importeTotal.ToString());

                                    // Guardar la decripcion para utilizarla en citas
                                    oItem.Tag = oInstitucion.ToString();
                                }
                            }
                        }

                        // Le indico al listview que puede repintar el control
                        lstInstitucionesConDeudas.EndUpdate();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error que ocurra
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Libero memoria de objetos
                        oCuotas = null;
                        oCuotasNegocio = null;
                    }
                }
                else
                {
                    sctPaneles.Panel2Collapsed = true;
                }
            }

            #endregion
        }

        /// <summary>
        /// Verifica si existe un ítem seleccionado en la grilla principal
        /// </summary>
        /// <returns>True si un item fue seleccionado, de lo contrario False</returns>
        private bool IsItemSelected(string tipo)
        {
            #region Instituciones

            if (tipo.Equals("tabInstituciones"))
            {
                return (lstInstituciones.SelectedItems.Count > 0);
            }

            #endregion

            #region Jugadores

            else if (tipo.Equals("tabJugadores"))
            {
                return (lstJugadores.SelectedItems.Count > 0);
            }

            #endregion

            #region Arbitros

            else if (tipo.Equals("tabArbitros"))
            {
                return (lstArbitros.SelectedItems.Count > 0);
            }

            #endregion

            #region Cuotas

            else if (tipo.Equals("tabCuotas"))
            {
                return (lstCuotas.SelectedItems.Count > 0);
            }

            #endregion

            #region Torneos

            else if (tipo.Equals("tabTorneos"))
            {
                return (lstTorneos.SelectedItems.Count > 0);
            }

            #endregion

            #region Categoria

            else if (tipo.Equals("tabCategorias"))
            {
                return (lstCategorias.SelectedItems.Count > 0);
            }

            #endregion

            #region Tipo

            else if (tipo.Equals("tabTipos"))
            {
                return (lstTipos.SelectedItems.Count > 0);
            }

            #endregion

            return false;
        }

        /// <summary>
        /// Verifica si existe un ítem seleccionado en la grilla secundaria
        /// </summary>
        /// <returns>True si un item fue seleccionado, de lo contrario False</returns>
        private bool IsItemSelected2(string tipo)
        {
            #region Cuotas a pagar

            if (tipo.Equals("chkCuotasAPagar"))
            {
                return (lstCuotasAPagar.SelectedItems.Count > 0);
            }

            #endregion

            #region Cuotas pagadas

            else if (tipo.Equals("chkCuotasPagadas"))
            {
                return (lstCuotasPagadas.SelectedItems.Count > 0);
            }

            #endregion

            #region Inscripciones

            else if (tipo.Equals("btnVerInscripciones"))
            {
                return (lstInscripciones.SelectedItems.Count > 0);
            }

            #endregion

            #region Jugadores

            else if (tipo.Equals("btnVerJugadoresAsociados"))
            {
                return (lstJugAsociados.SelectedItems.Count > 0);
            }

            #endregion

            #region Instituciones con cuotas pendientes de pago

            else if (tipo.Equals("chkDeudasInstituciones"))
            {
                return (lstInstitucionesConDeudas.SelectedItems.Count > 0);
            }

            #endregion

            return false;
        }

        /// <summary>
        /// Agrega una entidad
        /// </summary>
        private void Nuevo(string tipo)
        {
            #region Instituciones

            if (tipo.Equals("Agregar institución"))
            {
                // Creo nueva instancia de formulario "Institución" para dar de alta una institución
                frmInstitucion ofrmInstitucion;
                ofrmInstitucion = new frmInstitucion();

                // Indico la operacion a realizar
                ofrmInstitucion.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmInstitucion.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmInstitucion.Cancelado;

                // Cierro formulario
                ofrmInstitucion.Close();

                // Elimino instancia del formulario
                ofrmInstitucion = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar(ribMenu.SelectedPage.Name);
            }

            #endregion

            #region Jugadores

            else if (tipo.Equals("Agregar jugador"))
            {
                // Creo nueva instancia de formulario "Jugador" para dar de alta un jugador
                frmJugador ofrmJugador;
                ofrmJugador = new frmJugador();

                // Indico la operacion a realizar
                ofrmJugador.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmJugador.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmJugador.Cancelado;

                // Cierro formulario
                ofrmJugador.Close();

                // Elimino instancia del formulario
                ofrmJugador = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar("tabJugadores");
            }

            #endregion

            #region Árbitros

            else if (tipo.Equals("Agregar árbitro"))
            {
                // Creo nueva instancia de formulario "Árbitro" para dar de alta un arbitro
                frmArbitro ofrmArbitro;
                ofrmArbitro = new frmArbitro();

                // Indico la operacion a realizar
                ofrmArbitro.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmArbitro.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmArbitro.Cancelado;

                // Cierro formulario
                ofrmArbitro.Close();

                // Elimino instancia del formulario
                ofrmArbitro = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar(ribMenu.SelectedPage.Name);
            }

            #endregion

            #region Categorías

            else if (tipo.Equals("Agregar categoría"))
            {
                // Creo nueva instancia de formulario "Categoría" para dar de alta una categoría
                frmCategoria ofrmCategoria;
                ofrmCategoria = new frmCategoria();

                // Indico la operacion a realizar
                ofrmCategoria.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmCategoria.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmCategoria.Cancelado;

                // Cierro formulario
                ofrmCategoria.Close();

                // Elimino instancia del formulario
                ofrmCategoria = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar(ribMenu.SelectedPage.Name);
            }

            #endregion

            #region Tipos

            else if (tipo.Equals("Agregar tipo"))
            {
                // Creo nueva instancia de formulario "Tipo" para dar de alta una categoría
                frmTipo ofrmTipo;
                ofrmTipo = new frmTipo();

                // Indico la operacion a realizar
                ofrmTipo.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmTipo.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmTipo.Cancelado;

                // Cierro formulario
                ofrmTipo.Close();

                // Elimino instancia del formulario
                ofrmTipo = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar(ribMenu.SelectedPage.Name);
            }

            #endregion

            #region Cuotas

            else if (tipo.Equals("Agregar cuota"))
            {
                // Creo nueva instancia de formulario "Cuotas" para dar de alta una cuota
                frmCuota ofrmCuota;
                ofrmCuota = new frmCuota();

                // Indico la operacion a realizar
                ofrmCuota.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmCuota.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmCuota.Cancelado;

                // Cierro formulario
                ofrmCuota.Close();

                // Elimino instancia del formulario
                ofrmCuota = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar(ribMenu.SelectedPage.Name);
            }

            #endregion

            #region Torneos

            else if (tipo.Equals("Agregar torneo"))
            {
                // Creo nueva instancia de formulario "Torneos" para dar de alta un torneo
                frmTorneo ofrmTorneo = new frmTorneo();

                // Indico la operacion a realizar
                ofrmTorneo.Operacion = General.TipoOperacion.Alta;

                // Muestro el formulario de manera modal
                ofrmTorneo.ShowDialog();

                // Verifico el resultado de la operacion
                bool resultadoOk = !ofrmTorneo.Cancelado;

                // Cierro formulario
                ofrmTorneo.Close();

                // Elimino instancia del formulario
                ofrmTorneo = null;

                // Si resultado fue satisfactorio recargo la grilla
                if (resultadoOk)
                    Actualizar(ribMenu.SelectedPage.Name);
            }

            #endregion

            #region Cuota Institución

            //Antes de editar verifica que exista algun elemento seleccionado
            else if (tipo.Equals("Registrar pago cuota"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name) && IsItemSelected2("chkCuotasAPagar"))
                {
                    // Creo nueva instancia de formulario
                    frmPagoCuota ofrmPagoCuota = new frmPagoCuota();

                    // Indico el registro utilizar
                    ofrmPagoCuota.IdInstitucion = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);
                    ofrmPagoCuota.FechaCuota = Convert.ToDateTime(lstCuotasAPagar.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmPagoCuota.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmPagoCuota.Cancelado;

                    // Cierro formulario
                    ofrmPagoCuota.Close();

                    // Elimino instancia
                    ofrmPagoCuota = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                    {
                        CargarGrillaSecundaria("chkCuotasAPagar");
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un jugador
                    MessageBox.Show("Seleccione una cuota para registrar su pago.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Inscripción

            //Antes de editar verifica que exista algun elemento seleccionado
            else if (tipo.Equals("Registrar inscripción"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Creo nueva instancia de formulario
                    frmInscripcion ofrmInscripcion = new frmInscripcion();

                    // Indico el registro utilizar
                    ofrmInscripcion.IdTorneo = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmInscripcion.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmInscripcion.Cancelado;

                    // Cierro formulario
                    ofrmInscripcion.Close();

                    // Elimino instancia
                    ofrmInscripcion = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                    {
                        CargarGrillaSecundaria("btnVerInscripciones");
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un jugador
                    MessageBox.Show("Seleccione una torneo para registrar una inscripción.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion
        }

        /// <summary>
        /// Edita una entidad
        /// </summary>
        private void Editar(string tipo)
        {
            #region Instituciones

            if (tipo.Equals("Modificar institución"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Creo nueva instancia de formulario para modificar la institución seleccionado
                    frmInstitucion ofrmInstitucion;
                    ofrmInstitucion = new frmInstitucion();

                    // Indico la operacion a realizar
                    ofrmInstitucion.Operacion = General.TipoOperacion.Edicion;

                    // Indico el registro a actualizar
                    ofrmInstitucion.IdInstitucion = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmInstitucion.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmInstitucion.Cancelado;

                    // Cierro formulario
                    ofrmInstitucion.Close();

                    // Elimino instancia
                    ofrmInstitucion = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                        Actualizar(ribMenu.SelectedPage.Name);
                }
                else
                {
                    // Informo que no se ha seleccionado una Institución
                    MessageBox.Show("Seleccione una institución para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Jugadores

            else if (tipo.Equals("Modificar jugador"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Creo nueva instancia de formulario para modificar el jugador seleccionado
                    frmJugador ofrmJugador;
                    ofrmJugador = new frmJugador();

                    // Indico la operacion a realizar
                    ofrmJugador.Operacion = General.TipoOperacion.Edicion;

                    // Indico el registro a actualizar
                    ofrmJugador.IdJugador = Convert.ToInt32(lstJugadores.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmJugador.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmJugador.Cancelado;

                    // Cierro formulario
                    ofrmJugador.Close();

                    // Elimino instancia
                    ofrmJugador = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                        Actualizar(ribMenu.SelectedPage.Name);
                }
                else
                {
                    // Informo que no se ha seleccionado un jugador
                    MessageBox.Show("Seleccione un jugador para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Árbitros

            else if (tipo.Equals("Modificar árbitro"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Creo nueva instancia de formulario para modificar el árbitro seleccionado
                    frmArbitro ofrmArbitro;
                    ofrmArbitro = new frmArbitro();

                    // Indico la operacion a realizar
                    ofrmArbitro.Operacion = General.TipoOperacion.Edicion;

                    // Indico el registro a actualizar
                    ofrmArbitro.IdArbitro = Convert.ToInt32(lstArbitros.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmArbitro.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmArbitro.Cancelado;

                    // Cierro formulario
                    ofrmArbitro.Close();

                    // Elimino instancia
                    ofrmArbitro = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                        Actualizar(ribMenu.SelectedPage.Name);
                }
                else
                {
                    // Informo que no se ha seleccionado un árbitro
                    MessageBox.Show("Selecciona un árbitro para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Categorías

            else if (tipo.Equals("Modificar categoría"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Creo nueva instancia de formulario para modificar la categoría seleccionado
                    frmCategoria ofrmCategoria;
                    ofrmCategoria = new frmCategoria();

                    // Indico la operacion a realizar
                    ofrmCategoria.Operacion = General.TipoOperacion.Edicion;

                    // Indico el registro a actualizar
                    ofrmCategoria.IdCategoria = Convert.ToInt32(lstCategorias.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmCategoria.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmCategoria.Cancelado;

                    // Cierro formulario
                    ofrmCategoria.Close();

                    // Elimino instancia
                    ofrmCategoria = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                        Actualizar(ribMenu.SelectedPage.Name);
                }
                else
                {
                    // Informo que no se ha seleccionado un árbitro
                    MessageBox.Show("Seleccione una categoría para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Tipos

            else if (tipo.Equals("Modificar tipo"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Creo nueva instancia de formulario para modificar la categoría seleccionado
                    frmTipo ofrmTipo;
                    ofrmTipo = new frmTipo();

                    // Indico la operacion a realizar
                    ofrmTipo.Operacion = General.TipoOperacion.Edicion;

                    // Indico el registro a actualizar
                    ofrmTipo.IdTipo = Convert.ToInt32(lstTipos.SelectedItems[0].Text);

                    // Muestro el formulario de manera modal
                    ofrmTipo.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmTipo.Cancelado;

                    // Cierro formulario
                    ofrmTipo.Close();

                    // Elimino instancia
                    ofrmTipo = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                        Actualizar(ribMenu.SelectedPage.Name);
                }
                else
                {
                    // Informo que no se ha seleccionado un tipo
                    MessageBox.Show("Seleccione un tipo para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Cuotas

            else if (tipo.Equals("Modificar cuota"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    SistemaARA.Entidades.Pagos oPagos = new SistemaARA.Entidades.Pagos();
                    SistemaARA.Negocio.Pagos oPagosNegocio = new SistemaARA.Negocio.Pagos();

                    oPagos = oPagosNegocio.GetOne(Convert.ToDateTime(lstCuotas.SelectedItems[0].Text));

                    if (oPagos.Count > 0)
                    {
                        MessageBox.Show("No se puede modificar la cuota debido a que ya está asignada a un pago.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // Creo nueva instancia de formulario para modificar la cuota seleccionado
                        frmCuota ofrmCuota;
                        ofrmCuota = new frmCuota();

                        // Indico la operacion a realizar
                        ofrmCuota.Operacion = General.TipoOperacion.Edicion;

                        // Indico el registro a actualizar
                        ofrmCuota.Fecha = Convert.ToDateTime(lstCuotas.SelectedItems[0].Text);

                        // Muestro el formulario de manera modal
                        ofrmCuota.ShowDialog();

                        // Verifico el resultado de la operacion
                        bool resultadoOk = !ofrmCuota.Cancelado;

                        // Cierro formulario
                        ofrmCuota.Close();

                        // Elimino instancia
                        ofrmCuota = null;

                        // Si resultado fue exitoso recargo la grilla
                        if (resultadoOk)
                            Actualizar(ribMenu.SelectedPage.Name);
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un árbitro
                    MessageBox.Show("Seleccione una categoría para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Torneos

            else if (tipo.Equals("Modificar torneo"))
            {
                //Antes de editar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    SistemaARA.Entidades.Torneos oTorneos;
                    SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

                    oTorneos = oTorneosNegocio.GetOne(Convert.ToInt32(lstTorneos.SelectedItems[0].Text));

                    if (oTorneos[0].fechaHora < DateTime.Today)
                    {
                        MessageBox.Show("El torneo seleccionado ya se realizó. No puede modificar los datos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // Creo nueva instancia de formulario para modificar el torneo seleccionado
                        frmTorneo ofrmTorneo = new frmTorneo();

                        // Indico la operacion a realizar
                        ofrmTorneo.Operacion = General.TipoOperacion.Edicion;

                        // Indico el registro a actualizar
                        ofrmTorneo.IdTorneo = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

                        // Muestro el formulario de manera modal
                        ofrmTorneo.ShowDialog();

                        // Verifico el resultado de la operacion
                        bool resultadoOk = !ofrmTorneo.Cancelado;

                        // Cierro formulario
                        ofrmTorneo.Close();

                        // Elimino instancia
                        ofrmTorneo = null;

                        // Si resultado fue exitoso recargo la grilla
                        if (resultadoOk)
                            Actualizar(ribMenu.SelectedPage.Name);
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un torneo
                    MessageBox.Show("Seleccione un torneo para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Cuota Institución

            //Antes de editar verifica que exista algun elemento seleccionado
            else if (tipo.Equals("Modificar pago cuota"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name) && IsItemSelected2("chkCuotasPagadas"))
                {
                    // Creo nueva instancia de formulario
                    frmPagoCuota ofrmPagoCuota = new frmPagoCuota();

                    // Indico el registro a actualizar
                    ofrmPagoCuota.IdInstitucion = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);
                    ofrmPagoCuota.FechaCuota = Convert.ToDateTime(lstCuotasPagadas.SelectedItems[0].Text);

                    // Indico la operacion a realizar
                    ofrmPagoCuota.Operacion = General.TipoOperacion.Edicion;

                    // Muestro el formulario de manera modal
                    ofrmPagoCuota.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmPagoCuota.Cancelado;

                    // Cierro formulario
                    ofrmPagoCuota.Close();

                    // Elimino instancia
                    ofrmPagoCuota = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                    {
                        CargarGrillaSecundaria("chkCuotasPagadas");
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una cuota
                    MessageBox.Show("Seleccione una cuota para modificar su pago.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Inscripción

            //Antes de editar verifica que exista algun elemento seleccionado
            else if (tipo.Equals("Modificar inscripción"))
            {
                if (IsItemSelected(ribMenu.SelectedPage.Name) && IsItemSelected2("btnVerInscripciones"))
                {
                    // Creo nueva instancia de formulario
                    frmInscripcion ofrmInscripcion = new frmInscripcion();

                    SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
                    SistemaARA.Entidades.Jugadores oJugador = new SistemaARA.Entidades.Jugadores();

                    // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                    try
                    {
                        if (lstInscripciones.SelectedItems[0].Text == "")
                        {
                            oJugador = oJugadoresNegocio.GetOne(lstInscripciones.SelectedItems[0].SubItems[1].Text);
                        }
                        else
                        {
                            oJugador = oJugadoresNegocio.GetOneNroDoc(lstInscripciones.SelectedItems[0].Text);
                        }

                        ofrmInscripcion.IdJugador = oJugador[0].idJugador;
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error que ocurra
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Elimino objetos de memoria
                        oJugadoresNegocio = null;
                    }

                    // Indico el registro utilizar
                    ofrmInscripcion.IdTorneo = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

                    // Indico la operacion a realizar
                    ofrmInscripcion.Operacion = General.TipoOperacion.Edicion;

                    // Muestro el formulario de manera modal
                    ofrmInscripcion.ShowDialog();

                    // Verifico el resultado de la operacion
                    bool resultadoOk = !ofrmInscripcion.Cancelado;

                    // Cierro formulario
                    ofrmInscripcion.Close();

                    // Elimino instancia
                    ofrmInscripcion = null;

                    // Si resultado fue exitoso recargo la grilla
                    if (resultadoOk)
                    {
                        CargarGrillaSecundaria("btnVerInscripciones");
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un jugador
                    MessageBox.Show("Seleccione una inscripción para modificar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion
        }

        /// <summary>
        /// Elimina una entidad
        /// </summary>
        private void Eliminar(string tipo)
        {
            string mensaje;

            #region Instituciones

            if (tipo.Equals("Eliminar institución"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación de la institución seleccionada?";

                    // Pregunto, si la respuesta es SI elimino la institución seleccionada
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();
                        int Id;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            // Obtengo el Id de la institución a eliminar
                            // Es el primero de la coleccion de seleccionados
                            Id = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);

                            // Elimino la institución
                            oInstitucionesNegocio.Delete(Id);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación de la institución realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla.
                            Actualizar(ribMenu.SelectedPage.Name);
                            Actualizar("tabJugadores");
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oInstitucionesNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una institución
                    mensaje = "Seleccione una institución para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion
                
            #region Jugadores

            else if (tipo.Equals("Eliminar jugador"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación del jugador seleccionado?";
                    mensaje += Environment.NewLine;
                    mensaje += "Se borrarán las inscripciones a torneos actuales.";

                    // Pregunto, si la respuesta es SI elimino el jugador seleccionado
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                        SistemaARA.Entidades.Inscripciones oInscripciones = new SistemaARA.Entidades.Inscripciones();
                        SistemaARA.Negocio.Inscripciones oInscripcionesNegocio = new SistemaARA.Negocio.Inscripciones();

                        SistemaARA.Entidades.Torneos oTorneos = new SistemaARA.Entidades.Torneos();
                        SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

                        int Id;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            //borramos las inscripciones actuales
                            oInscripciones = oInscripcionesNegocio.GetAllInscripciones(Convert.ToInt32(lstJugadores.SelectedItems[0].Text));

                            if (oInscripciones.Count > 0)
                            {
                                foreach (SistemaARA.Entidades.Inscripcion Inscripcion in oInscripciones)
                                {
                                    oTorneos = oTorneosNegocio.GetOne(Inscripcion.idTorneo);

                                    if (oTorneos[0].fechaHora > DateTime.Today)
                                    {
                                        oInscripcionesNegocio.Delete(Convert.ToInt32(lstJugadores.SelectedItems[0].Text), oTorneos[0].idTorneo);
                                    }
                                }
                            }

                            // Obtengo el Id del jugador a eliminar
                            // Es el primero de la coleccion de seleccionados
                            Id = Convert.ToInt32(lstJugadores.SelectedItems[0].Text);

                            // Elimino el jugador
                            oJugadoresNegocio.Delete(Id);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación del jugador realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla. Algún otro usuario puede haber agregado más jugadores
                            Actualizar(ribMenu.SelectedPage.Name);
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oJugadoresNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un jugador
                    mensaje = "Seleccione un jugador para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Árbitros

            else if (tipo.Equals("Eliminar árbitro"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación del árbitro seleccionado?";
                    mensaje += Environment.NewLine;
                    mensaje += "Se perderán los datos asociados al mismo.";

                    // Pregunto, si la respuesta es SI elimino el árbitro seleccionado
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                        SistemaARA.Entidades.Torneos oTorneos = new SistemaARA.Entidades.Torneos();
                        SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

                        int Id;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            oTorneos = oTorneosNegocio.GetAll();

                            foreach (SistemaARA.Entidades.Torneo Torneo in oTorneos)
                            {
                                if (Torneo.fechaHora > DateTime.Today)
                                {
                                    Torneo.idArbitro = 0;

                                    oTorneosNegocio.Update(Torneo);
                                }
                            }

                            // Obtengo el Id del árbitro a eliminar
                            // Es el primero de la coleccion de seleccionados
                            Id = Convert.ToInt32(lstArbitros.SelectedItems[0].Text);

                            // Elimino el árbitro
                            oArbitrosNegocio.Delete(Id);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación del árbitro realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla. Algún otro usuario puede haber agregado más árbitros
                            Actualizar(ribMenu.SelectedPage.Name);
                            Actualizar("tabTorneos");
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oArbitrosNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado un árbitro
                    mensaje = "Seleccione un árbitro para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Categorías

            else if (tipo.Equals("Eliminar categoría"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación de la categoría seleccionada?";
                    mensaje += Environment.NewLine;
                    mensaje += "Los árbitros asociados a esta categoría quedarán sin categoría establecida.";

                    // Pregunto, si la respuesta es SI elimino la categoría seleccionada
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();
                        
                        SistemaARA.Entidades.Arbitros oArbitros = new SistemaARA.Entidades.Arbitros();
                        SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                        int Id;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            // Obtengo el Id de la categoría a eliminar
                            // Es el primero de la coleccion de seleccionados
                            Id = Convert.ToInt32(lstCategorias.SelectedItems[0].Text);

                            oArbitros = oArbitrosNegocio.GetAll();

                            if (oArbitros.Count() > 0)
                            {
                                foreach (SistemaARA.Entidades.Arbitro oArbitro in oArbitros)
                                {
                                    if (oArbitro.idCategoria == Id)
                                    {
                                        oArbitro.idCategoria = 0;

                                        oArbitrosNegocio.Update(oArbitro);
                                    }
                                }
                            }

                            // Elimino la categoría
                            oCategoriasNegocio.Delete(Id);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación de la categoría realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla. Algún otro usuario puede haber agregado más categorías
                            Actualizar(ribMenu.SelectedPage.Name);
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oCategoriasNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una categoría
                    mensaje = "Seleccione una categoría para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Tipos

            else if (tipo.Equals("Eliminar tipo"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación del tipo de torneo seleccionado?";

                    // Pregunto, si la respuesta es SI elimino la categoría seleccionada
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();
                        int Id;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            // Obtengo el Id de la categoría a eliminar
                            // Es el primero de la coleccion de seleccionados
                            Id = Convert.ToInt32(lstTipos.SelectedItems[0].Text);

                            // Elimino la categoría
                            oTiposNegocio.Delete(Id);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación del tipo realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla. Algún otro usuario puede haber agregado más tipos
                            Actualizar(ribMenu.SelectedPage.Name);
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oTiposNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una categoría
                    mensaje = "Seleccione un tipo para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Cuotas

            else if (tipo.Equals("Eliminar cuota"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación de la cuota seleccionada?";

                    // Pregunto, si la respuesta es SI elimino la categoría seleccionada
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();
                        DateTime fec;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            // Obtengo el Id de la categoría a eliminar
                            // Es el primero de la coleccion de seleccionados
                            fec = Convert.ToDateTime(lstCuotas.SelectedItems[0].Text);

                            // Elimino la categoría
                            oCuotasNegocio.Delete(fec);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación de la cuota realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla. Algún otro usuario puede haber agregado más categorías
                            Actualizar(ribMenu.SelectedPage.Name);
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oCuotasNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una categoría
                    mensaje = "Seleccione una cuota para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Torneos

            else if (tipo.Equals("Eliminar torneo"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name))
                {
                    SistemaARA.Entidades.Torneos oTorneos;
                    SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

                    oTorneos = oTorneosNegocio.GetOne(Convert.ToInt32(lstTorneos.SelectedItems[0].Text));

                    if (oTorneos[0].fechaHora < DateTime.Today)
                    {
                        MessageBox.Show("El torneo seleccionado ya se realizó. No se puede eliminar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // Antes de eliminar siempre le preguntamos al usuario
                        mensaje = "¿Confirma la eliminación del torneo seleccionado?";

                        // Pregunto, si la respuesta es SI elimino el torneo seleccionado
                        if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                        {
                            // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                            try
                            {
                                // Obtengo el Id de la categoría a eliminar
                                // Es el primero de la coleccion de seleccionados
                                int Id = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

                                // Elimino la categoría
                                oTorneosNegocio.Delete(Id);

                                // Informo al usuario que la eliminación se realizó correctamente
                                mensaje = "Eliminación del torneo realizada con éxito.";
                                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Recargo la grilla. Algún otro usuario puede haber agregado más categorías
                                Actualizar(ribMenu.SelectedPage.Name);
                            }
                            catch (Exception ex)
                            {
                                // Muestro cualquier error que ocurra
                                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                // Elimino objetos de memoria
                                oTorneosNegocio = null;
                            }
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una categoría
                    mensaje = "Seleccione una cuota para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Cuota institución

            else if (tipo.Equals("Eliminar pago cuota"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name) && IsItemSelected2("chkCuotasPagadas"))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación del pago de la cuota seleccionada?";

                    // Pregunto, si la respuesta es SI elimino la categoría seleccionada
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Pagos oPagosNegocio = new SistemaARA.Negocio.Pagos();

                        DateTime fec;

                        int idIns;

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            // Obtengo la fecha del pago de cuota a eliminar
                            // Es el primero de la coleccion de seleccionados
                            fec = Convert.ToDateTime(lstCuotasPagadas.SelectedItems[0].Text);

                            idIns = Convert.ToInt32(lstInstituciones.SelectedItems[0].Text);

                            // Elimino el pago de la cuota
                            oPagosNegocio.Delete(idIns, fec);

                            // Informo al usuario que la eliminación se realizó correctamente
                            mensaje = "Eliminación del pago de la cuota realizada con éxito.";
                            MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargo la grilla. Algún otro usuario puede haber agregado más categorías
                            CargarGrillaSecundaria("chkCuotasPagadas");
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oPagosNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una categoría
                    mensaje = "Seleccione un pago de cuota para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Inscripción

            else if (tipo.Equals("Eliminar inscripción"))
            {
                // Antes de eliminar verifica que exista algun elemento seleccionado
                if (IsItemSelected(ribMenu.SelectedPage.Name) && IsItemSelected2("btnVerInscripciones"))
                {
                    // Antes de eliminar siempre le preguntamos al usuario
                    mensaje = "¿Confirma la eliminación de la inscripción seleccionada?";

                    // Pregunto, si la respuesta es SI elimino la categoría seleccionada
                    if (MessageBox.Show(mensaje, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Para eliminar necesito delegar el trabajo a la capa de negocios
                        SistemaARA.Negocio.Inscripciones oInscripcionesNegocio = new SistemaARA.Negocio.Inscripciones();

                        int idTorneo;
                        int idJugador;

                        SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();
                        SistemaARA.Entidades.Jugadores oJugador = new SistemaARA.Entidades.Jugadores();

                        // Al intentar eliminar, puede ocurrir un error por lo tanto debo capturarlo
                        try
                        {
                            // Indico el registro a eliminar
                            idTorneo = Convert.ToInt32(lstTorneos.SelectedItems[0].Text);

                            SistemaARA.Entidades.Torneos oTorneos;
                            SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

                            oTorneos = oTorneosNegocio.GetOne(idTorneo);

                            if (oTorneos[0].fechaHora < DateTime.Today)
                            {
                                MessageBox.Show("El torneo seleccionado ya se realizó. No se puede eliminar la inscripción.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                if (lstInscripciones.SelectedItems[0].Text == "")
                                {
                                    oJugador = oJugadoresNegocio.GetOne(lstInscripciones.SelectedItems[0].SubItems[1].Text);
                                }
                                else
                                {
                                    oJugador = oJugadoresNegocio.GetOneNroDoc(lstInscripciones.SelectedItems[0].Text);
                                }

                                idJugador = oJugador[0].idJugador;

                                // Elimino el pago de la cuota
                                oInscripcionesNegocio.Delete(idJugador, idTorneo);

                                // Informo al usuario que la eliminación se realizó correctamente
                                mensaje = "Eliminación de la inscripción realizada con éxito.";
                                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Recargo la grilla.
                                CargarGrillaSecundaria("btnVerInscripciones");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Muestro cualquier error que ocurra
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Elimino objetos de memoria
                            oInscripcionesNegocio = null;
                        }
                    }
                }
                else
                {
                    // Informo que no se ha seleccionado una inscripción
                    mensaje = "Seleccione una inscripción para eliminar.";
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion
        }

        /// <summary>
        /// Actualiza la grilla
        /// </summary>
        private void Actualizar(string tipo)
        {
            #region Instituciones

            if (tipo.Equals("tabInstituciones"))
            {
                beiBuscarRazonSocial.EditValue = "";
                beiCuit.EditValue = "";

                // Obtener instituciones desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Instituciones oInstituciones;
                SistemaARA.Negocio.Instituciones oInstitucionesNegocio = new SistemaARA.Negocio.Instituciones();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las instituciones existentes
                    oInstituciones = oInstitucionesNegocio.GetAll();

                    CargarGrilla(oInstituciones);

                    ActualizarEstadoBotones();
                    ActualizarEstadoBotones2();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oInstituciones = null;
                    oInstitucionesNegocio = null;
                }
            }

            #endregion

            #region Jugadores

            else if (tipo.Equals("tabJugadores"))
            {
                beiBuscarJugApNom.EditValue = "";
                beiBuscarJugNroDoc.EditValue = "";

                // Obtener jugadores desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Jugadores oJugadores;
                SistemaARA.Negocio.Jugadores oJugadoresNegocio = new SistemaARA.Negocio.Jugadores();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios los jugadores existentes
                    oJugadores = oJugadoresNegocio.GetAll();

                    CargarGrilla(oJugadores);

                    ActualizarEstadoBotones();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oJugadores = null;
                    oJugadoresNegocio = null;
                }
            }

            #endregion

            #region Arbitros

            else if (tipo.Equals("tabArbitros"))
            {
                beiBuscarArbApNom.EditValue = "";
                beiBuscarArbNroDoc.EditValue = "";

                // Obtener árbitros desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Arbitros oArbitros;
                SistemaARA.Negocio.Arbitros oArbitrosNegocio = new SistemaARA.Negocio.Arbitros();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios los árbitros existentes
                    oArbitros = oArbitrosNegocio.GetAll();

                    CargarGrilla(oArbitros);

                    ActualizarEstadoBotones();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oArbitros = null;
                    oArbitrosNegocio = null;
                }
            }

            #endregion

            #region Cuotas

            else if (tipo.Equals("tabCuotas"))
            {
                // Obtener cuotas desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Cuotas oCuotas;
                SistemaARA.Negocio.Cuotas oCuotasNegocio = new SistemaARA.Negocio.Cuotas();

                DevExpress.XtraBars.BarItemLinkCollection links = cmbCuotasAño.ItemLinks;

                string año = "";

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    foreach (DevExpress.XtraBars.BarCheckItemLink item in links)
                    {
                        if (item.Item.Down)
                        {
                            año = item.Caption;
                            break;
                        }
                    }

                    if (año == "Todos")
                    {
                        oCuotas = oCuotasNegocio.GetAll();
                    }
                    else
                    {
                        // Le pido a la capa de negocios las caregorías existentes
                        oCuotas = oCuotasNegocio.GetCuotasAño(año);
                    }

                    CargarGrilla(oCuotas);

                    ActualizarEstadoBotones();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oCuotas = null;
                    oCuotasNegocio = null;
                }
            }

            #endregion

            #region Torneos

            else if (tipo.Equals("tabTorneos"))
            {
                // Obtener árbitros desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Torneos oTorneos;
                SistemaARA.Negocio.Torneos oTorneosNegocio = new SistemaARA.Negocio.Torneos();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios los árbitros existentes
                    oTorneos = oTorneosNegocio.GetAll();

                    CargarGrilla(oTorneos);

                    ActualizarEstadoBotones();
                    ActualizarEstadoBotones2();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oTorneos = null;
                    oTorneosNegocio = null;
                }
            }

            #endregion

            #region Categoria

            else if (tipo.Equals("tabCategorias"))
            {
                // Obtener categorías desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Categorias oCategorias;
                SistemaARA.Negocio.Categorias oCategoriasNegocio = new SistemaARA.Negocio.Categorias();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios las caregorías existentes
                    oCategorias = oCategoriasNegocio.GetAll();

                    CargarGrilla(oCategorias);

                    ActualizarEstadoBotones();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oCategorias = null;
                    oCategoriasNegocio = null;
                }
            }

            #endregion

            #region Tipo

            else if (tipo.Equals("tabTipos"))
            {
                // Obtener tipos desde la base de datos.
                // Siempre retorna una coleccion de objetos.
                SistemaARA.Entidades.Tipos oTipos;
                SistemaARA.Negocio.Tipos oTiposNegocio = new SistemaARA.Negocio.Tipos();

                // Estoy en la interfaz de usuario
                // Capturar siempre el error si ocurre
                try
                {
                    // Le pido a la capa de negocios los tipos existentes
                    oTipos = oTiposNegocio.GetAll();

                    CargarGrilla(oTipos);

                    ActualizarEstadoBotones();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error que ocurra
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Libero memoria de objetos
                    oTipos = null;
                    oTiposNegocio = null;
                }
            }

            #endregion
        }

        #endregion
    }
}
