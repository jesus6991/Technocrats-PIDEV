using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.Entity
{
    public enum ClientType
    {
        CurrentClient,
        NewClient,
        FinishedClient
    }
    public enum ClientCategory : byte
    {

        Private,
        Public
    }
    public class Client:Users
    {
        public ClientCategory categorie_c { get; set; }
        public ClientType type_c { get; set; }
        public string adresse { get; set; }
        // public string Email { get; set; }


        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<OrganizationChart> OrganizationCharts { get; set; }


    }
}