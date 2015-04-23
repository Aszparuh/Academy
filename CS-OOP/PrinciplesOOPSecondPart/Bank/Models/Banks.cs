namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Banks
    {
        private string name;
        private List<Account> accounts = new List<Account>();

        public Banks()
        {
            this.accounts = new List<Account>();
        }

        public Banks(string name)
            :this()
        {
            this.Name = name;
        }
        public string Name 
        {
            get {return this.name;}
            set { this.name = value; }
        }

        public void AddAccount(Account newAccount)
        {
            this.accounts.Add(newAccount);
        }

        public void RemoveAccont(Account oldAccount)
        {
            if (!this.accounts.Remove(oldAccount))
            {
                throw new ArgumentException("The Account does not exist.");
            }
        }

        public override string ToString()
        {
            var acc = this.accounts.OrderBy(ac => ac.Owner.Name).ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var account in acc)
            {
                sb.AppendLine(account.ToString());
            }

            return sb.ToString();
        }
    }
}