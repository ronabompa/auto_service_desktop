using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ServiceAutoFINAL.Entities;
using ServiceAutoFINAL.Factory;
using ServiceAutoFINAL.Repositories;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ServiceAutoFINAL.Models;


namespace ServiceAutoFINAL.Service
{
    public interface IAppointmentService
    {
		public List<Appointment> GetAppointments();
		
		public Appointment GetAppointment(DateTime dateTime);

		public List<Appointment> getClientAppointments(String client);
		
		public List<Appointment> getAppointmentsBetween2Dates(DateTime date1, DateTime date2);
		
		public List<Appointment> getAppointmentsForOneDay(DateTime date);
		
		public bool makeAppointment(String client, String phone, DateTime dateTime, String car, String problem, String status);
		
		public bool updateAppointment(DateTime dateTime,String status);

		public FileStream Export(string expType);

	}

	public class AppointmentService : IAppointmentService
    {

		IUnitOfWork _unitOfWork;

		public AppointmentService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		List<Appointment> la= new List<Appointment>();

		//// ----- AppointmentService METHODS ----- ////

		/**
		* fetches all  Appointments
		*/
		public List<Appointment> GetAppointments()
		{
			List<Appointment> appointmentsList = (List<Appointment>) _unitOfWork.Appointment.GetAll();
			return appointmentsList;
		}

		/**
		* fetches one Appointment by date and time
		*/
		public Appointment GetAppointment(DateTime dateTime)
		{
			Appointment appointment = _unitOfWork.Appointment.Get(dateTime);
			return appointment;
		}

		/**
		 * fetches all Client's Appointments
		 */
		public List<Appointment> getClientAppointments(String client)
		{
			List<Appointment> appointmentsList = (List < Appointment >) _unitOfWork.Appointment.GetAll();
			return appointmentsList.Where(a => a.client.Contains(client)).ToList();
		}

		/**
		 * fetches all Appointments between 2 dates
		 */
		public List<Appointment> getAppointmentsBetween2Dates(DateTime dateTime1, DateTime dateTime2)
		{
			List<Appointment> appointmentsList = (List<Appointment>)_unitOfWork.Appointment.GetAll();
			return appointmentsList.Where(a => (a.dateTime.Date >= dateTime1.Date && a.dateTime.Date <= dateTime2.Date)).ToList();
		}

		/**
		 * fetches all Appointments in one day
		 */
		public List<Appointment> getAppointmentsForOneDay(DateTime date)
		{
			List<Appointment> appointmentsList = (List<Appointment>)_unitOfWork.Appointment.GetAll();
			return appointmentsList.Where(a => a.dateTime.Date.Equals(date.Date)).ToList();
		}

		/**
		 *  inserts an Appointment in db
		 *  returns true the Appointment was inserted
		 */
		public bool makeAppointment(String client, String phone, DateTime dateTime, String car, String problem, String status)
		{
			//verificam daca s-a creat
			Appointment appointmentDB = _unitOfWork.Appointment.Get(dateTime);

			if(appointmentDB != null)
			{
				return false;  //deja exista
			}
			else
			{
				Appointment appointment = new Appointment(client, phone, dateTime, car, problem, status);
				_unitOfWork.Appointment.Add(appointment);

				return true;
			}

		}

		/**
		*  updates Appointments status
		*  returns true if the status was updated
		*/
		public bool updateAppointment(DateTime dateTime, String status)
		{
			
			Appointment appointment = _unitOfWork.Appointment.Get(dateTime);
			appointment.status = status;
		   
			_unitOfWork.Appointment.Update(appointment);
			return true;
			
		}

		public FileStream Export(string expType)
		{
			List<Appointment> listApp = this.GetAppointments();
			ExporterFactory exporterFactory = new ExporterFactory();

			FileStream fileExp = exporterFactory.GetExporter(expType).export(listApp);
			return fileExp;

		}
	}
}
