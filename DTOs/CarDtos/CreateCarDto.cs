﻿using ApiIntro.Entities;

namespace ApiIntro.DTOs.CarDtos
{
    public class CreateCarDto
    {
        public string Name { get; set; }
        public DateTime ModelYear { get; set; }
        public string Description { get; set; }
        public int? BrandId { get; set; }
        public Brand? brand { get; set; }
        public int? ColorID { get; set; }
        public Color? color { get; set; }
        public double DailyPrice { get; set; }
    }
}
