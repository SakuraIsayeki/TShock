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

using System;

namespace TShockAPI.DB.Models;

/// <summary>
/// Represents the research progress for a given item, associated by player/world.
/// </summary>
public class Research
{
	/// <summary>
	/// The ID of the world this research progress is associated with.
	/// </summary>
	public string WorldId { get; set; }

	/// <summary>
	/// The ID of the player this research progress is associated with.
	/// </summary>
	public string PlayerId { get; set; }

	/// <summary>
	/// The ID of the item this research progress is associated with.
	/// </summary>
	public int ItemId { get; set; }

	/// <summary>
	/// The amount sacrificed to unlock this item.
	/// </summary>
	public int AmountSacrificed { get; set; }

	/// <summary>
	/// The date/time at which this item was last sacrificed.
	/// </summary>
	public DateTime TimeSacrificed { get; set; }
}
