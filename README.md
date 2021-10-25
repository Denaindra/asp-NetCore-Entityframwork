# asp-NetCore-Entityframwork

#  [ValidateAntiForgeryToken] validate the toekn that check user alredy exsit

# div asp-validation-summary="ModelOnly" class="text-danger"></div>

   [Required]
   [Range(1,int.MaxValue, ErrorMessage= "Amount must be greater than 0!")]
   public double Amout { get; set; }
