using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viddly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        #region relationships
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
        #endregion
    }
}