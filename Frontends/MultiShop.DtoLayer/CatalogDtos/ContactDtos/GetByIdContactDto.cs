﻿namespace MultiShop.DtoLayer.CatalogDtos.ContactDtos
{
    public class GetByIdContactDto
    {
        public string ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Messsage { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
    }
}
