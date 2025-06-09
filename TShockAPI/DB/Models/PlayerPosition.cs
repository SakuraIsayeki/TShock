using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace TShockAPI.DB.Models;

/// <summary>
/// Represents the position of a player in-game.
/// </summary>
public record PlayerPosition
{
	/// <summary>
	/// The name of the player associated with this position.
	/// </summary>
	[MaxLength(50)]
	public string Name { get; set; }

	/// <summary>
	/// The IP address of the player associated with this position.
	/// </summary>
	public IPAddress IP { get; set; }

	/// <summary>
	/// The X coordinate of this position.
	/// </summary>
	public int X { get; set; }

	/// <summary>
	/// The Y coordinate of this position.
	/// </summary>
	public int Y { get; set; }

	/// <summary>
	/// The ID of the world this position is related to.
	///	</summary>
	public string WorldID { get; set; }
}
