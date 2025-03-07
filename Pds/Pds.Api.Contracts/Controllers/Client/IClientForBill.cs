using Pds.Core.Enums;

namespace Pds.Api.Contracts.Controllers.Client;

public interface IClientForBill
{
    Guid Id { get; set; }
    decimal Value { get; set; }
    PaymentType? PaymentType { get; set; }
    DateTime? PaidAt { get; set; }
    bool IsNeedPayNds { get; set; }
    string Comment { get; set; }
    string ContractNumber { get; set; }
    DateTime? ContractDate { get; set; }
}