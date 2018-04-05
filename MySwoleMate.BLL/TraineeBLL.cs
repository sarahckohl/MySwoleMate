﻿using MySwoleMate.DAL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.BLL
{
    public class TraineeBLL
    {
        //Instance of the Data Access Layer class for Trainees
        private TraineeDAL data;

        //Constructor that accepts a connectionString from the Presentation Layer,
        //Use the connectionString to pass into a new instance of the Data Access Layer class
        //TraineeDAL
        public TraineeBLL(string connectionString)
        {
            data = new TraineeDAL(connectionString);
        }

        private string heightDisplay(int height){
            return $"{height/12} ft. {height%12} in.";
        }

        private string PhoneDisplay(string rawNumber){
            StringBuilder hyphenatedNumber = rawNumber;
            hyphenatedNumber.insert("-", 2);
            hyphenatedNumber.insert("-", 5);
            hyphenatedNumber.insert("-", 8);
            return hyphenatedNumber.toString();
        }

        //Gets all Trainees in a List of TraineeViewModel
        public List<TraineeViewModel> GetAllTrainees()
        {
            //return the List<TraineeViewModel> from TraineeDAL
            //Here you will need to use the methods you create in 
            //Dive 1 in order to display the Height and proper cell phone display
            List<TraineeViewModel> trainees = data.GetTrainees();
            foreach(var item in trainees)
            {
                //for each item take the Height and CellNbr values,
                //use the HeightDisplay and PhoneDisplay methods
                //and store the returned values from the methods
                //into the HeightDisplay and PhoneDisplay properties of the item.
                //The DisplayHeight is done for you.
                item.DisplayHeight = HeightDisplay(item.Height);
            }
            return trainees;
        }

        //Returns ViewModel of Trainee by the Id
        public TraineeViewModel GetTraineeById(int id)
        {
            return data.GetTraineeById(id);
        }

        //Edits the Trainee accepting a TraineeViewModel
        public int EditTrainee(TraineeViewModel edit)
        {
            return data.EditTrainee(edit);
        }

        //Adds a new Trainee
        public int AddTrainee(TraineeViewModel add)
        {
            return data.AddTrainee(add);
        }

        //Deletes a trainee by the Id, Delete only needs the id of Trainee
        public int DeleteTrainee(int id)
        {
            return data.DeleteTrainee(id);
        }

        //You can create the private methods for HeightDisplay and PhoneDisplay below.
        //The HeightDisplay method signature has been given to you.
        private string HeightDisplay(int height)
        {
            //store the displayed height
            string heightDisplay = "";
            //perform the calculations to separate feet and height (hint: this is a great 
            //time to use the % (modulus) operator
            return heightDisplay;
        }
    }
}
