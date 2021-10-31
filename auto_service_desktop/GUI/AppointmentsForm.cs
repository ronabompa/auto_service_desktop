using ServiceAutoDESKTOP.BL;
using ServiceAutoDESKTOP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAutoDESKTOP.GUI
{
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

		// METHOD TO PUT LIST INTO DATATABLE
		public DataTable ToDataTable<T>(IList<T> list)
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			for (int i = 0; i < props.Count; i++)
			{
				PropertyDescriptor prop = props[i];
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			}
			object[] values = new object[props.Count];
			foreach (T item in list)
			{
				for (int i = 0; i < values.Length; i++)
					values[i] = props[i].GetValue(item) ?? DBNull.Value;
				table.Rows.Add(values);
			}
			return table;
		}

		// ---- BUTTONS ---- //
		private void showButton_Click(object sender, EventArgs e)
        {
			AppointmentService appointmentService = new AppointmentService();
			List<Appointment> appointmentList = appointmentService.getAllAppointments();

			DataTable table = ToDataTable(appointmentList);
			dataGridView1.DataSource = table;
		}

		private void logOutGoodButton_Click(object sender, EventArgs e)
        {
			LoginForm.getInstance().Show();
			this.Hide();
		}

	}
}
