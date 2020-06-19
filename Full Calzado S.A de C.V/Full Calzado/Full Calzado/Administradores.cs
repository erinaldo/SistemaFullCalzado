﻿/*      
 *  ´´  ´´          ´´      ´´          ´´      ´´      ´´          ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´   ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´              ´´              ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´      ´´      ´´        ´´              ´´
 *  
 *     @@@@@@   @@    @@   @@        @@         @@@@@@@  @@@@@@@@  @@       @@@@@@@  @@@@@@@@  @@@@@@       @@@@@@@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@           @@   @@    @@  @@   @@     @@     @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@          @@    @@    @@  @@    @@   @@       @@
 *     @@@@@@   @@    @@   @@        @@         @@       @@@@@@@@  @@         @@     @@@@@@@@  @@     @@  @@       @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@        @@      @@    @@  @@     @@   @@     @@
 *     @@       @@    @@   @@        @@         @@       @@    @@  @@       @@       @@    @@  @@    @@     @@   @@
 *     @@       @@@@@@@@   @@@@@@@   @@@@@@     @@@@@@@  @@    @@  @@@@@@  @@@@@@    @@    @@  @@@@@@@       @@@@@
 *     
 *     ´´  ´´          ´´      ´´          ´´      ´´      ´´          ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´   ´´      ´´          ´´      ´´      ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´              ´´              ´´
 *   ´´   ´´    ´´         ´´      ´´       ´´      ´´      ´´      ´´              ´´            ´´      ´´ 
 *   ------------------------------------------------------------------------
 *   PROYECTO COMPARTIDO Y LIBERADO CON FINES EDUCATIVOS
 *   https://github.com/DanielRivera03
 *   ------------------------------------------------------------------------
 *  ----> VERSION 1.0 FINAL ESTABLE <----  
 *  --------------------------------------------------------------------------
 *  |                       FULL CALZADO S.A DE C.V                          |
 *  --------------------------------------------------------------------------
 *  |  DESARROLLADORES DEL SISTEMA {4}                                       |
 *  --------------------------------------------------------------------------
 *  | -> DANIEL RIVERA           || ENCARGADO DISEÑO BASE SISTEMA, ESTANDARES|
 *  |                            || INICIALES DE APLICACION, CREACION LOGIN, |
 *  |                            || MANTENIMIENTO COMPLETO DE USUARIOS, ROLES|
 *  |                            || DE USUARIOS, TODAS LAS INTERFACES {BASE} | 
 *  --------------------------------------------------------------------------                                  
 *  | -> FERNANDO SANCHEZ        || ENCARGADO GESTION PRODUCTOS SISTEMA,TODOS|
 *  |                            || LOS ROLES, CONFIGURACIONES DE TODOS LOS  |
 *  |                            || REPORTES DEL SISTEMA                     |
 *  --------------------------------------------------------------------------                                        
 *  | -> CHRISTIAN MONGE         || ENCARGADO DE FACTURACION DE PRODUCTOS,   |
 *  |                            || TODOS LOS ROLES DEL SISTEMA, Y REPORTES  |
 *  |                            || EN RELACION A ESTA OPCION DE MENU        |
 *  --------------------------------------------------------------------------                                      
 *  | -> KARLA NAVAS             || ENCARGADA DE GESTION DE EMPLEADOS DEL    |
 *  |                            || SISTEMA, Y REPORTES EN RELACION A ESTA   |
 *  |                            || OPCION DE MENU                           |            
 *  --------------------------------------------------------------------------
 *  |                        FULL CALZADO S.A DE C.V                         |
 *  --------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// IMPORTANDO LIBRERIA QUE HABILITA EL EVENTO DE ARRASTRES DE FORMULARIOS POR PARTE DE LOS USUARIOS
using System.Runtime.InteropServices;

namespace Full_Calzado
{
    public partial class Administradores : Form
    {

        /*********************************************************************************************
        * HABILITANDO EL ARRASTRE DEL FORMULARIO A X POSICION EN PANTALLA POR PARTE DEL USUARIO
        * --> CODIGO DE INICIALIZACION DEL EVENTO
        *********************************************************************************************/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // FIN INICIALIZACION DE EVENTO ARRASTRE DE FORMULARIOS

        // INSTANCIA LLAMADA NOTIFICACIONES PESONALIZADAS
        NotificacionesPersonalizadas Llamada = new NotificacionesPersonalizadas();


        public Administradores(string nombre)
        {
            InitializeComponent();
            ControlHoraSistema.Enabled = true; // VALIDA EVENTO MUESTRA HORA/FECHA ACTUAL
            lbNombreUsuario.Text = nombre; // DEVUELVE NOMBRE DE USUARIO REGISTRADO
            // INVOCANDO FORMULARIO DE BIENVENIDA PARA USUARIOS ADMINISTRADORES
            MostrarFormularios(new InicioInterfazAdmins());
        }

        /*
            --> EVENTO DE ARRASTRE FORMULARIO PADRE
                SIN INCLUIR ELEMENTOS HIJOS 
        */

        private void Administradores_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
            --> CONTROLADOR TIMER HORA SISTEMA ACTUAL 
        */

        private void ControlHoraSistema_Tick(object sender, EventArgs e)
        {
            HoraSistema.Text = DateTime.Now.ToString(); 
        }

        /*
            --> MINIMIZAR VENTANA {FORMULARIO} 
        */

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            --> MAXIMIZAR VENTANA {FORMULARIO} 
        */

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) {
                this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
                this.WindowState = FormWindowState.Normal;
            }
        }

        /*
            --> CERRAR VENTANA {FORMULARIO / APLICACION} 
        */

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // CIERRE DIRECTO DE APLICACION, CON DESCONEXION INCLUIDA DE BASE DE DATOS
        }

        /*
            --> CREANDO FUNCION CON OBJETO DE PARAMETRO, QUE SE ENCARGARA DE MANEJAR DE 
                ABRIR TODOS LOS FORMULARIOS {SUBPROCESOS DEL SISTEMA} AL FORMULARIO PRINCIPAL
                MOSTRADO AL CLIENTE. 
        */
        private void MostrarFormularios(object MostrandoSubFormularios)
        {
            // SI EL FORMULARIO PRESENTA CONTROLES POR DEFECTO, OJO NO CREADOS EXTERNAMENTE
            // ESTE LOS ELIMINARA...
            if (this.PanelContenedorInterfaces.Controls.Count > 0)
                this.PanelContenedorInterfaces.Controls.RemoveAt(0);
            // CREANDO INSTANCIA PARA MOSTRAR SUBFORMULARIOS DEL SISTEMA
            Form FormulariosSistema = MostrandoSubFormularios as Form;
            FormulariosSistema.TopLevel = false; // FORMUNARIOS DE NO ALTO NIVEL {TIPO SECUNDARIOS A MOSTRAR}
            FormulariosSistema.Dock = DockStyle.Fill; // RELLENAR FORMULARIO AL ANCHO TOTAL DEL PANEL CONTENEDOR
            this.PanelContenedorInterfaces.Controls.Add(FormulariosSistema); // MOSTRAR TODOS LOS ELEMENTOS DEL FORMULARIO
            this.PanelContenedorInterfaces.Tag = FormulariosSistema; // DECLARANDO INSTANCIA AL PANEL CONTENEDOR
            FormulariosSistema.Show(); // MOSTRAR EL X FORMULARIO A TRATAR EN EL SISTEMA
            /*
                --> IMPORTANTE: MEDIDA ESTANDAR DE CONTENEDOR PRICIPAL CONTENEDOR ES:
                    1015; 631 ¡NO SOBREPASAR ESTA MEDIDA CASO CONTRARIO CONTROLES NO SE MOSTRARAN EN PANTALLA!
            */
        }

        private void ContenedorSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogoIMG_MouseDown(object sender, MouseEventArgs e)
        {
            // HABILITANDO FUNCION DE ARRASTRE DE FORMULARIO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // << BOTONES DE INTERFAZ ADMINISTRADORES >> \\
    

        /*
            --> BOTON OPCION {USUARIOS} 
        */


        private void btnUsuariosSistema_Click(object sender, EventArgs e)
        {
            // INVOCANDO FUNCION Y MOSTRANDO EXCLUSIVAMENTE FORMULARIO DE USUARIOS DEL SISTEMA
            MostrarFormularios(new UsuariosRegistradosSistema());
            /*
                --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO
             */
            btnUsuariosSistema.BackColor = Color.DarkSlateBlue;  // ESTADO ACTIVO   
            btnUsuariosSistema.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO
            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnEmpleadosFC.BackColor = Color.Khaki;
            btnProductosFCSistema.BackColor = Color.Khaki;
            btnFacturacionesFC.BackColor = Color.Khaki;
            btnCerrarSesiones.BackColor = Color.Khaki;
            // ESTADO INACTIVO ↓ {TODOS} -> TEXTO
            btnEmpleadosFC.ForeColor = Color.Black;
            btnProductosFCSistema.ForeColor = Color.Black;
            btnFacturacionesFC.ForeColor = Color.Black;
        }

        /*
            --> BOTON OPCION {EMPLEADOS} 
        */

        private void btnEmpleadosFC_Click(object sender, EventArgs e)
        {
            // INVOCANDO FUNCION Y MOSTRANDO EXCLUSIVAMENTE FORMULARIO DE USUARIOS DEL SISTEMA
            MostrarFormularios(new EmpleadosSistemaAdmin());
            /*
                --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO
             */
            btnEmpleadosFC.BackColor = Color.DarkSlateBlue;  // ESTADO ACTIVO   
            btnEmpleadosFC.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO
            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnUsuariosSistema.BackColor = Color.Khaki;
            btnProductosFCSistema.BackColor = Color.Khaki;
            btnFacturacionesFC.BackColor = Color.Khaki;
            btnCerrarSesiones.BackColor = Color.Khaki;
            // ESTADO INACTIVO ↓ {TODOS} -> TEXTO
            btnUsuariosSistema.ForeColor = Color.Black;
            btnProductosFCSistema.ForeColor = Color.Black;
            btnFacturacionesFC.ForeColor = Color.Black;
            btnCerrarSesiones.ForeColor = Color.Black;
        }

        /*
            --> BOTON OPCION {PRODUCTOS} 
        */

        private void btnProductosFCSistema_Click(object sender, EventArgs e)
        {
            // INVOCANDO FUNCION Y MOSTRANDO EXCLUSIVAMENTE FORMULARIO DE USUARIOS DEL SISTEMA
            MostrarFormularios(new ProductosRegistradosAdmin());
            /*
                 --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO
              */
            btnProductosFCSistema.BackColor = Color.DarkSlateBlue;  // ESTADO ACTIVO   
            btnProductosFCSistema.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO
            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnUsuariosSistema.BackColor = Color.Khaki;
            btnEmpleadosFC.BackColor = Color.Khaki;
            btnFacturacionesFC.BackColor = Color.Khaki;
            btnCerrarSesiones.BackColor = Color.Khaki;
            // ESTADO INACTIVO ↓ {TODOS} -> TEXTO
            btnUsuariosSistema.ForeColor = Color.Black;
            btnEmpleadosFC.ForeColor = Color.Black;
            btnFacturacionesFC.ForeColor = Color.Black;
            btnCerrarSesiones.ForeColor = Color.Black;
        }

        /*
            --> BOTON OPCION {FACTURACIONES} 
        */

        private void btnFacturacionesFC_Click(object sender, EventArgs e)
        {
            // INVOCANDO FUNCION Y MOSTRANDO EXCLUSIVAMENTE FORMULARIO DE USUARIOS DEL SISTEMA
            MostrarFormularios(new FacturacionFullCalzado());
            /*
                 --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO
            */
            btnFacturacionesFC.BackColor = Color.DarkSlateBlue;  // ESTADO ACTIVO   
            btnFacturacionesFC.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO
            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnUsuariosSistema.BackColor = Color.Khaki;
            btnEmpleadosFC.BackColor = Color.Khaki;
            btnProductosFCSistema.BackColor = Color.Khaki;
            btnCerrarSesiones.BackColor = Color.Khaki;
            // ESTADO INACTIVO ↓ {TODOS} -> TEXTO
            btnUsuariosSistema.ForeColor = Color.Black;
            btnEmpleadosFC.ForeColor = Color.Black;
            btnProductosFCSistema.ForeColor = Color.Black;
            btnCerrarSesiones.ForeColor = Color.Black;
        }

        /*
            --> BOTON OPCION {CERRAR SESION} 
        */

        private void btnCerrarSesiones_Click(object sender, EventArgs e)
        {
            /*
                 --> ESTILOS HOVER PARA BOTONES Y TEXTO ACTIVO / INACTIVO
            */
            btnCerrarSesiones.BackColor = Color.DarkSlateBlue;  // ESTADO ACTIVO   
            btnCerrarSesiones.ForeColor = Color.WhiteSmoke; // ESTADO ACTIVO
            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnUsuariosSistema.BackColor = Color.Khaki;
            btnEmpleadosFC.BackColor = Color.Khaki;
            btnProductosFCSistema.BackColor = Color.Khaki;
            btnFacturacionesFC.BackColor = Color.Khaki;
            // ESTADO INACTIVO ↓ {TODOS} -> TEXTO
            btnUsuariosSistema.ForeColor = Color.Black;
            btnEmpleadosFC.ForeColor = Color.Black;
            btnProductosFCSistema.ForeColor = Color.Black;
            btnFacturacionesFC.ForeColor = Color.Black;
            DialogResult resultado = new DialogResult();
            // MOSTRANDO VENTANA EMERGENTE DE CIERRE DE SESION {PREGUNTA ACCIONES}
            Form mensaje = new MensajeCierreSesion();
            resultado = mensaje.ShowDialog();
            // LLAMADA DE NOTIFICACION PERSONALIZADA DE PREGUNTA
            Llamada.NotificionIncognita();
            MensajeCierreSesion Consulta = new MensajeCierreSesion();
            /*
                --> COMPROBACION CIERRE DE SESION...
                        DISPONIBILIDAD DE CANCELAR EVENTO 
            */
            if (resultado == DialogResult.OK)
            {
                // SI CIERRA SESION, ENTONCES...
                this.Close();// CIERRE COMPLETO UNICAMENTE DE LA BASE DE DATOS --> {USUARIO DADO DE ALTA EN ESE MOMENTO}
                this.Hide();// OCULTA PANEL DE ADMINISTRACION PARA CERRAR SESION
                Form cerrandosesion = new LoginUsuarios();
                cerrandosesion.ShowDialog();// MUESTRA NUEVAMENTE VENTANA DE LOGIN
            }
            // SI SE CANCELA CIERRE DE SESION, RESETEAR COLORES ACTIVOS
            if (resultado == DialogResult.Cancel)
            {
                btnCerrarSesiones.BackColor = Color.Khaki;    // BOTON
                btnCerrarSesiones.ForeColor = Color.Black;    // TEXTO
            }
        }

        /*
            RETORNO INICIO DE APLICACION 
        */
        
        private void IconHome_Click(object sender, EventArgs e)
        {
            // INVOCAR INICIO DE APLICACION Y RESETEAR ESTADO DE BOTONES OPCIONES DEL MENU
            MostrarFormularios(new InicioInterfazAdmins());
            // ESTADO INACTIVO ↓ {TODOS} -> BOTONES
            btnCerrarSesiones.BackColor = Color.Khaki;
            btnUsuariosSistema.BackColor = Color.Khaki;
            btnEmpleadosFC.BackColor = Color.Khaki;
            btnProductosFCSistema.BackColor = Color.Khaki;
            btnFacturacionesFC.BackColor = Color.Khaki;
            // ESTADO INACTIVO ↓ {TODOS} -> TEXTO
            btnCerrarSesiones.ForeColor = Color.Black;
            btnUsuariosSistema.ForeColor = Color.Black;
            btnEmpleadosFC.ForeColor = Color.Black;
            btnProductosFCSistema.ForeColor = Color.Black;
            btnFacturacionesFC.ForeColor = Color.Black;
        }
    }
}
