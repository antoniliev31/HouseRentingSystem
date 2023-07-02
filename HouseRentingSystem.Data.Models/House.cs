﻿namespace HouseRentingSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.House;

    public class House
    {
        public House()
        {
            this.Id = Guid.NewGuid();
        }
        
        [Key]
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(TitleMaxLength)] 
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required] 
        [MaxLength(ImageUrlMaxLength)] 
        public string ImageUrl { get; set; } = null!;

        public decimal PricePerMonth  { get; set; }


        [ForeignKey(nameof(Category))]
        public int CategoryId  { get; set; }
        public virtual Category Category { get; set; } = null!;


        [ForeignKey(nameof(Agent))]
        public Guid AgentId { get; set; }
        public virtual Agent Agent { get; set; } = null!;


        public Guid? RenterId { get; set; }

        public virtual ApplicationUser? Renter { get; set; }
    }
}
