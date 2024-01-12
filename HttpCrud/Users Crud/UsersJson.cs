namespace HttpCrud.Users_Crud
{
   
        public record class Address
        (
            string? street =null,
            string? suite =null,
            string? city =null,
            string? zipcode =null,
            Geo? geo =null
        );

        public record class Company
        (
            string? name =null,
            string? catchPhrase =null,
            string? bs =null
        );

        public record class Geo
        (
            string? lat =null,
            string? lng =null
        );

        public record class Users(
        
            int? id =null,
            string? name =null,
            string? username =null,
            string? email =null,
            Address? address =null,
            string? phone =null,
            string? website =null,
            Company? company =null
      );
    
}
