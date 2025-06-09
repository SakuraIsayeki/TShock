using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Npgsql;
using TShockAPI.Configuration;
using TShockAPI.DB.Models;

namespace TShockAPI.DB;

/// <summary>
/// Represents the EF Core database context for the TShock server.
/// </summary>
public class TShockDbContext : DbContext
{
	private readonly DbContextConnectionBuilder _connectionBuilder;

	/// <summary>
	/// The permission groups used by the server users.
	/// </summary>
	public DbSet<Group> GroupList { get; }

	/// <summary>
	/// The in-game items banned from use.
	/// </summary>
	public DbSet<ItemBan> ItemBans { get; }

	/// <summary>
	/// The projectiles banned from use.
	/// </summary>
	public DbSet<ProjectileBan> ProjectileBans { get; }

	/// <summary>
	/// The world regions declared on the server.
	/// </summary>
	public DbSet<Region> Regions { get; }

	/// <summary>
	/// The last remembered positions of each known player.
	/// </summary>
	public DbSet<PlayerPosition> RememberedPos { get; }

	/// <summary>
	/// The research progress of journey-mode players.
	/// </summary>
	public DbSet<Research> Research { get; }

	/// <summary>
	/// The tiles banned on the server.
	/// </summary>
	public DbSet<TileBan> TileBans { get; }

	/// <summary>
	/// The server-side characters saved on the server.
	/// </summary>
	public DbSet<PlayerData> tsCharacter { get; }

	/// <summary>
	/// The players known by the server.
	/// </summary>
	public DbSet<UserAccount> Users { get; }

	/// <summary>
	/// The warp points saved on the server.
	/// </summary>
	public DbSet<Warp> Warps { get; }

	/// <inheritdoc />
	public TShockDbContext(DbContextConnectionBuilder connectionBuilder)
	{
		_connectionBuilder = connectionBuilder;
	}

	/// <inheritdoc />
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);

		// Configure the DbContext to use the connection provided by the connection builder.
		optionsBuilder = _connectionBuilder.BuildDbConnection() switch
		{
			SqliteConnection conn => optionsBuilder.UseSqlite(conn),
			MySqlConnection conn => optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn)),
			NpgsqlConnection conn => optionsBuilder.UseNpgsql(conn),
			_ => throw new InvalidOperationException("Unsupported database connection type.")
		};
	}
}
