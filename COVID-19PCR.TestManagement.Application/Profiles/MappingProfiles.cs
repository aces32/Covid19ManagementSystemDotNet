using AutoMapper;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Command.AllocateBookingSpace;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetAvailableBookingDetails;
using COVID_19PCR.TestManagement.Application.Features.Administrators.Queries.GetBookingsReports;
using COVID_19PCR.TestManagement.Application.Features.IndividualLabs.Command.SetTestOutcome;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.BookCovidTest;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Command.CancelBookedTest;
using COVID_19PCR.TestManagement.Application.Features.Individuals.Queries.GetIndividualInfoByMobileNoAndEmail;
using COVID_19PCR.TestManagement.Application.Features.Locations.Queries.GetAllAvailableLocations;
using COVID_19PCR.TestManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<AllocateBookingSpaceCommand, AdminBookingAllocation>().ReverseMap();
            CreateMap<AllocateBookingSpaceCommandResponse, AdminBookingAllocation>().ReverseMap();
            CreateMap<BookingsReportsListsVm, AdminBookingAllocation>().ReverseMap();
            CreateMap<BookCovidTestCommandResponse, Individual>().ReverseMap();
            CreateMap<BookCovidTestCommand, Individual>().ReverseMap();
            CreateMap<SetTestOutcomeCommandResponse, IndividualLab>().ReverseMap();
            CreateMap<SetTestOutcomeCommand, IndividualLab>().ReverseMap();
            CreateMap<IndividualLabsRequest, IndividualLab>().ReverseMap();
            CreateMap<IndividualListsVm, Individual>().ReverseMap();
            CreateMap<AvailableLocationListVm, Location>().ReverseMap();
            CreateMap<LocationListsVm, Location>().ReverseMap();
            CreateMap<LocationDetailsVM, Location>().ReverseMap();
            CreateMap<AvailableBookingListVm, AdminBookingAllocation>().ReverseMap();
            CreateMap<CancelBookedTestCommand, Individual>().ReverseMap();
            CreateMap<CancelBookedTestCommandResponse, Individual>().ReverseMap();
            CreateMap<IndividualInfoListVm, Individual>().ReverseMap();
            CreateMap<IndividualLabListVm, IndividualLab>().ReverseMap();
            CreateMap<IndividualLabDetailsVm, IndividualLab>().ReverseMap();
        }
    }
}
