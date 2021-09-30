using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Testauth.Models.Authenticationconn;

namespace Testauth.Data
{
  public partial class AuthenticationconnContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public AuthenticationconnContext(DbContextOptions<AuthenticationconnContext> options):base(options)
    {
    }

    public AuthenticationconnContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .HasOne(i => i.HelpDeskStatus)
              .WithMany(i => i.HelpDeskTickets)
              .HasForeignKey(i => i.TicketStatus)
              .HasPrincipalKey(i => i.TicketStatus);
        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .HasOne(i => i.LocationList)
              .WithMany(i => i.HelpDeskTickets)
              .HasForeignKey(i => i.locationID)
              .HasPrincipalKey(i => i.locationID);
        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .HasOne(i => i.ServiceCatglist)
              .WithMany(i => i.HelpDeskTickets)
              .HasForeignKey(i => i.ServiceCatgID)
              .HasPrincipalKey(i => i.ServiceCatgID);
        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .HasOne(i => i.ServicesList)
              .WithMany(i => i.HelpDeskTickets)
              .HasForeignKey(i => i.ServiceID)
              .HasPrincipalKey(i => i.ServiceID);
        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>()
              .HasOne(i => i.HelpDeskTicket)
              .WithMany(i => i.HelpDeskTicketDetails)
              .HasForeignKey(i => i.HelpDeskTicketId)
              .HasPrincipalKey(i => i.Id);
        builder.Entity<Testauth.Models.Authenticationconn.ServicesList>()
              .HasOne(i => i.ServiceCatglist)
              .WithMany(i => i.ServicesLists)
              .HasForeignKey(i => i.ServiceCatgID)
              .HasPrincipalKey(i => i.ServiceCatgID);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.TicketGUID)
              .HasDefaultValueSql("(newid())");

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.TicketStatus)
              .HasDefaultValueSql("(N'New')");

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.TicketDate)
              .HasDefaultValueSql("(getdate())");

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>()
              .Property(p => p.TicketDetailDate)
              .HasDefaultValueSql("(getdate())");


        builder.Entity<Testauth.Models.Authenticationconn.DeviceCode>()
              .Property(p => p.CreationTime)
              .HasColumnType("datetime2");

        builder.Entity<Testauth.Models.Authenticationconn.DeviceCode>()
              .Property(p => p.Expiration)
              .HasColumnType("datetime2");

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.TicketDate)
              .HasColumnType("datetime");

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>()
              .Property(p => p.TicketDetailDate)
              .HasColumnType("datetime");

        builder.Entity<Testauth.Models.Authenticationconn.PersistedGrant>()
              .Property(p => p.CreationTime)
              .HasColumnType("datetime2");

        builder.Entity<Testauth.Models.Authenticationconn.PersistedGrant>()
              .Property(p => p.Expiration)
              .HasColumnType("datetime2");

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.Id)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.locationID)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.ServiceCatgID)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicket>()
              .Property(p => p.ServiceID)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>()
              .Property(p => p.Id)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.HelpDeskTicketDetail>()
              .Property(p => p.HelpDeskTicketId)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.LocationList>()
              .Property(p => p.locationID)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.ServiceCatglist>()
              .Property(p => p.ServiceCatgID)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.ServicesList>()
              .Property(p => p.ServiceID)
              .HasPrecision(19, 0);

        builder.Entity<Testauth.Models.Authenticationconn.ServicesList>()
              .Property(p => p.ServiceCatgID)
              .HasPrecision(19, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<Testauth.Models.Authenticationconn.DeviceCode> DeviceCodes
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.HelpDeskStatus> HelpDeskStatuses
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.HelpDeskTicket> HelpDeskTickets
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.HelpDeskTicketDetail> HelpDeskTicketDetails
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.LocationList> LocationLists
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.PersistedGrant> PersistedGrants
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.ServiceCatglist> ServiceCatglists
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.ServicesList> ServicesLists
    {
      get;
      set;
    }

    public DbSet<Testauth.Models.Authenticationconn.TicketRequesterUsersList> TicketRequesterUsersLists
    {
      get;
      set;
    }
  }
}
