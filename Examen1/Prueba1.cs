namespace Examen1
{
    public partial class Prueba1 : Form
    {
        PromedioProgrmacion objP = new();
        public Prueba1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            objP.NOTA1 = double.Parse(txte1.Text);
            objP.NOTA2 = double.Parse(txte2.Text);
            objP.NOTA3 = double.Parse(txte3.Text);
            objP.Name = txtNombre.Text;
            objP.ACTITUDINAL = double.Parse(txteActitudinal.Text);

            ListViewItem fila = new ListViewItem();
            fila.SubItems.Add(objP.Name);
            fila.SubItems.Add(objP.NOTA1.ToString("0.00"));
            fila.SubItems.Add(objP.NOTA2.ToString("0.00"));
            fila.SubItems.Add(objP.NOTA3.ToString("0.00"));
            fila.SubItems.Add(objP.ACTITUDINAL.ToString("0.00"));
            fila.SubItems.Add(objP.Calcularpromedio().ToString("0.00"));
            fila.SubItems.Add(condicion());
            lvProm.Items.Add(fila);

            //lo comentado es parte del codigo q no termine pro falta de tiempo no lo tome en cuenta
            //List<ListViewItem> list = new List<ListViewItem>();
            //list.Add(promedio());
            //list.Add(cantidadAprobados.ToString());
            //list.Add(cantidaREprobados.ToString());
            //lvProm.Items.Add(list);
        }

        public String condicion()
        {

            if (objP.Calcularpromedio() > 50)
                return "APROBADO";
            else return "REPROBADO";         
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txte1.Clear();
            txte2.Clear();  
            txte3.Clear();
            txteActitudinal.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }
        public String promedio()
        {
            double Suma = 0;
            for (int i = 0; i < lvProm.Items.Count; i++)
            {
                Suma += int.Parse(lvProm.Items[i].SubItems[5].Text);
            }
            return Suma.ToString();
        }
        //public int cantidadAprobados()
        //{
        //    int n = 0;
        //    for (int i = 0; i < lvProm.Items.Count; i++)
        //    {
        //        if (lvProm.Items[i].SubItems[6].Text = "APROBADO") ;
        //        {
        //           n++;
        //        }
        //    }
        //    return n;

        //}
        //public int cantidadREprobados()
        //{
        //    int m = 0;
        //    for (int i = 0; i < lvProm.Items.Count; i++)
        //    {
        //        if (lvProm.Items[i].SubItems[6].Text = "REPROBADO") ;
        //        {
        //            m++;
        //        }
        //    }
        //    return m;
        //}

        
    }
}