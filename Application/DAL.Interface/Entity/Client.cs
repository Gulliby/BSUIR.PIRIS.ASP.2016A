﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Entity
{
    public class Client : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Male { get; set; }
        public string PassportSeries { get; set; }
        public string PassportId { get; set; }
        public string IssuedBy { get; set; }
        public DateTime IssueDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string BirthPlace { get; set; }
        public string ResidenceActualPlace { get; set; }
        public string ResidenceActualAddress { get; set; }
        public string HomePhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Email { get; set; }
        public string ResidenceAddress { get; set; }
        public string MaritalStatus { get; set; }
        public string Citizenship { get; set; }
        public string Disability { get; set; }
        public bool Pensioner { get; set; }
        public decimal MonthlyIncome { get; set; }
    }
}
