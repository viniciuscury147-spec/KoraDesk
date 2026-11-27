
using KoraDesk.Domain.Entities;
using KoraDesk.Domain.Enums;
using System;
using Xunit;

namespace KoraDesk.Tests;

public class TicketTests
{
    private Ticket CreateTicket()
    {
        return new Ticket(
            "Computador não liga",
            "O computador não está iniciando.",
            Guid.NewGuid(),
            Guid.NewGuid(),
            TicketPriority.High
        );
    }

    [Fact]
    public void CreateTicket_ShouldStartWithOpenStatus()
    {
        // Arrange
        var ticket = CreateTicket();

        // Assert
        Assert.Equal(TicketStatus.Open, ticket.Status);
    }

    [Fact]
    public void ChangeStatus_ShouldAllowOpenToInProgress()
    {
        // Arrange
        var ticket = CreateTicket();

        // Act
        ticket.ChangeStatus(TicketStatus.InProgress);

        // Assert
        Assert.Equal(TicketStatus.InProgress, ticket.Status);
    }

    [Fact]
    public void ChangeStatus_ShouldRejectOpenToClosed()
    {
        // Arrange
        var ticket = CreateTicket();

        // Act and Assert
        Assert.Throws<InvalidOperationException>(() =>
            ticket.ChangeStatus(TicketStatus.Closed)
        );
    }

    [Fact]
    public void AssignTechnician_ShouldSaveTechnicianId()
    {
        // Arrange
        var ticket = CreateTicket();
        var technicianId = Guid.NewGuid();

        // Act
        ticket.AssignTechnician(technicianId);

        // Assert
        Assert.Equal(technicianId, ticket.AssignedTechnicianId);
    }

    [Fact]
    public void AssignTechnician_ShouldRejectEmptyGuid()
    {
        // Arrange
        var ticket = CreateTicket();

        // Act and Assert
        Assert.Throws<ArgumentException>(() =>
            ticket.AssignTechnician(Guid.Empty)
        );
    }
}
