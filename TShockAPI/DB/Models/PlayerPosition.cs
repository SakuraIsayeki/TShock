/*
TShock, a server mod for Terraria
Copyright (C) 2011-2025 Pryaxis & TShock Contributors

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

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
