﻿namespace Ilkyar.Contracts.Entities.DTO
{
    public class CreateUserDTO
    {
        public int UserTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public bool IsActive { get; set; }
    }
}
