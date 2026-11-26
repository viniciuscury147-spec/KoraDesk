
using System;
using KoraDesk.Domain.Enums;

namespace KoraDesk.Domain.Entities;

public class Ticket
{
    // Identificação do chamado
    public Guid Id { get; private set; }

    // Informações principais
    public string Title { get; private set; }

    public string Description { get; private set; }

    // Relacionamentos
    public Guid RequesterId { get; private set; }

    public Guid? AssignedTechnicianId { get; private set; }

    public Guid CategoryId { get; private set; }

    // Status e prioridade
    public TicketStatus Status { get; private set; }

    public TicketPriority Priority { get; private set; }

    // Datas
    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    // Construtor privado
    private Ticket()
    {
        Title = string.Empty;
        Description = string.Empty;
    }

    // Construtor principal
    public Ticket(
        string title,
        string description,
        Guid requesterId,
        Guid categoryId,
        TicketPriority priority)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("O título é obrigatório.");

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("A descrição é obrigatória.");

        if (requesterId == Guid.Empty)
            throw new ArgumentException("O solicitante é obrigatório.");

        if (categoryId == Guid.Empty)
            throw new ArgumentException("A categoria é obrigatória.");

        Id = Guid.NewGuid();

        Title = title;
        Description = description;

        RequesterId = requesterId;
        CategoryId = categoryId;

        Priority = priority;
        Status = TicketStatus.Open;

        CreatedAt = DateTime.UtcNow;
    }

    // Atribuir técnico ao chamado
    public void AssignTechnician(Guid technicianId)
    {
        if (Status == TicketStatus.Closed)
        {
            throw new InvalidOperationException(
                "Não é possível atribuir um técnico a um chamado fechado."
            );
        }

        if (technicianId == Guid.Empty)
        {
            throw new ArgumentException("Técnico inválido.");
        }

        AssignedTechnicianId = technicianId;
        UpdatedAt = DateTime.UtcNow;
    }

    // Alterar status do chamado
    public void ChangeStatus(TicketStatus newStatus)
    {
        if (Status == TicketStatus.Closed)
        {
            throw new InvalidOperationException(
                "Não é possível alterar um chamado fechado."
            );
        }

        bool isValidTransition = Status switch
        {
            TicketStatus.Open =>
                newStatus == TicketStatus.InProgress,

            TicketStatus.InProgress =>
                newStatus == TicketStatus.WaitingForRequester ||
                newStatus == TicketStatus.Resolved,

            TicketStatus.WaitingForRequester =>
                newStatus == TicketStatus.InProgress,

            TicketStatus.Resolved =>
                newStatus == TicketStatus.Closed ||
                newStatus == TicketStatus.InProgress,

            _ => false
        };

        if (!isValidTransition)
        {
            throw new InvalidOperationException(
                $"Não é possível alterar o status de {Status} para {newStatus}."
            );
        }

        Status = newStatus;
        UpdatedAt = DateTime.UtcNow;
    }
}
