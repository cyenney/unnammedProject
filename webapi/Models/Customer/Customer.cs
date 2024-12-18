﻿namespace webapi.Models.Customer
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

    }

    public class LoginCustomer
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
