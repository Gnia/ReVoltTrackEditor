/*
    Re-Volt Track Editor - Unity Edition
    A version of the track editor re-built from the ground up in Unity
    Copyright (C) 2022 Dummiesman

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

namespace Modules
{
	public enum Direction
    {
		North = 0,
		East = 1,
		South = 2,
		West = 3
    }

	public enum ID 
	{
		TWM_SPACE, //space_unit
		TWM_START, //start_grid
		TWM_SPACE_B, //space_unit
		TWM_BANK_05, //b_05
		TWM_BANK_10, //b_10
		TWM_BANK_20, //b_20
		TWM_BANK_05_2, //b_05_2
		TWM_BANK_10_2, //b_10_2
		TWM_BANK_20_2, //b_20_2
		TWM_BANK_05_2_LH, //b_05_2_LH
		TWM_BANK_10_2_LH, //b_10_2_LH
		TWM_BANK_20_2_LH, //b_20_2_LH
		TWM_BANK_05_2_N, //b_05_2_N
		TWM_BANK_10_2_N, //b_10_2_N
		TWM_BANK_20_2_N, //b_20_2_N
		TWM_BANK_CORNER_05, //bc_05
		TWM_BANK_CORNER_10, //bc_10
		TWM_BANK_CORNER_20, //bc_20
		TWM_BANK_CORNER_05_2, //bc_05_2
		TWM_BANK_CORNER_10_2, //bc_10_2
		TWM_BANK_CORNER_20_2, //bc_20_2
		TWM_BANK_IN_05, //bino_05
		TWM_BANK_IN_10, //bino_10
		TWM_BANK_IN_20, //bino_20
		TWM_BANK_IN_05_2, //bino_05_2
		TWM_BANK_IN_10_2, //bino_10_2
		TWM_BANK_IN_20_2, //bino_20_2
		TWM_BANK_IN_05_LH, //bino_05_LH
		TWM_BANK_IN_10_LH, //bino_10_LH
		TWM_BANK_IN_20_LH, //bino_20_LH
		TWM_BANK_IN_05_2_LH, //bino_05_2_LH
		TWM_BANK_IN_10_2_LH, //bino_10_2_LH
		TWM_BANK_IN_20_2_LH, //bino_20_2_LH
		TWM_BANK_IN_05_2_D, //bino_05_2_D
		TWM_BANK_IN_10_2_D, //bino_10_2_D
		TWM_BANK_IN_20_2_D, //bino_20_2_D
		TWM_BANK_IN_05_2_LH_D, //bino_05_2_LH_D
		TWM_BANK_IN_10_2_LH_D, //bino_10_2_LH_D
		TWM_BANK_IN_20_2_LH_D, //bino_20_2_LH_D
		TWM_BANK_IN_05_2_N, //bino_05_2_N
		TWM_BANK_IN_10_2_N, //bino_10_2_N
		TWM_BANK_IN_20_2_N, //bino_20_2_N
		TWM_BANK_IN_05_2_LH_N, //bino_05_2_LH_N
		TWM_BANK_IN_10_2_LH_N, //bino_10_2_LH_N
		TWM_BANK_IN_20_2_LH_N, //bino_20_2_LH_N
		TWM_BRIDGE_10, //bridge_10
		TWM_BRIDGE_15, //bridge_15
		TWM_BRIDGE_20, //bridge_20
		TWM_BRIDGE_25, //bridge_25
		TWM_BRIDGE_30, //bridge_30
		TWM_BRIDGE_35, //bridge_35
		TWM_BRIDGE_40, //bridge_40
		TWM_BRIDGE_45, //bridge_45
		TWM_BRIDGE_50, //bridge_50
		TWM_BRIDGE_55, //bridge_55
		TWM_BRIDGE_60, //bridge_60
		TWM_BRIDGE_65, //bridge_65
		TWM_BRIDGE_70, //bridge_70
		TWM_BRIDGE_75, //bridge_75
		TWM_BRIDGE_80, //bridge_80
		TWM_BRIDGE_10_2, //bridge_10_2
		TWM_BRIDGE_15_2, //bridge_15_2
		TWM_BRIDGE_20_2, //bridge_20_2
		TWM_BRIDGE_25_2, //bridge_25_2
		TWM_BRIDGE_30_2, //bridge_30_2
		TWM_BRIDGE_35_2, //bridge_35_2
		TWM_BRIDGE_40_2, //bridge_40_2
		TWM_BRIDGE_45_2, //bridge_45_2
		TWM_BRIDGE_50_2, //bridge_50_2
		TWM_BRIDGE_55_2, //bridge_55_2
		TWM_BRIDGE_60_2, //bridge_60_2
		TWM_BRIDGE_65_2, //bridge_65_2
		TWM_BRIDGE_70_2, //bridge_70_2
		TWM_BRIDGE_75_2, //bridge_75_2
		TWM_BRIDGE_80_2, //bridge_80_2
		TWM_BRIDGE_10_2_LH, //bridge_10_2_LH
		TWM_BRIDGE_15_2_LH, //bridge_15_2_LH
		TWM_BRIDGE_20_2_LH, //bridge_20_2_LH
		TWM_BRIDGE_25_2_LH, //bridge_25_2_LH
		TWM_BRIDGE_30_2_LH, //bridge_30_2_LH
		TWM_BRIDGE_35_2_LH, //bridge_35_2_LH
		TWM_BRIDGE_40_2_LH, //bridge_40_2_LH
		TWM_BRIDGE_45_2_LH, //bridge_45_2_LH
		TWM_BRIDGE_50_2_LH, //bridge_50_2_LH
		TWM_BRIDGE_55_2_LH, //bridge_55_2_LH
		TWM_BRIDGE_60_2_LH, //bridge_60_2_LH
		TWM_BRIDGE_65_2_LH, //bridge_65_2_LH
		TWM_BRIDGE_70_2_LH, //bridge_70_2_LH
		TWM_BRIDGE_75_2_LH, //bridge_75_2_LH
		TWM_BRIDGE_80_2_LH, //bridge_80_2_LH
		TWM_BRIDGE_10_2_N, //bridge_10_2_N
		TWM_BRIDGE_15_2_N, //bridge_15_2_N
		TWM_BRIDGE_20_2_N, //bridge_20_2_N
		TWM_BRIDGE_25_2_N, //bridge_25_2_N
		TWM_BRIDGE_30_2_N, //bridge_30_2_N
		TWM_BRIDGE_35_2_N, //bridge_35_2_N
		TWM_BRIDGE_40_2_N, //bridge_40_2_N
		TWM_BRIDGE_45_2_N, //bridge_45_2_N
		TWM_BRIDGE_50_2_N, //bridge_50_2_N
		TWM_BRIDGE_55_2_N, //bridge_55_2_N
		TWM_BRIDGE_60_2_N, //bridge_60_2_N
		TWM_BRIDGE_65_2_N, //bridge_65_2_N
		TWM_BRIDGE_70_2_N, //bridge_70_2_N
		TWM_BRIDGE_75_2_N, //bridge_75_2_N
		TWM_BRIDGE_80_2_N, //bridge_80_2_N
		TWM_CORNER_SQUARE, //c_basic
		TWM_CORNER_SQUARE_2, //c_basic_2
		TWM_CORNER_REGULAR, //c_l_r
		TWM_CORNER_REGULAR_2, //c_l_r_2
		TWM_CORNER_REGULAR_LH, //c_l_r_LH
		TWM_CORNER_REGULAR_2_LH, //c_l_r_2_LH
		TWM_CORNER_REGULAR_N, //c_l_r_N
		TWM_CORNER_REGULAR_2_N, //c_l_r_2_N
		TWM_CORNER_MEDIUM, //c_l_x
		TWM_CORNER_MEDIUM_2, //c_l_x_2
		TWM_CORNER_MEDIUM_LH, //c_l_x_LH
		TWM_CORNER_MEDIUM_2_LH, //c_l_x_2_LH
		TWM_CORNER_MEDIUM_N, //c_l_x_N
		TWM_CORNER_MEDIUM_2_N, //c_l_x_2_N
		TWM_CORNER_LARGE, //c_l_xt
		TWM_CORNER_LARGE_2, //c_l_xt_2
		TWM_CORNER_LARGE_LH, //c_l_xt_LH
		TWM_CORNER_LARGE_2_LH, //c_l_xt_2_LH
		TWM_CORNER_LARGE_N, //c_l_xt_N
		TWM_CORNER_LARGE_2_N, //c_l_xt_2_N
		TWM_DIP_R, //d_r
		TWM_DIP_X, //d_x
		TWM_DIP_XT, //d_xt
		TWM_DIP_R_2, //d_r_2
		TWM_DIP_X_2, //d_x_2
		TWM_DIP_XT_2, //d_xt_2
		TWM_HUMP_R, //h_r
		TWM_HUMP_X, //h_x
		TWM_HUMP_XT, //h_xt
		TWM_HUMP_R_2, //h_r_2
		TWM_HUMP_X_2, //h_x_2
		TWM_HUMP_XT_2, //h_xt_2
		TWM_NARROW, //narrow
		TWM_NARROWF, //narrowf
		TWM_NARROWF_2, //narrowf_2
		TWM_PIPE_0, //p_(0)
		TWM_PIPE_1, //p_(1)
		TWM_PIPE_2, //p_(2)
		TWM_PIPE_20_0, //p_20_(0)
		TWM_PIPE_20_1_BOT, //p_20_(1,bot)
		TWM_PIPE_20_1_TOP, //p_20_(1,top)
		TWM_PIPE_20_2, //p_20_(2)
		TWM_PIPEC_0, //pc_(0)
		TWM_PIPEC_1, //pc_(1)
		TWM_PIPEC_1A, //pc_(1a)
		TWM_PIPEC_2, //pc_(2)
		TWM_PIPEF, //pf
		TWM_PIPE_1A, //p_(1a)
		TWM_PIPEF_OUT, //pf_out
		TWM_PIPEF_N, //pf_n
		TWM_RAMP_00, //r_00
		TWM_RAMP_05, //r_05
		TWM_RAMP_10, //r_10
		TWM_RAMP_15, //r_15
		TWM_RAMP_20, //r_20
		TWM_RAMP_25, //r_25
		TWM_RAMP_30, //r_30
		TWM_RAMP_00_2, //r_00_2
		TWM_RAMP_05_2, //r_05_2
		TWM_RAMP_10_2, //r_10_2
		TWM_RAMP_15_2, //r_15_2
		TWM_RAMP_20_2, //r_20_2
		TWM_RAMP_25_2, //r_25_2
		TWM_RAMP_30_2, //r_30_2
		TWM_RAMP_05_2_D, //r_05_2_D
		TWM_RAMP_10_2_D, //r_10_2_D
		TWM_RAMP_15_2_D, //r_15_2_D
		TWM_RAMP_20_2_D, //r_20_2_D
		TWM_RAMP_25_2_D, //r_25_2_D
		TWM_RAMP_30_2_D, //r_30_2_D
		TWM_RAMP_05_2_N, //r_05_2_N
		TWM_RAMP_10_2_N, //r_10_2_N
		TWM_RAMP_15_2_N, //r_15_2_N
		TWM_RAMP_20_2_N, //r_20_2_N
		TWM_RAMP_25_2_N, //r_25_2_N
		TWM_RAMP_30_2_N, //r_30_2_N
		TWM_DIAGONAL_01, //sf_01
		TWM_DIAGONAL_02, //sf_02
		TWM_DIAGONAL_01_2, //sf_01_2
		TWM_DIAGONAL_02_2, //sf_02_2
		TWM_DIAGONAL_01_LH, //sf_01_LH
		TWM_DIAGONAL_02_LH, //sf_02_LH
		TWM_DIAGONAL_01_2_LH, //sf_01_2_LH
		TWM_DIAGONAL_02_2_LH, //sf_02_2_LH
		TWM_RUMBLE_02, //st_02
		TWM_RUMBLE_04, //st_04
		TWM_RUMBLE_02_2, //st_02_2
		TWM_RUMBLE_04_2, //st_04_2
		TWM_CROSS_ROAD, //X
		TWM_ZIGZAG, //zigzag
		TWM_ZIGZAG_2, //zigzag_2
		TWM_JUMP,     //jump unit
		TWM_RAMP_00_2_N, //r_00_2_n
		TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS, // ADDED PIECES START
		TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END,
		TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END,
		TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS,
		TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,
		TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END,
		TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END,
		TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,
		TWM_PIPE_RAMP_BOTTOM_NO_ENDS,
		TWM_PIPE_RAMP_BOTTOM_FRONT_END,
		TWM_PIPE_RAMP_BOTTOM_BACK_END,
		TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,
		TWM_PIPE_RAMP_UP_NO_ENDS,
		TWM_PIPE_RAMP_UP_FRONT_END,
		TWM_PIPE_RAMP_UP_BACK_END,
		TWM_PIPE_RAMP_UP_BOTH_ENDS,
		TWM_PIPE_RAMP_15_NO_ENDS,
		TWM_PIPE_RAMP_15_FRONT_END,
		TWM_PIPE_RAMP_15_BACK_END,
		TWM_PIPE_RAMP_15_BOTH_ENDS,
		TWM_PIPE_RAMP_10_NO_ENDS,
		TWM_PIPE_RAMP_10_FRONT_END,
		TWM_PIPE_RAMP_10_BACK_END,
		TWM_PIPE_RAMP_10_BOTH_ENDS,
		TWM_PIPE_RAMP_5_NO_ENDS,
		TWM_PIPE_RAMP_5_FRONT_END,
		TWM_PIPE_RAMP_5_BACK_END,
		TWM_PIPE_RAMP_5_BOTH_ENDS,
		TWM_BANK_CROSS_ROAD_05,
		TWM_BANK_CROSS_ROAD_10,
		TWM_BANK_CROSS_ROAD_20,
		TWM_HUMP_SQUARE,
		TWM_DIP_SQUARE,
		TWM_BANK_UP_TURN_05,
		TWM_BANK_UP_TURN_10,
		TWM_BANK_UP_TURN_20,
		TWM_BANK_DOWN_TURN_05,
		TWM_BANK_DOWN_TURN_10,
		TWM_BANK_DOWN_TURN_20,
		TWM_BANK_SMOOTH_TURN_1X1_05,
		TWM_BANK_SMOOTH_TURN_2X2_05,
		TWM_BANK_SMOOTH_TURN_3X3_05,
		TWM_BANK_SMOOTH_TURN_1X1_10,
		TWM_BANK_SMOOTH_TURN_2X2_10,
		TWM_BANK_SMOOTH_TURN_3X3_10,
		TWM_BANK_SMOOTH_TURN_1X1_20,
		TWM_BANK_SMOOTH_TURN_2X2_20,
		TWM_BANK_SMOOTH_TURN_3X3_20,
		TWM_BANK_UP_TURN2_05, // mirrored turns
		TWM_BANK_UP_TURN2_10,
		TWM_BANK_UP_TURN2_20,
		TWM_BANK_DOWN_TURN2_05,
		TWM_BANK_DOWN_TURN2_10,
		TWM_BANK_DOWN_TURN2_20,
		TWM_RUMBLE_DOWN,
		TWM_ZIGZAG_MIRROR,
		TWM_ZIGZAG_MIRROR_2,
		TWM_ZIGZAG_HALF,
		TWM_BANK_SMOOTH_TURN_1X1_05_R,
		TWM_BANK_SMOOTH_TURN_2X2_05_R,
		TWM_BANK_SMOOTH_TURN_3X3_05_R,
		TWM_BANK_SMOOTH_TURN_1X1_10_R,
		TWM_BANK_SMOOTH_TURN_2X2_10_R,
		TWM_BANK_SMOOTH_TURN_3X3_10_R,
		TWM_BANK_SMOOTH_TURN_1X1_20_R,
		TWM_BANK_SMOOTH_TURN_2X2_20_R,
		TWM_BANK_SMOOTH_TURN_3X3_20_R,
		TWM_BANK_SMOOTH_TURN_1X1_05_L,
		TWM_BANK_SMOOTH_TURN_2X2_05_L,
		TWM_BANK_SMOOTH_TURN_3X3_05_L,
		TWM_BANK_SMOOTH_TURN_1X1_10_L,
		TWM_BANK_SMOOTH_TURN_2X2_10_L,
		TWM_BANK_SMOOTH_TURN_3X3_10_L,
		TWM_BANK_SMOOTH_TURN_1X1_20_L,
		TWM_BANK_SMOOTH_TURN_2X2_20_L,
		TWM_BANK_SMOOTH_TURN_3X3_20_L,
		TWM_FINISH, //finish line for sprint tracks
		TWM_BANK_FLAT_TO_5,
		TWM_BANK_FLAT_TO_10,
		TWM_BANK_FLAT_TO_20,
		TWM_BANK_5_TO_10,
		TWM_BANK_10_TO_20,
		TWM_BANK_FLAT_TO_5_2,
		TWM_BANK_FLAT_TO_10_2,
		TWM_BANK_FLAT_TO_20_2,
		TWM_BANK_5_TO_10_2,
		TWM_BANK_10_TO_20_2,
		TWM_DIAGONAL_SMOOTH,
		TWM_DIAGONAL_SMOOTH_UP5,
		TWM_DIAGONAL_SMOOTH_2,
		TWM_DIAGONAL_SMOOTH_UP5_2,
		TWM_DIAGONAL_SMOOTH_BANK_5,
		TWM_DIAGONAL_SMOOTH_BANK_10,
		TWM_DIAGONAL_SMOOTH_BANK_20,
		TWM_DIAGONAL_SMOOTH_BANK_5_2,
		TWM_DIAGONAL_SMOOTH_BANK_10_2,
		TWM_DIAGONAL_SMOOTH_BANK_20_2,
		TWM_DOUBLE_STRAIGHT,
		TWM_DOUBLE_SIDE_ENTRY,
		TWM_DOUBLE_SIDE_ENTRY_2,
		TWM_DOUBLE_SQUARE_TURN,
		TWM_DOUBLE_SQUARE_TURN_2,
		TWM_DOUBLE_ROUND_TURN,
		TWM_DOUBLE_ROUND_TURN_2,
		TWM_DOUBLE_ROUND_TURN_L,
		TWM_DOUBLE_ROUND_TURN_L_2,
		TWM_DOUBLE_ROUND_TURN_R,
		TWM_DOUBLE_ROUND_TURN_R_2,
		TWM_BANK_SWITCH_5_TO_5,
		TWM_BANK_SWITCH_10_TO_10,
		TWM_BANK_SWITCH_20_TO_20,
		TWM_BANK_SWITCH_5_TO_5_2,
		TWM_BANK_SWITCH_10_TO_10_2,
		TWM_BANK_SWITCH_20_TO_20_2,
		TWM_CROSS_ROAD_HALF_PIPE,
		TWM_NARROW_SINGLE,
		TWM_PILLAR_CENTER,
		TWM_PILLAR_OFFSET,
		TWM_PILLAR_ZIGZAG,
		TWM_PILLAR_ZIGZAG_MIRROR,
		TWM_ZIGZAG_HALF_CARPET_FORWARD,
		TWM_ZIGZAG_HALF_CARPET_BACKWARD,
		TWM_ZIGZAG_HALF_CARPET_NEUTRAL,
		TWM_NARROW_SINGLE_CARPET,
		TWM_PILLAR_CENTER_CARPET_FORWARD,
		TWM_PILLAR_CENTER_CARPET_BACKWARD,
		TWM_PILLAR_CENTER_CARPET_NEUTRAL,
		TWM_PILLAR_OFFSET_CARPET_FORWARD,
		TWM_PILLAR_OFFSET_CARPET_BACKWARD,
		TWM_PILLAR_OFFSET_CARPET_NEUTRAL,
		TWM_PILLAR_ZIGZAG_CARPET_FORWARD,
		TWM_PILLAR_ZIGZAG_CARPET_BACKWARD,
		TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL,
		TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,
		TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD,
		TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,
		TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,
		TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,
		TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,
		TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,
		TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,
		TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,
		TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,
		TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,
		TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,
		TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,
		TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,
		TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,
		TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,
		TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,
		TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,
		TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,
		TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,
		TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL,
		TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL,
		TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,
		TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD,
		TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL,
		TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,
		TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD,
		TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL,
		TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,
		TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD,
		TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL,
		TWM_DOUBLE_SQUARE_TURN_CARPET,
		TWM_DOUBLE_SQUARE_TURN_CARPET_2,
		TWM_DOUBLE_ROUND_TURN_CARPET,
		TWM_DOUBLE_ROUND_TURN_CARPET_2,
		TWM_DOUBLE_ROUND_TURN_CARPET_L,
		TWM_DOUBLE_ROUND_TURN_CARPET_L_2,
		TWM_DOUBLE_ROUND_TURN_CARPET_R,
		TWM_DOUBLE_ROUND_TURN_CARPET_R_2,
		TWM_BANK_UP_TURN_05_CARPET,
		TWM_BANK_UP_TURN_10_CARPET,
		TWM_BANK_UP_TURN_20_CARPET,
		TWM_BANK_DOWN_TURN_05_CARPET,
		TWM_BANK_DOWN_TURN_10_CARPET,
		TWM_BANK_DOWN_TURN_20_CARPET,
		TWM_BANK_UP_TURN2_05_CARPET, // mirrored turns
		TWM_BANK_UP_TURN2_10_CARPET,
		TWM_BANK_UP_TURN2_20_CARPET,
		TWM_BANK_DOWN_TURN2_05_CARPET,
		TWM_BANK_DOWN_TURN2_10_CARPET,
		TWM_BANK_DOWN_TURN2_20_CARPET,
		TWM_HUMP_SQUARE_CARPET,
		TWM_DIP_SQUARE_CARPET,
		TWM_RUMBLE_DOWN_CARPET,
		TWM_BANK_FLAT_TO_5_CARPET_FORWARD,
		TWM_BANK_FLAT_TO_10_CARPET_FORWARD,
		TWM_BANK_FLAT_TO_20_CARPET_FORWARD,
		TWM_BANK_5_TO_10_CARPET_FORWARD,
		TWM_BANK_10_TO_20_CARPET_FORWARD,
		TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,
		TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,
		TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,
		TWM_BANK_5_TO_10_2_CARPET_FORWARD,
		TWM_BANK_10_TO_20_2_CARPET_FORWARD,
		TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,
		TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,
		TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,
		TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,
		TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,
		TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,
		TWM_BANK_FLAT_TO_5_CARPET_BACKWARD,
		TWM_BANK_FLAT_TO_10_CARPET_BACKWARD,
		TWM_BANK_FLAT_TO_20_CARPET_BACKWARD,
		TWM_BANK_5_TO_10_CARPET_BACKWARD,
		TWM_BANK_10_TO_20_CARPET_BACKWARD,
		TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD,
		TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD,
		TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD,
		TWM_BANK_5_TO_10_2_CARPET_BACKWARD,
		TWM_BANK_10_TO_20_2_CARPET_BACKWARD,
		TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD,
		TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD,
		TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD,
		TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD,
		TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD,
		TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD,
		TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL,
		TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL,
		TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL,
		TWM_BANK_5_TO_10_CARPET_NEUTRAL,
		TWM_BANK_10_TO_20_CARPET_NEUTRAL,
		TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL,
		TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL,
		TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL,
		TWM_BANK_5_TO_10_2_CARPET_NEUTRAL,
		TWM_BANK_10_TO_20_2_CARPET_NEUTRAL,
		TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL,
		TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL,
		TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL,
		TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL,
		TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL,
		TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,
		TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD,
		TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL,
		TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL,
		TWM_NARROW_CARPET,
		TWM_DIP_R_2_FORWARD,
		TWM_DIP_X_2_FORWARD,
		TWM_DIP_XT_2_FORWARD,
		TWM_HUMP_R_2_FORWARD,
		TWM_HUMP_X_2_FORWARD,
		TWM_HUMP_XT_2_FORWARD,
		TWM_DIP_ROUND_SMALL_CARPET_FORWARD,
		TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,
		TWM_DIP_ROUND_BIG_CARPET_FORWARD,
		TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL,
		TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL,
		TWM_DIP_ROUND_BIG_CARPET_NEUTRAL,
		TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,
		TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,
		TWM_HUMP_ROUND_BIG_CARPET_FORWARD,
		TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL,
		TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL,
		TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL,
		TWM_RAMP_TOP,
		TWM_RAMP_BOTTOM,
		TWM_RAMP_TOP_CARPET_FORWARD,
		TWM_RAMP_TOP_CARPET_BACKWARD,
		TWM_RAMP_TOP_CARPET_NEUTRAL,
		TWM_RAMP_BOTTOM_CARPET_FORWARD,
		TWM_RAMP_BOTTOM_CARPET_BACKWARD,
		TWM_RAMP_BOTTOM_CARPET_NEUTRAL,
		TWM_DIP_ROUND_SMALL,
		TWM_DIP_ROUND_MEDIUM,
		TWM_DIP_ROUND_BIG,
		TWM_HUMP_ROUND_SMALL,
		TWM_HUMP_ROUND_MEDIUM,
		TWM_HUMP_ROUND_BIG,
		TWM_PILLAR_CENTER_LONG,
		TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,
		TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD,
		TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL,
		TWM_PILLAR_2SIDES,
		TWM_PILLAR_2SIDES_CARPET_FORWARD,
		TWM_PILLAR_2SIDES_CARPET_BACKWARD,
		TWM_PILLAR_2SIDES_CARPET_NEUTRAL,
		TWM_PILLAR_1SIDE,
		TWM_PILLAR_1SIDE_CARPET_FORWARD,
		TWM_PILLAR_1SIDE_CARPET_BACKWARD,
		TWM_PILLAR_1SIDE_CARPET_NEUTRAL,
		TWM_CROSS_ROAD_2_LINES,
	}

	public class Lookup
    {
		public static readonly ModuleGroup[] Groups = new[]
		{
	       new ModuleGroup(LocString.MODULE_STARTGRID,   ID.TWM_START,            ID.TWM_START ),
	       new ModuleGroup(LocString.MODULE_STRAIGHTS,   ID.TWM_RAMP_00,          ID.TWM_RAMP_00_2_N),

	       new ModuleGroup(LocString.MODULE_DOUBLE,   	 ID.TWM_DOUBLE_STRAIGHT,  ID.TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL),
						   
		   new ModuleGroup(LocString.MODULE_DIPS,		 ID.TWM_DIP_X,            ID.TWM_DIP_X_2),
	       new ModuleGroup(LocString.MODULE_HUMPS,       ID.TWM_HUMP_X,           ID.TWM_HUMP_X_2),
	       //new ModuleGroup(LocString.MODULE_SQUARE_BEND, ID.TWM_CORNER_SQUARE,    ID.TWM_CORNER_SQUARE_2),
	       //new ModuleGroup(LocString.MODULE_ROUND_BEND,  ID.TWM_CORNER_REGULAR_N, ID.TWM_CORNER_REGULAR_2_N),
	       new ModuleGroup(LocString.MODULE_BEND,		 ID.TWM_CORNER_REGULAR_N, ID.TWM_CORNER_REGULAR_2_N),
	       new ModuleGroup(LocString.MODULE_DIAGONAL,    ID.TWM_DIAGONAL_02,      ID.TWM_DIAGONAL_02_2),
	       new ModuleGroup(LocString.MODULE_BANK,        ID.TWM_BANK_05,          ID.TWM_BANK_05_2_N),
	       new ModuleGroup(LocString.MODULE_RUMBLE,      ID.TWM_RUMBLE_02,        ID.TWM_RUMBLE_02_2),
	       new ModuleGroup(LocString.MODULE_NARROW,      ID.TWM_NARROW,           ID.TWM_NARROW_CARPET),
						   
		   new ModuleGroup(LocString.MODULE_PIPE,        ID.TWM_PIPE_2,           ID.TWM_PIPE_2),
	       new ModuleGroup(LocString.MODULE_BRIDGE,      ID.TWM_BRIDGE_25,        ID.TWM_BRIDGE_25_2_N),
	       new ModuleGroup(LocString.MODULE_CROSSROAD,   ID.TWM_CROSS_ROAD,       ID.TWM_CROSS_ROAD),
	       new ModuleGroup(LocString.MODULE_JUMP,        ID.TWM_JUMP,             ID.TWM_JUMP),
	       new ModuleGroup(LocString.MODULE_CHICANE,     ID.TWM_ZIGZAG,           ID.TWM_ZIGZAG_2)
		};

		public static ReVolt.Track.AINodePriority[] ModulePriority = new[]
		{
			ReVolt.Track.AINodePriority.RacingLine, //space_unit
			ReVolt.Track.AINodePriority.RacingLine, //start_grid
			ReVolt.Track.AINodePriority.RacingLine, //space_unit
			ReVolt.Track.AINodePriority.RacingLine, //b_05
			ReVolt.Track.AINodePriority.RacingLine, //b_10
			ReVolt.Track.AINodePriority.RacingLine, //b_20
			ReVolt.Track.AINodePriority.RacingLine, //b_05_2
			ReVolt.Track.AINodePriority.RacingLine, //b_10_2
			ReVolt.Track.AINodePriority.RacingLine, //b_20_2
			ReVolt.Track.AINodePriority.RacingLine, //b_05_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //b_10_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //b_20_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //b_05_2_N
			ReVolt.Track.AINodePriority.RacingLine, //b_10_2_N
			ReVolt.Track.AINodePriority.RacingLine, //b_20_2_N
			ReVolt.Track.AINodePriority.Slowdown30, //bc_05
			ReVolt.Track.AINodePriority.Slowdown30, //bc_10
			ReVolt.Track.AINodePriority.Slowdown30, //bc_20
			ReVolt.Track.AINodePriority.Slowdown30, //bc_05_2
			ReVolt.Track.AINodePriority.Slowdown30, //bc_10_2
			ReVolt.Track.AINodePriority.Slowdown30, //bc_20_2
			ReVolt.Track.AINodePriority.RacingLine, //bino_05
			ReVolt.Track.AINodePriority.RacingLine, //bino_10
			ReVolt.Track.AINodePriority.RacingLine, //bino_20
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_2
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_2
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_2
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_LH
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_LH
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_LH
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_2_D
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_2_D
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_2_D
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_2_LH_D
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_2_LH_D
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_2_LH_D
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bino_05_2_LH_N
			ReVolt.Track.AINodePriority.RacingLine, //bino_10_2_LH_N
			ReVolt.Track.AINodePriority.RacingLine, //bino_20_2_LH_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_10
			ReVolt.Track.AINodePriority.RacingLine, //bridge_15
			ReVolt.Track.AINodePriority.RacingLine, //bridge_20
			ReVolt.Track.AINodePriority.RacingLine, //bridge_25
			ReVolt.Track.AINodePriority.RacingLine, //bridge_30
			ReVolt.Track.AINodePriority.RacingLine, //bridge_35
			ReVolt.Track.AINodePriority.RacingLine, //bridge_40
			ReVolt.Track.AINodePriority.RacingLine, //bridge_45
			ReVolt.Track.AINodePriority.RacingLine, //bridge_50
			ReVolt.Track.AINodePriority.RacingLine, //bridge_55
			ReVolt.Track.AINodePriority.RacingLine, //bridge_60
			ReVolt.Track.AINodePriority.RacingLine, //bridge_65
			ReVolt.Track.AINodePriority.RacingLine, //bridge_70
			ReVolt.Track.AINodePriority.RacingLine, //bridge_75
			ReVolt.Track.AINodePriority.RacingLine, //bridge_80
			ReVolt.Track.AINodePriority.RacingLine, //bridge_10_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_15_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_20_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_25_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_30_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_35_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_40_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_45_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_50_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_55_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_60_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_65_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_70_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_75_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_80_2
			ReVolt.Track.AINodePriority.RacingLine, //bridge_10_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_15_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_20_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_25_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_30_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_35_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_40_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_45_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_50_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_55_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_60_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_65_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_70_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_75_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_80_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //bridge_10_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_15_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_20_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_25_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_30_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_35_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_40_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_45_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_50_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_55_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_60_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_65_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_70_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_75_2_N
			ReVolt.Track.AINodePriority.RacingLine, //bridge_80_2_N
			ReVolt.Track.AINodePriority.Slowdown20, //c_basic
			ReVolt.Track.AINodePriority.Slowdown20, //c_basic_2
			ReVolt.Track.AINodePriority.Slowdown20, //c_l_r
			ReVolt.Track.AINodePriority.Slowdown20, //c_l_r_2
			ReVolt.Track.AINodePriority.Slowdown20, //c_l_r_LH
			ReVolt.Track.AINodePriority.Slowdown20, //c_l_r_2_LH
			ReVolt.Track.AINodePriority.Slowdown20, //c_l_r_N
			ReVolt.Track.AINodePriority.Slowdown20, //c_l_r_2_N
			ReVolt.Track.AINodePriority.Slowdown30, //c_l_x
			ReVolt.Track.AINodePriority.Slowdown30, //c_l_x_2
			ReVolt.Track.AINodePriority.Slowdown30, //c_l_x_LH
			ReVolt.Track.AINodePriority.Slowdown30, //c_l_x_2_LH
			ReVolt.Track.AINodePriority.Slowdown30, //c_l_x_N
			ReVolt.Track.AINodePriority.Slowdown30, //c_l_x_2_N
			ReVolt.Track.AINodePriority.RacingLine, //c_l_xt
			ReVolt.Track.AINodePriority.RacingLine, //c_l_xt_2
			ReVolt.Track.AINodePriority.RacingLine, //c_l_xt_LH
			ReVolt.Track.AINodePriority.RacingLine, //c_l_xt_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //c_l_xt_N
			ReVolt.Track.AINodePriority.RacingLine, //c_l_xt_2_N
			ReVolt.Track.AINodePriority.RacingLine, //d_r
			ReVolt.Track.AINodePriority.RacingLine, //d_x
			ReVolt.Track.AINodePriority.RacingLine, //d_xt
			ReVolt.Track.AINodePriority.RacingLine, //d_r_2
			ReVolt.Track.AINodePriority.RacingLine, //d_x_2
			ReVolt.Track.AINodePriority.RacingLine, //d_xt_2
			ReVolt.Track.AINodePriority.RacingLine, //h_r
			ReVolt.Track.AINodePriority.RacingLine, //h_x
			ReVolt.Track.AINodePriority.RacingLine, //h_xt
			ReVolt.Track.AINodePriority.RacingLine, //h_r_2
			ReVolt.Track.AINodePriority.RacingLine, //h_x_2
			ReVolt.Track.AINodePriority.RacingLine, //h_xt_2
			ReVolt.Track.AINodePriority.RacingLine, //narrow
			ReVolt.Track.AINodePriority.RacingLine, //narrowf
			ReVolt.Track.AINodePriority.RacingLine, //narrowf_2
			ReVolt.Track.AINodePriority.RacingLine, //p_(0)
			ReVolt.Track.AINodePriority.RacingLine, //p_(1)
			ReVolt.Track.AINodePriority.RacingLine, //p_(2)
			ReVolt.Track.AINodePriority.RacingLine, //p_20_(0)
			ReVolt.Track.AINodePriority.RacingLine, //p_20_(1,bot)
			ReVolt.Track.AINodePriority.RacingLine, //p_20_(1,top)
			ReVolt.Track.AINodePriority.RacingLine, //p_20_(2)
			ReVolt.Track.AINodePriority.Slowdown15, //pc_(0)
			ReVolt.Track.AINodePriority.Slowdown15, //pc_(1)
			ReVolt.Track.AINodePriority.Slowdown15, //pc_(1a)
			ReVolt.Track.AINodePriority.Slowdown15, //pc_(2)
			ReVolt.Track.AINodePriority.RacingLine, //pf
			ReVolt.Track.AINodePriority.RacingLine, //p_(1a)
			ReVolt.Track.AINodePriority.RacingLine, //pf_out
			ReVolt.Track.AINodePriority.RacingLine, //pf_n
			ReVolt.Track.AINodePriority.RacingLine, //r_00
			ReVolt.Track.AINodePriority.RacingLine, //r_05
			ReVolt.Track.AINodePriority.RacingLine, //r_10
			ReVolt.Track.AINodePriority.RacingLine, //r_15
			ReVolt.Track.AINodePriority.RacingLine, //r_20
			ReVolt.Track.AINodePriority.RacingLine, //r_25
			ReVolt.Track.AINodePriority.RacingLine, //r_30
			ReVolt.Track.AINodePriority.RacingLine, //r_00_2
			ReVolt.Track.AINodePriority.RacingLine, //r_05_2
			ReVolt.Track.AINodePriority.RacingLine, //r_10_2
			ReVolt.Track.AINodePriority.RacingLine, //r_15_2
			ReVolt.Track.AINodePriority.RacingLine, //r_20_2
			ReVolt.Track.AINodePriority.RacingLine, //r_25_2
			ReVolt.Track.AINodePriority.RacingLine, //r_30_2
			ReVolt.Track.AINodePriority.RacingLine, //r_05_2_D
			ReVolt.Track.AINodePriority.RacingLine, //r_10_2_D
			ReVolt.Track.AINodePriority.RacingLine, //r_15_2_D
			ReVolt.Track.AINodePriority.RacingLine, //r_20_2_D
			ReVolt.Track.AINodePriority.RacingLine, //r_25_2_D
			ReVolt.Track.AINodePriority.RacingLine, //r_30_2_D
			ReVolt.Track.AINodePriority.RacingLine, //r_05_2_N
			ReVolt.Track.AINodePriority.RacingLine, //r_10_2_N
			ReVolt.Track.AINodePriority.RacingLine, //r_15_2_N
			ReVolt.Track.AINodePriority.RacingLine, //r_20_2_N
			ReVolt.Track.AINodePriority.RacingLine, //r_25_2_N
			ReVolt.Track.AINodePriority.RacingLine, //r_30_2_N
			ReVolt.Track.AINodePriority.RacingLine, //sf_01
			ReVolt.Track.AINodePriority.RacingLine, //sf_02
			ReVolt.Track.AINodePriority.RacingLine, //sf_01_2
			ReVolt.Track.AINodePriority.RacingLine, //sf_02_2
			ReVolt.Track.AINodePriority.RacingLine, //sf_01_LH
			ReVolt.Track.AINodePriority.RacingLine, //sf_02_LH
			ReVolt.Track.AINodePriority.RacingLine, //sf_01_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //sf_02_2_LH
			ReVolt.Track.AINodePriority.RacingLine, //st_02
			ReVolt.Track.AINodePriority.RacingLine, //st_04
			ReVolt.Track.AINodePriority.RacingLine, //st_02_2
			ReVolt.Track.AINodePriority.RacingLine, //st_04_2
			ReVolt.Track.AINodePriority.RacingLine, //X
			ReVolt.Track.AINodePriority.Slowdown20, //zigzag
			ReVolt.Track.AINodePriority.Slowdown20, //zigzag_2
			ReVolt.Track.AINodePriority.JumpWall,	  //jump unit
			ReVolt.Track.AINodePriority.RacingLine, //r_00_2_n
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_PIPE_SMOOTH_TURN_1X1
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_PIPE_SMOOTH_TURN_1X1
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_PIPE_SMOOTH_TURN_1X1
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_PIPE_SMOOTH_TURN_1X1
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_SMOOTH_TURN_2X2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_SMOOTH_TURN_2X2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_SMOOTH_TURN_2X2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_SMOOTH_TURN_2X2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_BOTTOM_NO_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_BOTTOM_FRONT_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_BOTTOM_BACK_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_UP_NO_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_UP_FRONT_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_UP_BACK_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_UP_BOTH_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_15_NO_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_15_FRONT_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_15_BACK_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_15_BOTH_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_10_NO_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_10_FRONT_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_10_BACK_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_10_BOTH_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_5_NO_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_5_FRONT_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_5_BACK_END
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PIPE_RAMP_5_BOTH_ENDS
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_CROSS_ROAD_05
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_CROSS_ROAD_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_CROSS_ROAD_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_SQUARE
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_SQUARE
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_UP_TURN_05
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN_10
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN_20
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_DOWN_TURN_05
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN_10
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN_20
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_BANK_SMOOTH_TURN_1X1_05
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_05
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_05
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_20
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_UP_TURN2_05
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN2_10
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN2_20
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_DOWN_TURN2_05
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN2_10
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN2_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RUMBLE_DOWN
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_ZIGZAG_MIRROR
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_ZIGZAG_MIRROR_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_ZIGZAG_HALF
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_BANK_SMOOTH_TURN_1X1_05_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_05_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_05_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_10_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_10_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_10_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_20_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_20_R
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_20_R
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_BANK_SMOOTH_TURN_1X1_05_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_05_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_05_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_10_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_10_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_10_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_20_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_20_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_20_L
			ReVolt.Track.AINodePriority.RacingLine, //TWM_FINISH
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_2
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_STRAIGHT,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_SQUARE_TURN,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_SQUARE_TURN_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_L,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_L_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_R,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_R_2,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_2,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_2,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_2,
			ReVolt.Track.AINodePriority.JumpWall, //TWM_CROSS_ROAD_HALF_PIPE,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_NARROW_SINGLE,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_OFFSET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_MIRROR,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_ZIGZAG_HALF_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_ZIGZAG_HALF_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_ZIGZAG_HALF_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_NARROW_SINGLE_CARPET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_OFFSET_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_OFFSET_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_OFFSET_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_SQUARE_TURN_CARPET,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_SQUARE_TURN_CARPET_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_CARPET,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_CARPET_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_CARPET_L,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_CARPET_L_2,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_CARPET_R,
			ReVolt.Track.AINodePriority.Slowdown30, //TWM_DOUBLE_ROUND_TURN_CARPET_R_2,
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_UP_TURN_05_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN_10_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN_20_CARPET,
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_DOWN_TURN_05_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN_10_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN_20_CARPET,
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_UP_TURN2_05_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN2_10_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_UP_TURN2_20_CARPET,
			ReVolt.Track.AINodePriority.Slowdown20, //TWM_BANK_DOWN_TURN2_05_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN2_10_CARPET,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_BANK_DOWN_TURN2_20_CARPET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_SQUARE_CARPET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_SQUARE_CARPET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RUMBLE_DOWN_CARPET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_5_TO_10_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_10_TO_20_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_NARROW_CARPET,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_R_2_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_X_2_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_XT_2_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_R_2_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_X_2_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_XT_2_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_SMALL_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_BIG_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_BIG_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_BIG_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_TOP,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_BOTTOM,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_TOP_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_TOP_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_TOP_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_BOTTOM_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_BOTTOM_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_RAMP_BOTTOM_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_SMALL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_MEDIUM,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_DIP_ROUND_BIG,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_SMALL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_MEDIUM,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_HUMP_ROUND_BIG,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_LONG,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_2SIDES,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_2SIDES_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_2SIDES_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_2SIDES_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_1SIDE,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_1SIDE_CARPET_FORWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_1SIDE_CARPET_BACKWARD,
			ReVolt.Track.AINodePriority.RacingLine, //TWM_PILLAR_1SIDE_CARPET_NEUTRAL,
			ReVolt.Track.AINodePriority.Slowdown15, //TWM_CROSS_ROAD_2_LINES,
		};


		public static readonly int[] OtherSurface = new[]
		{
			(int)ID.TWM_SPACE, //space_unit
			(int)ID.TWM_START, //start_grid
			(int)ID.TWM_SPACE_B, //space_unit
			(int)ID.TWM_BANK_05_2_N, //b_05
			(int)ID.TWM_BANK_10_2_N, //b_10
			(int)ID.TWM_BANK_20_2_N, //b_20
			(int)ID.TWM_BANK_05, //b_05_2
			(int)ID.TWM_BANK_10, //b_10_2
			(int)ID.TWM_BANK_20, //b_20_2
			(int)ID.TWM_BANK_05, //b_05_2_LH
			(int)ID.TWM_BANK_10, //b_10_2_LH
			(int)ID.TWM_BANK_20, //b_20_2_LH
			(int)ID.TWM_BANK_05, //b_05_2_N
			(int)ID.TWM_BANK_10, //b_10_2_N
			(int)ID.TWM_BANK_20, //b_20_2_N
			(int)ID.TWM_BANK_CORNER_05_2, //bc_05
			(int)ID.TWM_BANK_CORNER_10_2, //bc_10
			(int)ID.TWM_BANK_CORNER_20_2, //bc_20
			(int)ID.TWM_BANK_CORNER_05, //bc_05_2
			(int)ID.TWM_BANK_CORNER_10, //bc_10_2
			(int)ID.TWM_BANK_CORNER_20, //bc_20_2
			(int)ID.TWM_BANK_IN_05_2_N, //bino_05
			(int)ID.TWM_BANK_IN_10_2_N, //bino_10
			(int)ID.TWM_BANK_IN_20_2_N, //bino_20
			(int)ID.TWM_BANK_IN_05, //bino_05_2
			(int)ID.TWM_BANK_IN_10, //bino_10_2
			(int)ID.TWM_BANK_IN_20, //bino_20_2
			(int)ID.TWM_BANK_IN_05_2_LH_N, //bino_05_LH
			(int)ID.TWM_BANK_IN_10_2_LH_N, //bino_10_LH
			(int)ID.TWM_BANK_IN_20_2_LH_N, //bino_20_LH
			(int)ID.TWM_BANK_IN_05_LH, //bino_05_2_LH
			(int)ID.TWM_BANK_IN_10_LH, //bino_10_2_LH
			(int)ID.TWM_BANK_IN_20_LH, //bino_20_2_LH
			(int)ID.TWM_BANK_IN_05, //bino_05_2_D
			(int)ID.TWM_BANK_IN_10, //bino_10_2_D
			(int)ID.TWM_BANK_IN_20, //bino_20_2_D
			(int)ID.TWM_BANK_IN_05_LH, //bino_05_2_LH_D
			(int)ID.TWM_BANK_IN_10_LH, //bino_10_2_LH_D
			(int)ID.TWM_BANK_IN_20_LH, //bino_20_2_LH_D
			(int)ID.TWM_BANK_IN_05, //bino_05_2_N
			(int)ID.TWM_BANK_IN_10, //bino_10_2_N
			(int)ID.TWM_BANK_IN_20, //bino_20_2_N
			(int)ID.TWM_BANK_IN_05_LH, //bino_05_2_LH_N
			(int)ID.TWM_BANK_IN_10_LH, //bino_10_2_LH_N
			(int)ID.TWM_BANK_IN_20_LH, //bino_20_2_LH_N
			(int)ID.TWM_BRIDGE_10_2_N, //bridge_10
			(int)ID.TWM_BRIDGE_15_2_N, //bridge_15
			(int)ID.TWM_BRIDGE_20_2_N, //bridge_20
			(int)ID.TWM_BRIDGE_25_2_N, //bridge_25
			(int)ID.TWM_BRIDGE_30_2_N, //bridge_30
			(int)ID.TWM_BRIDGE_35_2_N, //bridge_35
			(int)ID.TWM_BRIDGE_40_2_N, //bridge_40
			(int)ID.TWM_BRIDGE_45_2_N, //bridge_45
			(int)ID.TWM_BRIDGE_50_2_N, //bridge_50
			(int)ID.TWM_BRIDGE_55_2_N, //bridge_55
			(int)ID.TWM_BRIDGE_60_2_N, //bridge_60
			(int)ID.TWM_BRIDGE_65_2_N, //bridge_65
			(int)ID.TWM_BRIDGE_70_2_N, //bridge_70
			(int)ID.TWM_BRIDGE_75_2_N, //bridge_75
			(int)ID.TWM_BRIDGE_80_2_N, //bridge_80
			(int)ID.TWM_BRIDGE_10, //bridge_10_2
			(int)ID.TWM_BRIDGE_15, //bridge_15_2
			(int)ID.TWM_BRIDGE_20, //bridge_20_2
			(int)ID.TWM_BRIDGE_25, //bridge_25_2
			(int)ID.TWM_BRIDGE_30, //bridge_30_2
			(int)ID.TWM_BRIDGE_35, //bridge_35_2
			(int)ID.TWM_BRIDGE_40, //bridge_40_2
			(int)ID.TWM_BRIDGE_45, //bridge_45_2
			(int)ID.TWM_BRIDGE_50, //bridge_50_2
			(int)ID.TWM_BRIDGE_55, //bridge_55_2
			(int)ID.TWM_BRIDGE_60, //bridge_60_2
			(int)ID.TWM_BRIDGE_65, //bridge_65_2
			(int)ID.TWM_BRIDGE_70, //bridge_70_2
			(int)ID.TWM_BRIDGE_75, //bridge_75_2
			(int)ID.TWM_BRIDGE_80, //bridge_80_2
			(int)ID.TWM_BRIDGE_10, //bridge_10_2_LH
			(int)ID.TWM_BRIDGE_15, //bridge_15_2_LH
			(int)ID.TWM_BRIDGE_20, //bridge_20_2_LH
			(int)ID.TWM_BRIDGE_25, //bridge_25_2_LH
			(int)ID.TWM_BRIDGE_30, //bridge_30_2_LH
			(int)ID.TWM_BRIDGE_35, //bridge_35_2_LH
			(int)ID.TWM_BRIDGE_40, //bridge_40_2_LH
			(int)ID.TWM_BRIDGE_45, //bridge_45_2_LH
			(int)ID.TWM_BRIDGE_50, //bridge_50_2_LH
			(int)ID.TWM_BRIDGE_55, //bridge_55_2_LH
			(int)ID.TWM_BRIDGE_60, //bridge_60_2_LH
			(int)ID.TWM_BRIDGE_65, //bridge_65_2_LH
			(int)ID.TWM_BRIDGE_70, //bridge_70_2_LH
			(int)ID.TWM_BRIDGE_75, //bridge_75_2_LH
			(int)ID.TWM_BRIDGE_80, //bridge_80_2_LH
			(int)ID.TWM_BRIDGE_10, //bridge_10_2_N
			(int)ID.TWM_BRIDGE_15, //bridge_15_2_N
			(int)ID.TWM_BRIDGE_20, //bridge_20_2_N
			(int)ID.TWM_BRIDGE_25, //bridge_25_2_N
			(int)ID.TWM_BRIDGE_30, //bridge_30_2_N
			(int)ID.TWM_BRIDGE_35, //bridge_35_2_N
			(int)ID.TWM_BRIDGE_40, //bridge_40_2_N
			(int)ID.TWM_BRIDGE_45, //bridge_45_2_N
			(int)ID.TWM_BRIDGE_50, //bridge_50_2_N
			(int)ID.TWM_BRIDGE_55, //bridge_55_2_N
			(int)ID.TWM_BRIDGE_60, //bridge_60_2_N
			(int)ID.TWM_BRIDGE_65, //bridge_65_2_N
			(int)ID.TWM_BRIDGE_70, //bridge_70_2_N
			(int)ID.TWM_BRIDGE_75, //bridge_75_2_N
			(int)ID.TWM_BRIDGE_80, //bridge_80_2_N
			(int)ID.TWM_CORNER_SQUARE_2, //c_basic
			(int)ID.TWM_CORNER_SQUARE, //c_basic_2
			(int)ID.TWM_CORNER_REGULAR_2_N, //c_l_r
			(int)ID.TWM_CORNER_REGULAR, //c_l_r_2
			(int)ID.TWM_CORNER_REGULAR_2_LH, //c_l_r_LH
			(int)ID.TWM_CORNER_REGULAR_LH, //c_l_r_2_LH
			(int)ID.TWM_CORNER_REGULAR_2_N, //c_l_r_N
			(int)ID.TWM_CORNER_REGULAR_N, //c_l_r_2_N
			(int)ID.TWM_CORNER_MEDIUM_2, //c_l_x
			(int)ID.TWM_CORNER_MEDIUM, //c_l_x_2
			(int)ID.TWM_CORNER_MEDIUM_2_LH, //c_l_x_LH
			(int)ID.TWM_CORNER_MEDIUM_LH, //c_l_x_2_LH
			(int)ID.TWM_CORNER_MEDIUM_2_N, //c_l_x_N
			(int)ID.TWM_CORNER_MEDIUM_N, //c_l_x_2_N
			(int)ID.TWM_CORNER_LARGE_2, //c_l_xt
			(int)ID.TWM_CORNER_LARGE, //c_l_xt_2
			(int)ID.TWM_CORNER_LARGE_2_LH, //c_l_xt_LH
			(int)ID.TWM_CORNER_LARGE_LH, //c_l_xt_2_LH
			(int)ID.TWM_CORNER_LARGE_2_N, //c_l_xt_N
			(int)ID.TWM_CORNER_LARGE_N, //c_l_xt_2_N
			(int)ID.TWM_DIP_R_2, //d_r
			(int)ID.TWM_DIP_X_2, //d_x
			(int)ID.TWM_DIP_XT_2, //d_xt
			(int)ID.TWM_DIP_R, //d_r_2
			(int)ID.TWM_DIP_X, //d_x_2
			(int)ID.TWM_DIP_XT, //d_xt_2
			(int)ID.TWM_HUMP_R_2, //h_r
			(int)ID.TWM_HUMP_X_2, //h_x
			(int)ID.TWM_HUMP_XT_2, //h_xt
			(int)ID.TWM_HUMP_R, //h_r_2
			(int)ID.TWM_HUMP_X, //h_x_2
			(int)ID.TWM_HUMP_XT, //h_xt_2
			(int)ID.TWM_NARROW_CARPET, //narrow
			(int)ID.TWM_NARROWF_2, //narrowf
			(int)ID.TWM_NARROWF, //narrowf_2
			(int)ID.TWM_PIPE_0, //p_(0)
			(int)ID.TWM_PIPE_1, //p_(1)
			(int)ID.TWM_PIPE_2, //p_(2)
			(int)ID.TWM_PIPE_20_0, //p_20_(0)
			(int)ID.TWM_PIPE_20_1_BOT, //p_20_(1,bot)
			(int)ID.TWM_PIPE_20_1_TOP, //p_20_(1,top)
			(int)ID.TWM_PIPE_20_2, //p_20_(2)
			(int)ID.TWM_PIPEC_0, //pc_(0)
			(int)ID.TWM_PIPEC_1, //pc_(1)
			(int)ID.TWM_PIPEC_1A, //pc_(1a)
			(int)ID.TWM_PIPEC_2, //pc_(2)
			(int)ID.TWM_PIPEF, //pf
			(int)ID.TWM_PIPE_1A, //p_(1a)
			(int)ID.TWM_PIPEF_OUT, //pf_out
			(int)ID.TWM_PIPEF_N, //pf_n
			(int)ID.TWM_RAMP_00_2_N, //r_00
			(int)ID.TWM_RAMP_05_2_N, //r_05
			(int)ID.TWM_RAMP_10_2_N, //r_10
			(int)ID.TWM_RAMP_15_2_N, //r_15
			(int)ID.TWM_RAMP_20_2_N, //r_20
			(int)ID.TWM_RAMP_25_2_N, //r_25
			(int)ID.TWM_RAMP_30_2_N, //r_30
			(int)ID.TWM_RAMP_00, //r_00_2
			(int)ID.TWM_RAMP_05, //r_05_2
			(int)ID.TWM_RAMP_10, //r_10_2
			(int)ID.TWM_RAMP_15, //r_15_2
			(int)ID.TWM_RAMP_20, //r_20_2
			(int)ID.TWM_RAMP_25, //r_25_2
			(int)ID.TWM_RAMP_30, //r_30_2
			(int)ID.TWM_RAMP_05, //r_05_2_D
			(int)ID.TWM_RAMP_10, //r_10_2_D
			(int)ID.TWM_RAMP_15, //r_15_2_D
			(int)ID.TWM_RAMP_20, //r_20_2_D
			(int)ID.TWM_RAMP_25, //r_25_2_D
			(int)ID.TWM_RAMP_30, //r_30_2_D
			(int)ID.TWM_RAMP_05, //r_05_2_N
			(int)ID.TWM_RAMP_10, //r_10_2_N
			(int)ID.TWM_RAMP_15, //r_15_2_N
			(int)ID.TWM_RAMP_20, //r_20_2_N
			(int)ID.TWM_RAMP_25, //r_25_2_N
			(int)ID.TWM_RAMP_30, //r_30_2_N
			(int)ID.TWM_DIAGONAL_01_2, //sf_01
			(int)ID.TWM_DIAGONAL_02_2, //sf_02
			(int)ID.TWM_DIAGONAL_01, //sf_01_2
			(int)ID.TWM_DIAGONAL_02, //sf_02_2
			(int)ID.TWM_DIAGONAL_01_2_LH, //sf_01_LH
			(int)ID.TWM_DIAGONAL_02_2_LH, //sf_02_LH
			(int)ID.TWM_DIAGONAL_01_LH, //sf_01_2_LH
			(int)ID.TWM_DIAGONAL_02_LH, //sf_02_2_LH
			(int)ID.TWM_RUMBLE_02_2, //st_02
			(int)ID.TWM_RUMBLE_04_2, //st_04
			(int)ID.TWM_RUMBLE_02, //st_02_2
			(int)ID.TWM_RUMBLE_04, //st_04_2
			(int)ID.TWM_CROSS_ROAD, //X
			(int)ID.TWM_ZIGZAG_2, //zigzag
			(int)ID.TWM_ZIGZAG, //zigzag_2
			(int)ID.TWM_JUMP,	  //jump unit
			(int)ID.TWM_RAMP_00, //r_00_2_n
			(int)ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS,	// TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS
			(int)ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END,	// TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END
			(int)ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END,	// TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END
			(int)ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS,	// TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS
			(int)ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,	// TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS
			(int)ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END,	// TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END
			(int)ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END,	// TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END
			(int)ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,	// TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS
			(int)ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS,	// TWM_PIPE_RAMP_BOTTOM_NO_ENDS
			(int)ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END,	// TWM_PIPE_RAMP_BOTTOM_FRONT_END
			(int)ID.TWM_PIPE_RAMP_BOTTOM_BACK_END,	// TWM_PIPE_RAMP_BOTTOM_BACK_END
			(int)ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,	// TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS
			(int)ID.TWM_PIPE_RAMP_UP_NO_ENDS,	// TWM_PIPE_RAMP_UP_NO_ENDS
			(int)ID.TWM_PIPE_RAMP_UP_FRONT_END,	// TWM_PIPE_RAMP_UP_FRONT_END
			(int)ID.TWM_PIPE_RAMP_UP_BACK_END,	// TWM_PIPE_RAMP_UP_BACK_END
			(int)ID.TWM_PIPE_RAMP_UP_BOTH_ENDS,	// TWM_PIPE_RAMP_UP_BOTH_ENDS
			(int)ID.TWM_PIPE_RAMP_15_NO_ENDS,	// TWM_PIPE_RAMP_15_NO_ENDS
			(int)ID.TWM_PIPE_RAMP_15_FRONT_END,	// TWM_PIPE_RAMP_15_FRONT_END
			(int)ID.TWM_PIPE_RAMP_15_BACK_END,	// TWM_PIPE_RAMP_15_BACK_END
			(int)ID.TWM_PIPE_RAMP_15_BOTH_ENDS,	// TWM_PIPE_RAMP_15_BOTH_ENDS
			(int)ID.TWM_PIPE_RAMP_10_NO_ENDS,	// TWM_PIPE_RAMP_10_NO_ENDS
			(int)ID.TWM_PIPE_RAMP_10_FRONT_END,	// TWM_PIPE_RAMP_10_FRONT_END
			(int)ID.TWM_PIPE_RAMP_10_BACK_END,	// TWM_PIPE_RAMP_10_BACK_END
			(int)ID.TWM_PIPE_RAMP_10_BOTH_ENDS,	// TWM_PIPE_RAMP_10_BOTH_ENDS
			(int)ID.TWM_PIPE_RAMP_5_NO_ENDS,	// TWM_PIPE_RAMP_5_NO_ENDS
			(int)ID.TWM_PIPE_RAMP_5_FRONT_END,	// TWM_PIPE_RAMP_5_FRONT_END
			(int)ID.TWM_PIPE_RAMP_5_BACK_END,	// TWM_PIPE_RAMP_5_BACK_END
			(int)ID.TWM_PIPE_RAMP_5_BOTH_ENDS,	// TWM_PIPE_RAMP_5_BOTH_ENDS
			(int)ID.TWM_BANK_CROSS_ROAD_05,	// TWM_BANK_CROSS_ROAD_05
			(int)ID.TWM_BANK_CROSS_ROAD_10,	// TWM_BANK_CROSS_ROAD_10
			(int)ID.TWM_BANK_CROSS_ROAD_20,	// TWM_BANK_CROSS_ROAD_20
			(int)ID.TWM_HUMP_SQUARE_CARPET,	// TWM_HUMP_SQUARE
			(int)ID.TWM_DIP_SQUARE_CARPET,	// TWM_DIP_SQUARE
			(int)ID.TWM_BANK_UP_TURN_05_CARPET,	// TWM_BANK_UP_TURN_05
			(int)ID.TWM_BANK_UP_TURN_10_CARPET,	// TWM_BANK_UP_TURN_10
			(int)ID.TWM_BANK_UP_TURN_20_CARPET,	// TWM_BANK_UP_TURN_20
			(int)ID.TWM_BANK_DOWN_TURN_05_CARPET,	// TWM_BANK_DOWN_TURN_05
			(int)ID.TWM_BANK_DOWN_TURN_10_CARPET,	// TWM_BANK_DOWN_TURN_10
			(int)ID.TWM_BANK_DOWN_TURN_20_CARPET,	// TWM_BANK_DOWN_TURN_20
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_1X1_05
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_2X2_05
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_3X3_05
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_1X1_10
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_2X2_10
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_3X3_10
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_1X1_20
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_2X2_20
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL,	// TWM_BANK_SMOOTH_TURN_3X3_20
			(int)ID.TWM_BANK_UP_TURN2_05_CARPET,	// TWM_BANK_UP_TURN2_05
			(int)ID.TWM_BANK_UP_TURN2_10_CARPET,	// TWM_BANK_UP_TURN2_10
			(int)ID.TWM_BANK_UP_TURN2_20_CARPET,	// TWM_BANK_UP_TURN2_20
			(int)ID.TWM_BANK_DOWN_TURN2_05_CARPET,	// TWM_BANK_DOWN_TURN2_05
			(int)ID.TWM_BANK_DOWN_TURN2_10_CARPET,	// TWM_BANK_DOWN_TURN2_10
			(int)ID.TWM_BANK_DOWN_TURN2_20_CARPET,	// TWM_BANK_DOWN_TURN2_20
			(int)ID.TWM_RUMBLE_DOWN_CARPET,	// TWM_RUMBLE_DOWN
			(int)ID.TWM_ZIGZAG_MIRROR_2,	// TWM_ZIGZAG_MIRROR
			(int)ID.TWM_ZIGZAG_MIRROR,	// TWM_ZIGZAG_MIRROR_2
			(int)ID.TWM_ZIGZAG_HALF_CARPET_NEUTRAL,	// TWM_ZIGZAG_HALF
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,	// TWM_BANK_SMOOTH_TURN_1X1_05_R
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,	// TWM_BANK_SMOOTH_TURN_2X2_05_R
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,	// TWM_BANK_SMOOTH_TURN_3X3_05_R
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,	// TWM_BANK_SMOOTH_TURN_1X1_10_R
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,	// TWM_BANK_SMOOTH_TURN_2X2_10_R
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,	// TWM_BANK_SMOOTH_TURN_3X3_10_R
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,	// TWM_BANK_SMOOTH_TURN_1X1_20_R
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,	// TWM_BANK_SMOOTH_TURN_2X2_20_R
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,	// TWM_BANK_SMOOTH_TURN_3X3_20_R
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,	// TWM_BANK_SMOOTH_TURN_1X1_05_L
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,	// TWM_BANK_SMOOTH_TURN_2X2_05_L
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,	// TWM_BANK_SMOOTH_TURN_3X3_05_L
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,	// TWM_BANK_SMOOTH_TURN_1X1_10_L
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,	// TWM_BANK_SMOOTH_TURN_2X2_10_L
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,	// TWM_BANK_SMOOTH_TURN_3X3_10_L
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,	// TWM_BANK_SMOOTH_TURN_1X1_20_L
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,	// TWM_BANK_SMOOTH_TURN_2X2_20_L
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,	// TWM_BANK_SMOOTH_TURN_3X3_20_L
			(int)ID.TWM_FINISH,	// TWM_FINISH
			(int)ID.TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL,	// TWM_BANK_FLAT_TO_5
			(int)ID.TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL,	// TWM_BANK_FLAT_TO_10
			(int)ID.TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL,	// TWM_BANK_FLAT_TO_20
			(int)ID.TWM_BANK_5_TO_10_CARPET_NEUTRAL,	// TWM_BANK_5_TO_10
			(int)ID.TWM_BANK_10_TO_20_CARPET_NEUTRAL,	// TWM_BANK_10_TO_20
			(int)ID.TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL,	// TWM_BANK_FLAT_TO_5_2
			(int)ID.TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL,	// TWM_BANK_FLAT_TO_10_2
			(int)ID.TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL,	// TWM_BANK_FLAT_TO_20_2
			(int)ID.TWM_BANK_5_TO_10_2_CARPET_NEUTRAL,	// TWM_BANK_5_TO_10_2
			(int)ID.TWM_BANK_10_TO_20_2_CARPET_NEUTRAL,	// TWM_BANK_10_TO_20_2
			(int)ID.TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_UP5
			(int)ID.TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_2
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_UP5_2
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_BANK_5
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_BANK_10
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_BANK_20
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_BANK_5_2
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_BANK_10_2
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL,	// TWM_DIAGONAL_SMOOTH_BANK_20_2
			(int)ID.TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL,	// TWM_DOUBLE_STRAIGHT
			(int)ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL,	// TWM_DOUBLE_SIDE_ENTRY
			(int)ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL,	// TWM_DOUBLE_SIDE_ENTRY_2
			(int)ID.TWM_DOUBLE_SQUARE_TURN_CARPET,	// TWM_DOUBLE_SQUARE_TURN
			(int)ID.TWM_DOUBLE_SQUARE_TURN_CARPET_2,	// TWM_DOUBLE_SQUARE_TURN_2
			(int)ID.TWM_DOUBLE_ROUND_TURN_CARPET,	// TWM_DOUBLE_ROUND_TURN
			(int)ID.TWM_DOUBLE_ROUND_TURN_CARPET_2,	// TWM_DOUBLE_ROUND_TURN_2
			(int)ID.TWM_DOUBLE_ROUND_TURN_CARPET_L,	// TWM_DOUBLE_ROUND_TURN_L
			(int)ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2,	// TWM_DOUBLE_ROUND_TURN_L_2
			(int)ID.TWM_DOUBLE_ROUND_TURN_CARPET_R,	// TWM_DOUBLE_ROUND_TURN_R
			(int)ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2,	// TWM_DOUBLE_ROUND_TURN_R_2
			(int)ID.TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL,	// TWM_BANK_SWITCH_5_TO_5
			(int)ID.TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL,	// TWM_BANK_SWITCH_10_TO_10
			(int)ID.TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL,	// TWM_BANK_SWITCH_20_TO_20
			(int)ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL,	// TWM_BANK_SWITCH_5_TO_5_2
			(int)ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL,	// TWM_BANK_SWITCH_10_TO_10_2
			(int)ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL,	// TWM_BANK_SWITCH_20_TO_20_2
			(int)ID.TWM_CROSS_ROAD_HALF_PIPE,	// TWM_CROSS_ROAD_HALF_PIPE
			(int)ID.TWM_NARROW_SINGLE_CARPET,	// TWM_NARROW_SINGLE
			(int)ID.TWM_PILLAR_CENTER_CARPET_NEUTRAL,	// TWM_PILLAR_CENTER
			(int)ID.TWM_PILLAR_OFFSET_CARPET_NEUTRAL,	// TWM_PILLAR_OFFSET
			(int)ID.TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL,	// TWM_PILLAR_ZIGZAG
			(int)ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL,	// TWM_PILLAR_ZIGZAG_MIRROR
			(int)ID.TWM_ZIGZAG_HALF,	// TWM_ZIGZAG_HALF_CARPET_FORWARD
			(int)ID.TWM_ZIGZAG_HALF,	// TWM_ZIGZAG_HALF_CARPET_BACKWARD
			(int)ID.TWM_ZIGZAG_HALF,	// TWM_ZIGZAG_HALF_CARPET_NEUTRAL
			(int)ID.TWM_NARROW_SINGLE,	// TWM_NARROW_SINGLE_CARPET
			(int)ID.TWM_PILLAR_CENTER,	// TWM_PILLAR_CENTER_CARPET_FORWARD
			(int)ID.TWM_PILLAR_CENTER,	// TWM_PILLAR_CENTER_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_CENTER,	// TWM_PILLAR_CENTER_CARPET_NEUTRAL
			(int)ID.TWM_PILLAR_OFFSET,	// TWM_PILLAR_OFFSET_CARPET_FORWARD
			(int)ID.TWM_PILLAR_OFFSET,	// TWM_PILLAR_OFFSET_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_OFFSET,	// TWM_PILLAR_OFFSET_CARPET_NEUTRAL
			(int)ID.TWM_PILLAR_ZIGZAG,	// TWM_PILLAR_ZIGZAG_CARPET_FORWARD
			(int)ID.TWM_PILLAR_ZIGZAG,	// TWM_PILLAR_ZIGZAG_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_ZIGZAG,	// TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL
			(int)ID.TWM_PILLAR_ZIGZAG_MIRROR,	// TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD
			(int)ID.TWM_PILLAR_ZIGZAG_MIRROR,	// TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_ZIGZAG_MIRROR,	// TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_05_R,	// TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_05_R,	// TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_05_R,	// TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_10_R,	// TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_10_R,	// TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_10_R,	// TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_20_R,	// TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_20_R,	// TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_20_R,	// TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_05_L,	// TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_05_L,	// TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_05_L,	// TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_10_L,	// TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_10_L,	// TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_10_L,	// TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_20_L,	// TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_20_L,	// TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_20_L,	// TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_05,	// TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_05,	// TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_05,	// TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_10,	// TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_10,	// TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_10,	// TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_1X1_20,	// TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_2X2_20,	// TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SMOOTH_TURN_3X3_20,	// TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL
			(int)ID.TWM_DOUBLE_STRAIGHT,	// TWM_DOUBLE_STRAIGHT_CARPET_FORWARD
			(int)ID.TWM_DOUBLE_STRAIGHT,	// TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD
			(int)ID.TWM_DOUBLE_STRAIGHT,	// TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL
			(int)ID.TWM_DOUBLE_SIDE_ENTRY,	// TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD
			(int)ID.TWM_DOUBLE_SIDE_ENTRY,	// TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD
			(int)ID.TWM_DOUBLE_SIDE_ENTRY,	// TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL
			(int)ID.TWM_DOUBLE_SIDE_ENTRY_2,	// TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD
			(int)ID.TWM_DOUBLE_SIDE_ENTRY_2,	// TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD
			(int)ID.TWM_DOUBLE_SIDE_ENTRY_2,	// TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL
			(int)ID.TWM_DOUBLE_SQUARE_TURN,	// TWM_DOUBLE_SQUARE_TURN_CARPET
			(int)ID.TWM_DOUBLE_SQUARE_TURN_2,	// TWM_DOUBLE_SQUARE_TURN_CARPET_2
			(int)ID.TWM_DOUBLE_ROUND_TURN,	// TWM_DOUBLE_ROUND_TURN_CARPET
			(int)ID.TWM_DOUBLE_ROUND_TURN_2,	// TWM_DOUBLE_ROUND_TURN_CARPET_2
			(int)ID.TWM_DOUBLE_ROUND_TURN_L,	// TWM_DOUBLE_ROUND_TURN_CARPET_L
			(int)ID.TWM_DOUBLE_ROUND_TURN_L_2,	// TWM_DOUBLE_ROUND_TURN_CARPET_L_2
			(int)ID.TWM_DOUBLE_ROUND_TURN_R,	// TWM_DOUBLE_ROUND_TURN_CARPET_R
			(int)ID.TWM_DOUBLE_ROUND_TURN_R_2,	// TWM_DOUBLE_ROUND_TURN_CARPET_R_2
			(int)ID.TWM_BANK_UP_TURN_05,	// TWM_BANK_UP_TURN_05_CARPET
			(int)ID.TWM_BANK_UP_TURN_10,	// TWM_BANK_UP_TURN_10_CARPET
			(int)ID.TWM_BANK_UP_TURN_20,	// TWM_BANK_UP_TURN_20_CARPET
			(int)ID.TWM_BANK_DOWN_TURN_05,	// TWM_BANK_DOWN_TURN_05_CARPET
			(int)ID.TWM_BANK_DOWN_TURN_10,	// TWM_BANK_DOWN_TURN_10_CARPET
			(int)ID.TWM_BANK_DOWN_TURN_20,	// TWM_BANK_DOWN_TURN_20_CARPET
			(int)ID.TWM_BANK_UP_TURN2_05,	// TWM_BANK_UP_TURN2_05_CARPET
			(int)ID.TWM_BANK_UP_TURN2_10,	// TWM_BANK_UP_TURN2_10_CARPET
			(int)ID.TWM_BANK_UP_TURN2_20,	// TWM_BANK_UP_TURN2_20_CARPET
			(int)ID.TWM_BANK_DOWN_TURN2_05,	// TWM_BANK_DOWN_TURN2_05_CARPET
			(int)ID.TWM_BANK_DOWN_TURN2_10,	// TWM_BANK_DOWN_TURN2_10_CARPET
			(int)ID.TWM_BANK_DOWN_TURN2_20,	// TWM_BANK_DOWN_TURN2_20_CARPET
			(int)ID.TWM_HUMP_SQUARE,	// TWM_HUMP_SQUARE_CARPET
			(int)ID.TWM_DIP_SQUARE,	// TWM_DIP_SQUARE_CARPET
			(int)ID.TWM_RUMBLE_DOWN,	// TWM_RUMBLE_DOWN_CARPET
			(int)ID.TWM_BANK_FLAT_TO_5,	// TWM_BANK_FLAT_TO_5_CARPET_FORWARD
			(int)ID.TWM_BANK_FLAT_TO_10,	// TWM_BANK_FLAT_TO_10_CARPET_FORWARD
			(int)ID.TWM_BANK_FLAT_TO_20,	// TWM_BANK_FLAT_TO_20_CARPET_FORWARD
			(int)ID.TWM_BANK_5_TO_10,	// TWM_BANK_5_TO_10_CARPET_FORWARD
			(int)ID.TWM_BANK_10_TO_20,	// TWM_BANK_10_TO_20_CARPET_FORWARD
			(int)ID.TWM_BANK_FLAT_TO_5_2,	// TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD
			(int)ID.TWM_BANK_FLAT_TO_10_2,	// TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD
			(int)ID.TWM_BANK_FLAT_TO_20_2,	// TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD
			(int)ID.TWM_BANK_5_TO_10_2,	// TWM_BANK_5_TO_10_2_CARPET_FORWARD
			(int)ID.TWM_BANK_10_TO_20_2,	// TWM_BANK_10_TO_20_2_CARPET_FORWARD
			(int)ID.TWM_BANK_SWITCH_5_TO_5,	// TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD
			(int)ID.TWM_BANK_SWITCH_10_TO_10,	// TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD
			(int)ID.TWM_BANK_SWITCH_20_TO_20,	// TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD
			(int)ID.TWM_BANK_SWITCH_5_TO_5_2,	// TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD
			(int)ID.TWM_BANK_SWITCH_10_TO_10_2,	// TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD
			(int)ID.TWM_BANK_SWITCH_20_TO_20_2,	// TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD
			(int)ID.TWM_BANK_FLAT_TO_5,	// TWM_BANK_FLAT_TO_5_CARPET_BACKWARD
			(int)ID.TWM_BANK_FLAT_TO_10,	// TWM_BANK_FLAT_TO_10_CARPET_BACKWARD
			(int)ID.TWM_BANK_FLAT_TO_20,	// TWM_BANK_FLAT_TO_20_CARPET_BACKWARD
			(int)ID.TWM_BANK_5_TO_10,	// TWM_BANK_5_TO_10_CARPET_BACKWARD
			(int)ID.TWM_BANK_10_TO_20,	// TWM_BANK_10_TO_20_CARPET_BACKWARD
			(int)ID.TWM_BANK_FLAT_TO_5_2,	// TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_FLAT_TO_10_2,	// TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_FLAT_TO_20_2,	// TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_5_TO_10_2,	// TWM_BANK_5_TO_10_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_10_TO_20_2,	// TWM_BANK_10_TO_20_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_SWITCH_5_TO_5,	// TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD
			(int)ID.TWM_BANK_SWITCH_10_TO_10,	// TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD
			(int)ID.TWM_BANK_SWITCH_20_TO_20,	// TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD
			(int)ID.TWM_BANK_SWITCH_5_TO_5_2,	// TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_SWITCH_10_TO_10_2,	// TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_SWITCH_20_TO_20_2,	// TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD
			(int)ID.TWM_BANK_FLAT_TO_5,	// TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL
			(int)ID.TWM_BANK_FLAT_TO_10,	// TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL
			(int)ID.TWM_BANK_FLAT_TO_20,	// TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL
			(int)ID.TWM_BANK_5_TO_10,	// TWM_BANK_5_TO_10_CARPET_NEUTRAL
			(int)ID.TWM_BANK_10_TO_20,	// TWM_BANK_10_TO_20_CARPET_NEUTRAL
			(int)ID.TWM_BANK_FLAT_TO_5_2,	// TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_FLAT_TO_10_2,	// TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_FLAT_TO_20_2,	// TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_5_TO_10_2,	// TWM_BANK_5_TO_10_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_10_TO_20_2,	// TWM_BANK_10_TO_20_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SWITCH_5_TO_5,	// TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SWITCH_10_TO_10,	// TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SWITCH_20_TO_20,	// TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SWITCH_5_TO_5_2,	// TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SWITCH_10_TO_10_2,	// TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL
			(int)ID.TWM_BANK_SWITCH_20_TO_20_2,	// TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH,	// TWM_DIAGONAL_SMOOTH_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5,	// TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_2,	// TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5_2,	// TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5,	// TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10,	// TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20,	// TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	// TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	// TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	// TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD
			(int)ID.TWM_DIAGONAL_SMOOTH,	// TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5,	// TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_2,	// TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5_2,	// TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5,	// TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10,	// TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20,	// TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	// TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	// TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	// TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD
			(int)ID.TWM_DIAGONAL_SMOOTH,	// TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5,	// TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_2,	// TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_UP5_2,	// TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5,	// TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10,	// TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20,	// TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	// TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	// TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL
			(int)ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	// TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL
			(int)ID.TWM_NARROW,	// TWM_NARROW_CARPET
			(int)ID.TWM_DIP_R,	// TWM_DIP_R_2_FORWARD
			(int)ID.TWM_DIP_X,	// TWM_DIP_X_2_FORWARD
			(int)ID.TWM_DIP_XT,	// TWM_DIP_XT_2_FORWARD
			(int)ID.TWM_HUMP_R,	// TWM_HUMP_R_2_FORWARD
			(int)ID.TWM_HUMP_X,	// TWM_HUMP_X_2_FORWARD
			(int)ID.TWM_HUMP_XT,	// TWM_HUMP_XT_2_FORWARD
			(int)ID.TWM_DIP_ROUND_SMALL,	// TWM_DIP_ROUND_SMALL_CARPET_FORWARD
			(int)ID.TWM_DIP_ROUND_MEDIUM,	// TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD
			(int)ID.TWM_DIP_ROUND_BIG,	// TWM_DIP_ROUND_BIG_CARPET_FORWARD
			(int)ID.TWM_DIP_ROUND_SMALL,	// TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL
			(int)ID.TWM_DIP_ROUND_MEDIUM,	// TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL
			(int)ID.TWM_DIP_ROUND_BIG,	// TWM_DIP_ROUND_BIG_CARPET_NEUTRAL
			(int)ID.TWM_HUMP_ROUND_SMALL,	// TWM_HUMP_ROUND_SMALL_CARPET_FORWARD
			(int)ID.TWM_HUMP_ROUND_MEDIUM,	// TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD
			(int)ID.TWM_HUMP_ROUND_BIG,	// TWM_HUMP_ROUND_BIG_CARPET_FORWARD
			(int)ID.TWM_HUMP_ROUND_SMALL,	// TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL
			(int)ID.TWM_HUMP_ROUND_MEDIUM,	// TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL
			(int)ID.TWM_HUMP_ROUND_BIG,	// TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL
			(int)ID.TWM_RAMP_TOP_CARPET_NEUTRAL,	// TWM_RAMP_TOP
			(int)ID.TWM_RAMP_BOTTOM_CARPET_NEUTRAL,	// TWM_RAMP_BOTTOM
			(int)ID.TWM_RAMP_TOP,	// TWM_RAMP_TOP_CARPET_FORWARD
			(int)ID.TWM_RAMP_TOP,	// TWM_RAMP_TOP_CARPET_BACKWARD
			(int)ID.TWM_RAMP_TOP,	// TWM_RAMP_TOP_CARPET_NEUTRAL
			(int)ID.TWM_RAMP_BOTTOM,	// TWM_RAMP_BOTTOM_CARPET_FORWARD
			(int)ID.TWM_RAMP_BOTTOM,	// TWM_RAMP_BOTTOM_CARPET_BACKWARD
			(int)ID.TWM_RAMP_BOTTOM,	// TWM_RAMP_BOTTOM_CARPET_NEUTRAL
			(int)ID.TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL,	// TWM_DIP_ROUND_SMALL
			(int)ID.TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL,	// TWM_DIP_ROUND_MEDIUM
			(int)ID.TWM_DIP_ROUND_BIG_CARPET_NEUTRAL,	// TWM_DIP_ROUND_BIG
			(int)ID.TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL,	// TWM_HUMP_ROUND_SMALL
			(int)ID.TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL,	// TWM_HUMP_ROUND_MEDIUM
			(int)ID.TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL,	// TWM_HUMP_ROUND_BIG
			(int)ID.TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL,	// TWM_PILLAR_CENTER_LONG
			(int)ID.TWM_PILLAR_CENTER_LONG,	// TWM_PILLAR_CENTER_LONG_CARPET_FORWARD
			(int)ID.TWM_PILLAR_CENTER_LONG,	// TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_CENTER_LONG,	// TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL
			(int)ID.TWM_PILLAR_2SIDES_CARPET_NEUTRAL,	// TWM_PILLAR_2SIDES
			(int)ID.TWM_PILLAR_2SIDES,	// TWM_PILLAR_2SIDES_CARPET_FORWARD
			(int)ID.TWM_PILLAR_2SIDES,	// TWM_PILLAR_2SIDES_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_2SIDES,	// TWM_PILLAR_2SIDES_CARPET_NEUTRAL
			(int)ID.TWM_PILLAR_1SIDE_CARPET_NEUTRAL,	// TWM_PILLAR_1SIDE
			(int)ID.TWM_PILLAR_1SIDE,	// TWM_PILLAR_1SIDE_CARPET_FORWARD
			(int)ID.TWM_PILLAR_1SIDE,	// TWM_PILLAR_1SIDE_CARPET_BACKWARD
			(int)ID.TWM_PILLAR_1SIDE,	// TWM_PILLAR_1SIDE_CARPET_NEUTRAL
			(int)ID.TWM_CROSS_ROAD_2_LINES,	//TWM_CROSS_ROAD_2_LINES
		};

		// Order matters and number matters!!! Each entry needs to match module ID
		// (Base module (neutral direction), Previous modules in category (if no previous: Base module), Next module in category (if no previous: Base module), Forward direction (if no direction: Base module), Backward direction (if no direction: Base module)(may use Forward here too if can be reversed by 180 turn))
		// If module not referenced in category (only a directional variation), only Base module is relevant. Leave everything else to Base module too is fine.
		public static readonly ModuleChanges[] Changes = new[]{
			new ModuleChanges(ID.TWM_SPACE, ID.TWM_SPACE, ID.TWM_SPACE, ID.TWM_SPACE_B, ID.TWM_SPACE_B), //space_unit

			new ModuleChanges(ID.TWM_START, ID.TWM_START, ID.TWM_FINISH, ID.TWM_START, ID.TWM_START), //start_grid

			new ModuleChanges(ID.TWM_SPACE_B, ID.TWM_SPACE_B, ID.TWM_SPACE_B, ID.TWM_SPACE_B, ID.TWM_SPACE_B), //SPACE_B_unit

			new ModuleChanges(ID.TWM_BANK_05, ID.TWM_BANK_IN_20, ID.TWM_BANK_10, ID.TWM_BANK_05, ID.TWM_BANK_05), //b_05
			new ModuleChanges(ID.TWM_BANK_10, ID.TWM_BANK_05, ID.TWM_BANK_20, ID.TWM_BANK_10, ID.TWM_BANK_10), //b_10
			new ModuleChanges(ID.TWM_BANK_20, ID.TWM_BANK_10, ID.TWM_BANK_IN_05_LH, ID.TWM_BANK_20, ID.TWM_BANK_20), //b_20

			new ModuleChanges(ID.TWM_BANK_05_2, ID.TWM_BANK_IN_20_2, ID.TWM_BANK_10_2, ID.TWM_BANK_05_2, ID.TWM_BANK_05_2), //b_05_2
			new ModuleChanges(ID.TWM_BANK_10_2, ID.TWM_BANK_05_2, ID.TWM_BANK_20_2, ID.TWM_BANK_10_2, ID.TWM_BANK_10_2), //b_10_2
			new ModuleChanges(ID.TWM_BANK_20_2, ID.TWM_BANK_10_2, ID.TWM_BANK_IN_05_2, ID.TWM_BANK_20_2, ID.TWM_BANK_20_2), //b_20_2

			new ModuleChanges(ID.TWM_BANK_05_2_LH, ID.TWM_BANK_05_2_LH, ID.TWM_BANK_10_2_LH, ID.TWM_BANK_05_2_LH, ID.TWM_BANK_05_2_LH), //b_05_2_LH
			new ModuleChanges(ID.TWM_BANK_10_2_LH, ID.TWM_BANK_05_2_LH, ID.TWM_BANK_20_2_LH, ID.TWM_BANK_10_2_LH, ID.TWM_BANK_10_2_LH), //b_10_2_LH
			new ModuleChanges(ID.TWM_BANK_20_2_LH, ID.TWM_BANK_10_2_LH, ID.TWM_BANK_20_2_LH, ID.TWM_BANK_20_2_LH, ID.TWM_BANK_20_2_LH), //b_20_2_LH

			new ModuleChanges(ID.TWM_BANK_05_2_N, ID.TWM_BANK_IN_20_2_N, ID.TWM_BANK_10_2_N, ID.TWM_BANK_05_2, ID.TWM_BANK_05_2_LH), //b_05_2_N
			new ModuleChanges(ID.TWM_BANK_10_2_N, ID.TWM_BANK_05_2_N, ID.TWM_BANK_20_2_N, ID.TWM_BANK_10_2, ID.TWM_BANK_10_2_LH), //b_10_2_N
			new ModuleChanges(ID.TWM_BANK_20_2_N, ID.TWM_BANK_10_2_N, ID.TWM_BANK_IN_05_2_LH_N, ID.TWM_BANK_20_2, ID.TWM_BANK_20_2_LH), //b_20_2_N

			new ModuleChanges(ID.TWM_BANK_CORNER_05, ID.TWM_BANK_IN_20_LH, ID.TWM_BANK_CORNER_10, ID.TWM_BANK_CORNER_05, ID.TWM_BANK_CORNER_05), //bc_05
			new ModuleChanges(ID.TWM_BANK_CORNER_10, ID.TWM_BANK_CORNER_05, ID.TWM_BANK_CORNER_20, ID.TWM_BANK_CORNER_10, ID.TWM_BANK_CORNER_10), //bc_10
			new ModuleChanges(ID.TWM_BANK_CORNER_20, ID.TWM_BANK_CORNER_10, ID.TWM_BANK_SMOOTH_TURN_1X1_05, ID.TWM_BANK_CORNER_20, ID.TWM_BANK_CORNER_20), //bc_20

			new ModuleChanges(ID.TWM_BANK_CORNER_05_2, ID.TWM_BANK_IN_20_2_LH_N, ID.TWM_BANK_CORNER_10_2, ID.TWM_BANK_CORNER_05_2, ID.TWM_BANK_CORNER_05_2), //bc_05_2
			new ModuleChanges(ID.TWM_BANK_CORNER_10_2, ID.TWM_BANK_CORNER_05_2, ID.TWM_BANK_CORNER_20_2, ID.TWM_BANK_CORNER_10_2, ID.TWM_BANK_CORNER_10_2), //bc_10_2
			new ModuleChanges(ID.TWM_BANK_CORNER_20_2, ID.TWM_BANK_CORNER_10_2, ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL, ID.TWM_BANK_CORNER_20_2, ID.TWM_BANK_CORNER_20_2), //bc_20_2

			new ModuleChanges(ID.TWM_BANK_IN_05, ID.TWM_BANK_UP_TURN_20, ID.TWM_BANK_IN_10, ID.TWM_BANK_IN_05, ID.TWM_BANK_IN_05), //bino_05
			new ModuleChanges(ID.TWM_BANK_IN_10, ID.TWM_BANK_IN_05, ID.TWM_BANK_IN_20, ID.TWM_BANK_IN_10, ID.TWM_BANK_IN_10), //bino_10
			new ModuleChanges(ID.TWM_BANK_IN_20, ID.TWM_BANK_IN_10, ID.TWM_BANK_05, ID.TWM_BANK_IN_20, ID.TWM_BANK_IN_20), //bino_20

			new ModuleChanges(ID.TWM_BANK_IN_05_2, ID.TWM_BANK_IN_05_2, ID.TWM_BANK_IN_10_2, ID.TWM_BANK_IN_05_2, ID.TWM_BANK_IN_05_2), //bino_05
			new ModuleChanges(ID.TWM_BANK_IN_10_2, ID.TWM_BANK_IN_05_2, ID.TWM_BANK_IN_20_2, ID.TWM_BANK_IN_10_2, ID.TWM_BANK_IN_10_2), //bino_10
			new ModuleChanges(ID.TWM_BANK_IN_20_2, ID.TWM_BANK_IN_10_2, ID.TWM_BANK_05_2, ID.TWM_BANK_IN_20_2, ID.TWM_BANK_IN_20_2), //bino_20

			new ModuleChanges(ID.TWM_BANK_IN_05_LH, ID.TWM_BANK_20, ID.TWM_BANK_IN_10_LH, ID.TWM_BANK_IN_05_LH, ID.TWM_BANK_IN_05_LH), //bino_05_LH
			new ModuleChanges(ID.TWM_BANK_IN_10_LH, ID.TWM_BANK_IN_05_LH, ID.TWM_BANK_IN_20_LH, ID.TWM_BANK_IN_10_LH, ID.TWM_BANK_IN_10_LH), //bino_10_LH
			new ModuleChanges(ID.TWM_BANK_IN_20_LH, ID.TWM_BANK_IN_10_LH, ID.TWM_BANK_CORNER_05, ID.TWM_BANK_IN_20_LH, ID.TWM_BANK_IN_20_LH), //bino_20_LH

			new ModuleChanges(ID.TWM_BANK_IN_05_2_LH, ID.TWM_BANK_20, ID.TWM_BANK_IN_10_2_LH, ID.TWM_BANK_IN_05_2_LH, ID.TWM_BANK_IN_05_2_LH), //bino_05_2_LH
			new ModuleChanges(ID.TWM_BANK_IN_10_2_LH, ID.TWM_BANK_IN_05_2_LH, ID.TWM_BANK_IN_20_2_LH, ID.TWM_BANK_IN_10_2_LH, ID.TWM_BANK_IN_10_2_LH), //bino_10_2_LH
			new ModuleChanges(ID.TWM_BANK_IN_20_2_LH, ID.TWM_BANK_IN_10_2_LH, ID.TWM_BANK_CORNER_05_2, ID.TWM_BANK_IN_20_2_LH, ID.TWM_BANK_IN_20_2_LH), //bino_20_2_LH

			new ModuleChanges(ID.TWM_BANK_IN_05_2_D, ID.TWM_BANK_IN_05_2_D, ID.TWM_BANK_IN_05_2_D, ID.TWM_BANK_IN_05_2_D, ID.TWM_BANK_IN_05_2_D), //bino_05_2_D
			new ModuleChanges(ID.TWM_BANK_IN_10_2_D, ID.TWM_BANK_IN_10_2_D, ID.TWM_BANK_IN_10_2_D, ID.TWM_BANK_IN_10_2_D, ID.TWM_BANK_IN_10_2_D), //bino_10_2_D
			new ModuleChanges(ID.TWM_BANK_IN_20_2_D, ID.TWM_BANK_IN_20_2_D, ID.TWM_BANK_IN_20_2_D, ID.TWM_BANK_IN_20_2_D, ID.TWM_BANK_IN_20_2_D), //bino_20_2_D

			new ModuleChanges(ID.TWM_BANK_IN_05_2_LH_D, ID.TWM_BANK_IN_05_2_LH_D, ID.TWM_BANK_IN_05_2_LH_D, ID.TWM_BANK_IN_05_2_LH_D, ID.TWM_BANK_IN_05_2_LH_D), //bino_05_2_LH_D
			new ModuleChanges(ID.TWM_BANK_IN_10_2_LH_D, ID.TWM_BANK_IN_10_2_LH_D, ID.TWM_BANK_IN_10_2_LH_D, ID.TWM_BANK_IN_10_2_LH_D, ID.TWM_BANK_IN_10_2_LH_D), //bino_10_2_LH_D
			new ModuleChanges(ID.TWM_BANK_IN_20_2_LH_D, ID.TWM_BANK_IN_20_2_LH_D, ID.TWM_BANK_IN_20_2_LH_D, ID.TWM_BANK_IN_20_2_LH_D, ID.TWM_BANK_IN_20_2_LH_D), //bino_20_2_LH_D

			new ModuleChanges(ID.TWM_BANK_IN_05_2_N, ID.TWM_BANK_UP_TURN_20_CARPET, ID.TWM_BANK_IN_10_2_N, ID.TWM_BANK_IN_05_2, ID.TWM_BANK_IN_05_2_D), //bino_05_2_N
			new ModuleChanges(ID.TWM_BANK_IN_10_2_N, ID.TWM_BANK_IN_05_2_N, ID.TWM_BANK_IN_20_2_N, ID.TWM_BANK_IN_10_2, ID.TWM_BANK_IN_10_2_D), //bino_10_2_N
			new ModuleChanges(ID.TWM_BANK_IN_20_2_N, ID.TWM_BANK_IN_10_2_N, ID.TWM_BANK_05_2_N, ID.TWM_BANK_IN_20_2, ID.TWM_BANK_IN_20_2_D), //bino_20_2_N

			new ModuleChanges(ID.TWM_BANK_IN_05_2_LH_N, ID.TWM_BANK_20_2_N, ID.TWM_BANK_IN_10_2_LH_N, ID.TWM_BANK_IN_05_2_LH, ID.TWM_BANK_IN_05_2_LH_D), //bino_05_2_LH_N
			new ModuleChanges(ID.TWM_BANK_IN_10_2_LH_N, ID.TWM_BANK_IN_05_2_LH_N, ID.TWM_BANK_IN_20_2_LH_N, ID.TWM_BANK_IN_10_2_LH, ID.TWM_BANK_IN_10_2_LH_D), //bino_10_2_LH_N
			new ModuleChanges(ID.TWM_BANK_IN_20_2_LH_N, ID.TWM_BANK_IN_10_2_LH_N, ID.TWM_BANK_CORNER_05_2, ID.TWM_BANK_IN_20_2_LH, ID.TWM_BANK_IN_20_2_LH_D), //bino_20_2_LH_N

			new ModuleChanges(ID.TWM_BRIDGE_10, ID.TWM_BRIDGE_10, ID.TWM_BRIDGE_15, ID.TWM_BRIDGE_10, ID.TWM_BRIDGE_10), //bridge_10
			new ModuleChanges(ID.TWM_BRIDGE_15, ID.TWM_BRIDGE_10, ID.TWM_BRIDGE_20, ID.TWM_BRIDGE_15, ID.TWM_BRIDGE_15), //bridge_15
			new ModuleChanges(ID.TWM_BRIDGE_20, ID.TWM_BRIDGE_15, ID.TWM_BRIDGE_25, ID.TWM_BRIDGE_20, ID.TWM_BRIDGE_20), //bridge_20
			new ModuleChanges(ID.TWM_BRIDGE_25, ID.TWM_BRIDGE_20, ID.TWM_BRIDGE_30, ID.TWM_BRIDGE_25, ID.TWM_BRIDGE_25), //bridge_25
			new ModuleChanges(ID.TWM_BRIDGE_30, ID.TWM_BRIDGE_25, ID.TWM_BRIDGE_35, ID.TWM_BRIDGE_30, ID.TWM_BRIDGE_30), //bridge_30
			new ModuleChanges(ID.TWM_BRIDGE_35, ID.TWM_BRIDGE_30, ID.TWM_BRIDGE_40, ID.TWM_BRIDGE_35, ID.TWM_BRIDGE_35), //bridge_35
			new ModuleChanges(ID.TWM_BRIDGE_40, ID.TWM_BRIDGE_35, ID.TWM_BRIDGE_45, ID.TWM_BRIDGE_40, ID.TWM_BRIDGE_40), //bridge_40
			new ModuleChanges(ID.TWM_BRIDGE_45, ID.TWM_BRIDGE_40, ID.TWM_BRIDGE_50, ID.TWM_BRIDGE_45, ID.TWM_BRIDGE_45), //bridge_45
			new ModuleChanges(ID.TWM_BRIDGE_50, ID.TWM_BRIDGE_45, ID.TWM_BRIDGE_55, ID.TWM_BRIDGE_50, ID.TWM_BRIDGE_50), //bridge_50
			new ModuleChanges(ID.TWM_BRIDGE_55, ID.TWM_BRIDGE_50, ID.TWM_BRIDGE_60, ID.TWM_BRIDGE_55, ID.TWM_BRIDGE_55), //bridge_55
			new ModuleChanges(ID.TWM_BRIDGE_60, ID.TWM_BRIDGE_55, ID.TWM_BRIDGE_65, ID.TWM_BRIDGE_60, ID.TWM_BRIDGE_60), //bridge_60
			new ModuleChanges(ID.TWM_BRIDGE_65, ID.TWM_BRIDGE_60, ID.TWM_BRIDGE_70, ID.TWM_BRIDGE_65, ID.TWM_BRIDGE_65), //bridge_65
			new ModuleChanges(ID.TWM_BRIDGE_70, ID.TWM_BRIDGE_65, ID.TWM_BRIDGE_75, ID.TWM_BRIDGE_70, ID.TWM_BRIDGE_70), //bridge_70
			new ModuleChanges(ID.TWM_BRIDGE_75, ID.TWM_BRIDGE_70, ID.TWM_BRIDGE_80, ID.TWM_BRIDGE_75, ID.TWM_BRIDGE_75), //bridge_75
			new ModuleChanges(ID.TWM_BRIDGE_80, ID.TWM_BRIDGE_75, ID.TWM_BRIDGE_80, ID.TWM_BRIDGE_80, ID.TWM_BRIDGE_80), //bridge_80

			new ModuleChanges(ID.TWM_BRIDGE_10_2, ID.TWM_BRIDGE_10_2, ID.TWM_BRIDGE_15_2, ID.TWM_BRIDGE_10_2, ID.TWM_BRIDGE_10_2), //bridge_10_2
			new ModuleChanges(ID.TWM_BRIDGE_15_2, ID.TWM_BRIDGE_10_2, ID.TWM_BRIDGE_20_2, ID.TWM_BRIDGE_15_2, ID.TWM_BRIDGE_15_2), //bridge_15_2
			new ModuleChanges(ID.TWM_BRIDGE_20_2, ID.TWM_BRIDGE_15_2, ID.TWM_BRIDGE_25_2, ID.TWM_BRIDGE_20_2, ID.TWM_BRIDGE_20_2), //bridge_20_2
			new ModuleChanges(ID.TWM_BRIDGE_25_2, ID.TWM_BRIDGE_20_2, ID.TWM_BRIDGE_30_2, ID.TWM_BRIDGE_25_2, ID.TWM_BRIDGE_25_2), //bridge_25_2
			new ModuleChanges(ID.TWM_BRIDGE_30_2, ID.TWM_BRIDGE_25_2, ID.TWM_BRIDGE_35_2, ID.TWM_BRIDGE_30_2, ID.TWM_BRIDGE_30_2), //bridge_30_2
			new ModuleChanges(ID.TWM_BRIDGE_35_2, ID.TWM_BRIDGE_30_2, ID.TWM_BRIDGE_40_2, ID.TWM_BRIDGE_35_2, ID.TWM_BRIDGE_35_2), //bridge_35_2
			new ModuleChanges(ID.TWM_BRIDGE_40_2, ID.TWM_BRIDGE_35_2, ID.TWM_BRIDGE_45_2, ID.TWM_BRIDGE_40_2, ID.TWM_BRIDGE_40_2), //bridge_40_2
			new ModuleChanges(ID.TWM_BRIDGE_45_2, ID.TWM_BRIDGE_40_2, ID.TWM_BRIDGE_50_2, ID.TWM_BRIDGE_45_2, ID.TWM_BRIDGE_45_2), //bridge_45_2
			new ModuleChanges(ID.TWM_BRIDGE_50_2, ID.TWM_BRIDGE_45_2, ID.TWM_BRIDGE_55_2, ID.TWM_BRIDGE_50_2, ID.TWM_BRIDGE_50_2), //bridge_50_2
			new ModuleChanges(ID.TWM_BRIDGE_55_2, ID.TWM_BRIDGE_50_2, ID.TWM_BRIDGE_60_2, ID.TWM_BRIDGE_55_2, ID.TWM_BRIDGE_55_2), //bridge_55_2
			new ModuleChanges(ID.TWM_BRIDGE_60_2, ID.TWM_BRIDGE_55_2, ID.TWM_BRIDGE_65_2, ID.TWM_BRIDGE_60_2, ID.TWM_BRIDGE_60_2), //bridge_60_2
			new ModuleChanges(ID.TWM_BRIDGE_65_2, ID.TWM_BRIDGE_60_2, ID.TWM_BRIDGE_70_2, ID.TWM_BRIDGE_65_2, ID.TWM_BRIDGE_65_2), //bridge_65_2
			new ModuleChanges(ID.TWM_BRIDGE_70_2, ID.TWM_BRIDGE_65_2, ID.TWM_BRIDGE_75_2, ID.TWM_BRIDGE_70_2, ID.TWM_BRIDGE_70_2), //bridge_70_2
			new ModuleChanges(ID.TWM_BRIDGE_75_2, ID.TWM_BRIDGE_70_2, ID.TWM_BRIDGE_80_2, ID.TWM_BRIDGE_75_2, ID.TWM_BRIDGE_75_2), //bridge_75_2
			new ModuleChanges(ID.TWM_BRIDGE_80_2, ID.TWM_BRIDGE_75_2, ID.TWM_BRIDGE_80_2, ID.TWM_BRIDGE_80_2, ID.TWM_BRIDGE_80_2), //bridge_80_2

			new ModuleChanges(ID.TWM_BRIDGE_10_2_LH, ID.TWM_BRIDGE_10_2_LH, ID.TWM_BRIDGE_15_2_LH, ID.TWM_BRIDGE_10_2_LH, ID.TWM_BRIDGE_10_2_LH), //bridge_10_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_15_2_LH, ID.TWM_BRIDGE_10_2_LH, ID.TWM_BRIDGE_20_2_LH, ID.TWM_BRIDGE_15_2_LH, ID.TWM_BRIDGE_15_2_LH), //bridge_15_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_20_2_LH, ID.TWM_BRIDGE_15_2_LH, ID.TWM_BRIDGE_25_2_LH, ID.TWM_BRIDGE_20_2_LH, ID.TWM_BRIDGE_20_2_LH), //bridge_20_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_25_2_LH, ID.TWM_BRIDGE_20_2_LH, ID.TWM_BRIDGE_30_2_LH, ID.TWM_BRIDGE_25_2_LH, ID.TWM_BRIDGE_25_2_LH), //bridge_25_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_30_2_LH, ID.TWM_BRIDGE_25_2_LH, ID.TWM_BRIDGE_35_2_LH, ID.TWM_BRIDGE_30_2_LH, ID.TWM_BRIDGE_30_2_LH), //bridge_30_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_35_2_LH, ID.TWM_BRIDGE_30_2_LH, ID.TWM_BRIDGE_40_2_LH, ID.TWM_BRIDGE_35_2_LH, ID.TWM_BRIDGE_35_2_LH), //bridge_35_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_40_2_LH, ID.TWM_BRIDGE_35_2_LH, ID.TWM_BRIDGE_45_2_LH, ID.TWM_BRIDGE_40_2_LH, ID.TWM_BRIDGE_40_2_LH), //bridge_40_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_45_2_LH, ID.TWM_BRIDGE_40_2_LH, ID.TWM_BRIDGE_50_2_LH, ID.TWM_BRIDGE_45_2_LH, ID.TWM_BRIDGE_45_2_LH), //bridge_45_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_50_2_LH, ID.TWM_BRIDGE_45_2_LH, ID.TWM_BRIDGE_55_2_LH, ID.TWM_BRIDGE_50_2_LH, ID.TWM_BRIDGE_50_2_LH), //bridge_50_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_55_2_LH, ID.TWM_BRIDGE_50_2_LH, ID.TWM_BRIDGE_60_2_LH, ID.TWM_BRIDGE_55_2_LH, ID.TWM_BRIDGE_55_2_LH), //bridge_55_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_60_2_LH, ID.TWM_BRIDGE_55_2_LH, ID.TWM_BRIDGE_65_2_LH, ID.TWM_BRIDGE_60_2_LH, ID.TWM_BRIDGE_60_2_LH), //bridge_60_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_65_2_LH, ID.TWM_BRIDGE_60_2_LH, ID.TWM_BRIDGE_70_2_LH, ID.TWM_BRIDGE_65_2_LH, ID.TWM_BRIDGE_65_2_LH), //bridge_65_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_70_2_LH, ID.TWM_BRIDGE_65_2_LH, ID.TWM_BRIDGE_75_2_LH, ID.TWM_BRIDGE_70_2_LH, ID.TWM_BRIDGE_70_2_LH), //bridge_70_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_75_2_LH, ID.TWM_BRIDGE_70_2_LH, ID.TWM_BRIDGE_80_2_LH, ID.TWM_BRIDGE_75_2_LH, ID.TWM_BRIDGE_75_2_LH), //bridge_75_2_LH
			new ModuleChanges(ID.TWM_BRIDGE_80_2_LH, ID.TWM_BRIDGE_75_2_LH, ID.TWM_BRIDGE_80_2_LH, ID.TWM_BRIDGE_80_2_LH, ID.TWM_BRIDGE_80_2_LH), //bridge_80_2_LH

			new ModuleChanges(ID.TWM_BRIDGE_10_2_N, ID.TWM_BRIDGE_10_2_N, ID.TWM_BRIDGE_15_2_N, ID.TWM_BRIDGE_10_2_N, ID.TWM_BRIDGE_10_2_N), //bridge_10_2_N
			new ModuleChanges(ID.TWM_BRIDGE_15_2_N, ID.TWM_BRIDGE_10_2_N, ID.TWM_BRIDGE_20_2_N, ID.TWM_BRIDGE_15_2_N, ID.TWM_BRIDGE_15_2_N), //bridge_15_2_N
			new ModuleChanges(ID.TWM_BRIDGE_20_2_N, ID.TWM_BRIDGE_15_2_N, ID.TWM_BRIDGE_25_2_N, ID.TWM_BRIDGE_20_2_N, ID.TWM_BRIDGE_20_2_N), //bridge_20_2_N
			new ModuleChanges(ID.TWM_BRIDGE_25_2_N, ID.TWM_BRIDGE_20_2_N, ID.TWM_BRIDGE_30_2_N, ID.TWM_BRIDGE_25_2_N, ID.TWM_BRIDGE_25_2_N), //bridge_25_2_N
			new ModuleChanges(ID.TWM_BRIDGE_30_2_N, ID.TWM_BRIDGE_25_2_N, ID.TWM_BRIDGE_35_2_N, ID.TWM_BRIDGE_30_2_N, ID.TWM_BRIDGE_30_2_N), //bridge_30_2_N
			new ModuleChanges(ID.TWM_BRIDGE_35_2_N, ID.TWM_BRIDGE_30_2_N, ID.TWM_BRIDGE_40_2_N, ID.TWM_BRIDGE_35_2_N, ID.TWM_BRIDGE_35_2_N), //bridge_35_2_N
			new ModuleChanges(ID.TWM_BRIDGE_40_2_N, ID.TWM_BRIDGE_35_2_N, ID.TWM_BRIDGE_45_2_N, ID.TWM_BRIDGE_40_2_N, ID.TWM_BRIDGE_40_2_N), //bridge_40_2_N
			new ModuleChanges(ID.TWM_BRIDGE_45_2_N, ID.TWM_BRIDGE_40_2_N, ID.TWM_BRIDGE_50_2_N, ID.TWM_BRIDGE_45_2_N, ID.TWM_BRIDGE_45_2_N), //bridge_45_2_N
			new ModuleChanges(ID.TWM_BRIDGE_50_2_N, ID.TWM_BRIDGE_45_2_N, ID.TWM_BRIDGE_55_2_N, ID.TWM_BRIDGE_50_2_N, ID.TWM_BRIDGE_50_2_N), //bridge_50_2_N
			new ModuleChanges(ID.TWM_BRIDGE_55_2_N, ID.TWM_BRIDGE_50_2_N, ID.TWM_BRIDGE_60_2_N, ID.TWM_BRIDGE_55_2_N, ID.TWM_BRIDGE_55_2_N), //bridge_55_2_N
			new ModuleChanges(ID.TWM_BRIDGE_60_2_N, ID.TWM_BRIDGE_55_2_N, ID.TWM_BRIDGE_65_2_N, ID.TWM_BRIDGE_60_2_N, ID.TWM_BRIDGE_60_2_N), //bridge_60_2_N
			new ModuleChanges(ID.TWM_BRIDGE_65_2_N, ID.TWM_BRIDGE_60_2_N, ID.TWM_BRIDGE_70_2_N, ID.TWM_BRIDGE_65_2_N, ID.TWM_BRIDGE_65_2_N), //bridge_65_2_N
			new ModuleChanges(ID.TWM_BRIDGE_70_2_N, ID.TWM_BRIDGE_65_2_N, ID.TWM_BRIDGE_75_2_N, ID.TWM_BRIDGE_70_2_N, ID.TWM_BRIDGE_70_2_N), //bridge_70_2_N
			new ModuleChanges(ID.TWM_BRIDGE_75_2_N, ID.TWM_BRIDGE_70_2_N, ID.TWM_BRIDGE_80_2_N, ID.TWM_BRIDGE_75_2_N, ID.TWM_BRIDGE_75_2_N), //bridge_75_2_N
			new ModuleChanges(ID.TWM_BRIDGE_80_2_N, ID.TWM_BRIDGE_75_2_N, ID.TWM_BRIDGE_80_2_N, ID.TWM_BRIDGE_80_2_N, ID.TWM_BRIDGE_80_2_N), //bridge_80_2_N

			new ModuleChanges(ID.TWM_CORNER_SQUARE, ID.TWM_CORNER_SQUARE, ID.TWM_CORNER_REGULAR_N, ID.TWM_CORNER_SQUARE, ID.TWM_CORNER_SQUARE), //c_basic
			new ModuleChanges(ID.TWM_CORNER_SQUARE_2, ID.TWM_CORNER_SQUARE_2, ID.TWM_CORNER_REGULAR_2_N, ID.TWM_CORNER_SQUARE_2, ID.TWM_CORNER_SQUARE_2), //c_basic_2

			new ModuleChanges(ID.TWM_CORNER_REGULAR, ID.TWM_CORNER_REGULAR, ID.TWM_CORNER_MEDIUM, ID.TWM_CORNER_REGULAR, ID.TWM_CORNER_REGULAR), //c_l_r
			new ModuleChanges(ID.TWM_CORNER_REGULAR_2, ID.TWM_CORNER_SQUARE_2, ID.TWM_CORNER_MEDIUM_2, ID.TWM_CORNER_REGULAR_2, ID.TWM_CORNER_REGULAR_2), //c_l_r_2
			new ModuleChanges(ID.TWM_CORNER_REGULAR_LH, ID.TWM_CORNER_REGULAR_LH, ID.TWM_CORNER_MEDIUM_LH, ID.TWM_CORNER_REGULAR_LH, ID.TWM_CORNER_REGULAR_LH), //c_l_r_LH
			new ModuleChanges(ID.TWM_CORNER_REGULAR_2_LH, ID.TWM_CORNER_REGULAR_2_LH, ID.TWM_CORNER_MEDIUM_2_LH, ID.TWM_CORNER_REGULAR_2_LH, ID.TWM_CORNER_REGULAR_2_LH), //c_l_r_2_LH
			new ModuleChanges(ID.TWM_CORNER_REGULAR_N, ID.TWM_CORNER_SQUARE, ID.TWM_CORNER_MEDIUM_N, ID.TWM_CORNER_REGULAR, ID.TWM_CORNER_REGULAR_LH), //c_l_r_N
			new ModuleChanges(ID.TWM_CORNER_REGULAR_2_N, ID.TWM_CORNER_SQUARE_2, ID.TWM_CORNER_MEDIUM_2_N, ID.TWM_CORNER_REGULAR_2, ID.TWM_CORNER_REGULAR_2_LH), //c_l_r_2_N

			new ModuleChanges(ID.TWM_CORNER_MEDIUM, ID.TWM_CORNER_REGULAR, ID.TWM_CORNER_LARGE, ID.TWM_CORNER_MEDIUM, ID.TWM_CORNER_MEDIUM), //c_l_x
			new ModuleChanges(ID.TWM_CORNER_MEDIUM_2, ID.TWM_CORNER_REGULAR_2, ID.TWM_CORNER_LARGE_2, ID.TWM_CORNER_MEDIUM_2, ID.TWM_CORNER_MEDIUM_2), //c_l_x_2
			new ModuleChanges(ID.TWM_CORNER_MEDIUM_LH, ID.TWM_CORNER_REGULAR_LH, ID.TWM_CORNER_LARGE_LH, ID.TWM_CORNER_MEDIUM_LH, ID.TWM_CORNER_MEDIUM_LH), //c_l_x_LH
			new ModuleChanges(ID.TWM_CORNER_MEDIUM_2_LH, ID.TWM_CORNER_REGULAR_2_LH, ID.TWM_CORNER_LARGE_2_LH, ID.TWM_CORNER_MEDIUM_2_LH, ID.TWM_CORNER_MEDIUM_2_LH), //c_l_x_2_LH
			new ModuleChanges(ID.TWM_CORNER_MEDIUM_N, ID.TWM_CORNER_REGULAR_N, ID.TWM_CORNER_LARGE_N, ID.TWM_CORNER_MEDIUM, ID.TWM_CORNER_MEDIUM_LH), //c_l_x_N
			new ModuleChanges(ID.TWM_CORNER_MEDIUM_2_N, ID.TWM_CORNER_REGULAR_2_N, ID.TWM_CORNER_LARGE_2_N, ID.TWM_CORNER_MEDIUM_2, ID.TWM_CORNER_MEDIUM_2_LH), //c_l_x_2_N

			new ModuleChanges(ID.TWM_CORNER_LARGE, ID.TWM_CORNER_MEDIUM, ID.TWM_CORNER_LARGE, ID.TWM_CORNER_LARGE, ID.TWM_CORNER_LARGE), //c_l_xt
			new ModuleChanges(ID.TWM_CORNER_LARGE_2, ID.TWM_CORNER_MEDIUM_2, ID.TWM_CORNER_LARGE_2, ID.TWM_CORNER_LARGE_2, ID.TWM_CORNER_LARGE_2), //c_l_xt_2
			new ModuleChanges(ID.TWM_CORNER_LARGE_LH, ID.TWM_CORNER_MEDIUM_LH, ID.TWM_CORNER_LARGE_LH, ID.TWM_CORNER_LARGE_LH, ID.TWM_CORNER_LARGE_LH), //c_l_xt_LH
			new ModuleChanges(ID.TWM_CORNER_LARGE_2_LH, ID.TWM_CORNER_MEDIUM_2_LH, ID.TWM_CORNER_LARGE_2_LH, ID.TWM_CORNER_LARGE_2_LH, ID.TWM_CORNER_LARGE_2_LH), //c_l_xt_2_LH
			new ModuleChanges(ID.TWM_CORNER_LARGE_N, ID.TWM_CORNER_MEDIUM_N, ID.TWM_CORNER_LARGE_N, ID.TWM_CORNER_LARGE, ID.TWM_CORNER_LARGE_LH), //c_l_xt_N
			new ModuleChanges(ID.TWM_CORNER_LARGE_2_N, ID.TWM_CORNER_MEDIUM_2_N, ID.TWM_CORNER_LARGE_2_N, ID.TWM_CORNER_LARGE_2, ID.TWM_CORNER_LARGE_2_LH), //c_l_xt_2_N

			new ModuleChanges(ID.TWM_DIP_R, ID.TWM_DIP_R, ID.TWM_DIP_X, ID.TWM_DIP_R, ID.TWM_DIP_R), //d_r
			new ModuleChanges(ID.TWM_DIP_X, ID.TWM_DIP_R, ID.TWM_DIP_XT, ID.TWM_DIP_X, ID.TWM_DIP_X), //d_x
			new ModuleChanges(ID.TWM_DIP_XT, ID.TWM_DIP_X, ID.TWM_DIP_SQUARE, ID.TWM_DIP_XT, ID.TWM_DIP_XT), //d_xt
			new ModuleChanges(ID.TWM_DIP_R_2, ID.TWM_DIP_R_2, ID.TWM_DIP_X_2, ID.TWM_DIP_R_2_FORWARD, ID.TWM_DIP_R_2_FORWARD), //d_r_2
			new ModuleChanges(ID.TWM_DIP_X_2, ID.TWM_DIP_R_2, ID.TWM_DIP_XT_2, ID.TWM_DIP_X_2_FORWARD, ID.TWM_DIP_X_2_FORWARD), //d_x_2
			new ModuleChanges(ID.TWM_DIP_XT_2, ID.TWM_DIP_X_2, ID.TWM_DIP_SQUARE_CARPET, ID.TWM_DIP_XT_2_FORWARD, ID.TWM_DIP_XT_2_FORWARD), //d_xt_2

			new ModuleChanges(ID.TWM_HUMP_R, ID.TWM_HUMP_R, ID.TWM_HUMP_X, ID.TWM_HUMP_R, ID.TWM_HUMP_R), //h_r
			new ModuleChanges(ID.TWM_HUMP_X, ID.TWM_HUMP_R, ID.TWM_HUMP_XT, ID.TWM_HUMP_X, ID.TWM_HUMP_X), //h_x
			new ModuleChanges(ID.TWM_HUMP_XT, ID.TWM_HUMP_X, ID.TWM_HUMP_SQUARE, ID.TWM_HUMP_XT, ID.TWM_HUMP_XT), //h_xt
			new ModuleChanges(ID.TWM_HUMP_R_2, ID.TWM_HUMP_R_2, ID.TWM_HUMP_X_2, ID.TWM_HUMP_R_2_FORWARD, ID.TWM_HUMP_R_2_FORWARD), //h_r_2
			new ModuleChanges(ID.TWM_HUMP_X_2, ID.TWM_HUMP_R_2, ID.TWM_HUMP_XT_2, ID.TWM_HUMP_X_2_FORWARD, ID.TWM_HUMP_X_2_FORWARD), //h_x_2
			new ModuleChanges(ID.TWM_HUMP_XT_2, ID.TWM_HUMP_X_2, ID.TWM_HUMP_SQUARE_CARPET, ID.TWM_HUMP_XT_2_FORWARD, ID.TWM_HUMP_XT_2_FORWARD), //h_xt_2

			new ModuleChanges(ID.TWM_NARROW, ID.TWM_NARROW_SINGLE, ID.TWM_NARROWF, ID.TWM_NARROW, ID.TWM_NARROW), //narrow
			new ModuleChanges(ID.TWM_NARROWF, ID.TWM_NARROW, ID.TWM_NARROWF, ID.TWM_NARROWF, ID.TWM_NARROWF), //narrowf
			new ModuleChanges(ID.TWM_NARROWF_2, ID.TWM_NARROW_CARPET, ID.TWM_NARROWF_2, ID.TWM_NARROWF_2, ID.TWM_NARROWF_2), //narrowf_2

			new ModuleChanges(ID.TWM_PIPE_0, ID.TWM_PIPE_0, ID.TWM_PIPE_0, ID.TWM_PIPE_0, ID.TWM_PIPE_0), //p_0 - pipe straight no ends
			new ModuleChanges(ID.TWM_PIPE_1, ID.TWM_PIPE_1, ID.TWM_PIPE_1, ID.TWM_PIPE_1, ID.TWM_PIPE_1), //p_1 - pipe straight front end
			new ModuleChanges(ID.TWM_PIPE_2, ID.TWM_PIPEF_N, ID.TWM_PIPEC_2, ID.TWM_PIPE_2, ID.TWM_PIPE_2), //p_2 - pipe straight both ends

			new ModuleChanges(ID.TWM_PIPE_20_0, ID.TWM_PIPE_20_0, ID.TWM_PIPE_20_0, ID.TWM_PIPE_20_0, ID.TWM_PIPE_20_0), //p_20_0 - pipe slope no ends
			new ModuleChanges(ID.TWM_PIPE_20_1_BOT, ID.TWM_PIPE_20_1_BOT, ID.TWM_PIPE_20_1_BOT, ID.TWM_PIPE_20_1_BOT, ID.TWM_PIPE_20_1_BOT), //p_20_1_bot - pipe slope front bottom end
			new ModuleChanges(ID.TWM_PIPE_20_1_TOP, ID.TWM_PIPE_20_1_TOP, ID.TWM_PIPE_20_1_TOP, ID.TWM_PIPE_20_1_TOP, ID.TWM_PIPE_20_1_TOP), //p_20_1_top - pipe slope back top end
			
			new ModuleChanges(ID.TWM_PIPE_20_2, ID.TWM_PIPE_RAMP_15_BOTH_ENDS, ID.TWM_PIPE_RAMP_UP_BOTH_ENDS, ID.TWM_PIPE_20_2, ID.TWM_PIPE_20_2), //p_20_2 - pipe slope both ends
			
			new ModuleChanges(ID.TWM_PIPEC_0, ID.TWM_PIPEC_0, ID.TWM_PIPEC_0, ID.TWM_PIPEC_0, ID.TWM_PIPEC_0), //pc_0 - pipe square turn no ends
			new ModuleChanges(ID.TWM_PIPEC_1, ID.TWM_PIPEC_1, ID.TWM_PIPEC_1, ID.TWM_PIPEC_1, ID.TWM_PIPEC_1), //pc_1 - pipe square turn front end
			new ModuleChanges(ID.TWM_PIPEC_1A, ID.TWM_PIPEC_1A, ID.TWM_PIPEC_1A, ID.TWM_PIPEC_1A, ID.TWM_PIPEC_1A), //pc_1a - pipe square turn side end
			
			new ModuleChanges(ID.TWM_PIPEC_2, ID.TWM_PIPE_2, ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS, ID.TWM_PIPEC_2, ID.TWM_PIPEC_2), //pc_2 - pipe square turn both ends
			
			new ModuleChanges(ID.TWM_PIPEF, ID.TWM_PIPEF, ID.TWM_PIPE_2, ID.TWM_PIPEF, ID.TWM_PIPEF_OUT), //pf - pipe entry in arrows
			
			new ModuleChanges(ID.TWM_PIPE_1A, ID.TWM_PIPE_1A, ID.TWM_PIPE_1A, ID.TWM_PIPE_1A, ID.TWM_PIPE_1A), //p_1a - pipe straight back end
			
			new ModuleChanges(ID.TWM_PIPEF_OUT, ID.TWM_PIPEF_OUT, ID.TWM_PIPE_2, ID.TWM_PIPEF_OUT, ID.TWM_PIPEF_OUT), //pf - pipe entry out arrows

			new ModuleChanges(ID.TWM_PIPEF_N, ID.TWM_PIPEF_N, ID.TWM_PIPE_2, ID.TWM_PIPEF, ID.TWM_PIPEF_OUT), //pf - pipe entry no arrows

			new ModuleChanges(ID.TWM_RAMP_00, ID.TWM_RAMP_00, ID.TWM_RAMP_05, ID.TWM_RAMP_00, ID.TWM_RAMP_00), //r_00
			new ModuleChanges(ID.TWM_RAMP_05, ID.TWM_RAMP_00, ID.TWM_RAMP_10, ID.TWM_RAMP_05, ID.TWM_RAMP_05), //r_05
			new ModuleChanges(ID.TWM_RAMP_10, ID.TWM_RAMP_05, ID.TWM_RAMP_15, ID.TWM_RAMP_10, ID.TWM_RAMP_10), //r_10
			new ModuleChanges(ID.TWM_RAMP_15, ID.TWM_RAMP_10, ID.TWM_RAMP_20, ID.TWM_RAMP_15, ID.TWM_RAMP_15), //r_15
			new ModuleChanges(ID.TWM_RAMP_20, ID.TWM_RAMP_15, ID.TWM_RAMP_25, ID.TWM_RAMP_20, ID.TWM_RAMP_20), //r_20
			new ModuleChanges(ID.TWM_RAMP_25, ID.TWM_RAMP_20, ID.TWM_RAMP_30, ID.TWM_RAMP_25, ID.TWM_RAMP_25), //r_25
			new ModuleChanges(ID.TWM_RAMP_30, ID.TWM_RAMP_25, ID.TWM_RAMP_BOTTOM, ID.TWM_RAMP_30, ID.TWM_RAMP_30), //r_30

			new ModuleChanges(ID.TWM_RAMP_00_2, ID.TWM_RAMP_00_2, ID.TWM_RAMP_05_2, ID.TWM_RAMP_00_2, ID.TWM_RAMP_00_2), //r_00_2
			new ModuleChanges(ID.TWM_RAMP_05_2, ID.TWM_RAMP_00_2, ID.TWM_RAMP_10_2, ID.TWM_RAMP_05_2, ID.TWM_RAMP_05_2_D), //r_05_2
			new ModuleChanges(ID.TWM_RAMP_10_2, ID.TWM_RAMP_05_2, ID.TWM_RAMP_15_2, ID.TWM_RAMP_10_2, ID.TWM_RAMP_10_2_D), //r_10_2
			new ModuleChanges(ID.TWM_RAMP_15_2, ID.TWM_RAMP_10_2, ID.TWM_RAMP_20_2, ID.TWM_RAMP_15_2, ID.TWM_RAMP_15_2_D), //r_15_2
			new ModuleChanges(ID.TWM_RAMP_20_2, ID.TWM_RAMP_15_2, ID.TWM_RAMP_25_2, ID.TWM_RAMP_20_2, ID.TWM_RAMP_20_2_D), //r_20_2
			new ModuleChanges(ID.TWM_RAMP_25_2, ID.TWM_RAMP_20_2, ID.TWM_RAMP_30_2, ID.TWM_RAMP_25_2, ID.TWM_RAMP_25_2_D), //r_25_2
			new ModuleChanges(ID.TWM_RAMP_30_2, ID.TWM_RAMP_25_2, ID.TWM_RAMP_30_2, ID.TWM_RAMP_30_2, ID.TWM_RAMP_30_2_D), //r_30_2

			new ModuleChanges(ID.TWM_RAMP_05_2_D, ID.TWM_RAMP_05_2_D, ID.TWM_RAMP_05_2_D, ID.TWM_RAMP_05_2_D, ID.TWM_RAMP_05_2_D), //r_05_2_D
			new ModuleChanges(ID.TWM_RAMP_10_2_D, ID.TWM_RAMP_10_2_D, ID.TWM_RAMP_10_2_D, ID.TWM_RAMP_10_2_D, ID.TWM_RAMP_10_2_D), //r_10_2_D
			new ModuleChanges(ID.TWM_RAMP_15_2_D, ID.TWM_RAMP_15_2_D, ID.TWM_RAMP_15_2_D, ID.TWM_RAMP_15_2_D, ID.TWM_RAMP_15_2_D), //r_15_2_D
			new ModuleChanges(ID.TWM_RAMP_20_2_D, ID.TWM_RAMP_20_2_D, ID.TWM_RAMP_20_2_D, ID.TWM_RAMP_20_2_D, ID.TWM_RAMP_20_2_D), //r_20_2_D
			new ModuleChanges(ID.TWM_RAMP_25_2_D, ID.TWM_RAMP_25_2_D, ID.TWM_RAMP_25_2_D, ID.TWM_RAMP_25_2_D, ID.TWM_RAMP_25_2_D), //r_25_2_D
			new ModuleChanges(ID.TWM_RAMP_30_2_D, ID.TWM_RAMP_30_2_D, ID.TWM_RAMP_30_2_D, ID.TWM_RAMP_30_2_D, ID.TWM_RAMP_30_2_D), //r_30_2_D
			new ModuleChanges(ID.TWM_RAMP_05_2_N, ID.TWM_RAMP_00_2_N, ID.TWM_RAMP_10_2_N, ID.TWM_RAMP_05_2, ID.TWM_RAMP_05_2_D), //r_05_2_N
			new ModuleChanges(ID.TWM_RAMP_10_2_N, ID.TWM_RAMP_05_2_N, ID.TWM_RAMP_15_2_N, ID.TWM_RAMP_10_2, ID.TWM_RAMP_10_2_D), //r_10_2_N
			new ModuleChanges(ID.TWM_RAMP_15_2_N, ID.TWM_RAMP_10_2_N, ID.TWM_RAMP_20_2_N, ID.TWM_RAMP_15_2, ID.TWM_RAMP_15_2_D), //r_15_2_N
			new ModuleChanges(ID.TWM_RAMP_20_2_N, ID.TWM_RAMP_15_2_N, ID.TWM_RAMP_25_2_N, ID.TWM_RAMP_20_2, ID.TWM_RAMP_20_2_D), //r_20_2_N
			new ModuleChanges(ID.TWM_RAMP_25_2_N, ID.TWM_RAMP_20_2_N, ID.TWM_RAMP_30_2_N, ID.TWM_RAMP_25_2, ID.TWM_RAMP_25_2_D), //r_25_2_N
			new ModuleChanges(ID.TWM_RAMP_30_2_N, ID.TWM_RAMP_25_2_N, ID.TWM_RAMP_BOTTOM_CARPET_NEUTRAL, ID.TWM_RAMP_30_2, ID.TWM_RAMP_30_2_D), //r_30_2_N

			new ModuleChanges(ID.TWM_DIAGONAL_01, ID.TWM_DIAGONAL_01_LH, ID.TWM_DIAGONAL_02, ID.TWM_DIAGONAL_01, ID.TWM_DIAGONAL_01), //sf_01
			new ModuleChanges(ID.TWM_DIAGONAL_02, ID.TWM_DIAGONAL_01, ID.TWM_DIAGONAL_SMOOTH_2, ID.TWM_DIAGONAL_02, ID.TWM_DIAGONAL_02), //sf_02
			new ModuleChanges(ID.TWM_DIAGONAL_01_2, ID.TWM_DIAGONAL_01_2_LH, ID.TWM_DIAGONAL_02_2, ID.TWM_DIAGONAL_01_2, ID.TWM_DIAGONAL_01_2), //sf_01_2
			new ModuleChanges(ID.TWM_DIAGONAL_02_2, ID.TWM_DIAGONAL_01_2, ID.TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL, ID.TWM_DIAGONAL_02_2, ID.TWM_DIAGONAL_02_2), //sf_02_2
			new ModuleChanges(ID.TWM_DIAGONAL_01_LH, ID.TWM_DIAGONAL_02_LH, ID.TWM_DIAGONAL_01, ID.TWM_DIAGONAL_01_LH, ID.TWM_DIAGONAL_01_LH), //sf_01_LH
			new ModuleChanges(ID.TWM_DIAGONAL_02_LH, ID.TWM_DIAGONAL_SMOOTH, ID.TWM_DIAGONAL_01_LH, ID.TWM_DIAGONAL_02_LH, ID.TWM_DIAGONAL_02_LH), //sf_02_LH
			new ModuleChanges(ID.TWM_DIAGONAL_01_2_LH, ID.TWM_DIAGONAL_02_2_LH, ID.TWM_DIAGONAL_01_2, ID.TWM_DIAGONAL_01_2_LH, ID.TWM_DIAGONAL_01_2_LH), //sf_01_2_LH
			new ModuleChanges(ID.TWM_DIAGONAL_02_2_LH, ID.TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL, ID.TWM_DIAGONAL_01_2_LH, ID.TWM_DIAGONAL_02_2_LH, ID.TWM_DIAGONAL_02_2_LH), //sf_02_2_LH

			new ModuleChanges(ID.TWM_RUMBLE_02,		ID.TWM_RUMBLE_02,	ID.TWM_RUMBLE_04,	ID.TWM_RUMBLE_02,	ID.TWM_RUMBLE_02	), //st_02
			new ModuleChanges(ID.TWM_RUMBLE_04,		ID.TWM_RUMBLE_02,	ID.TWM_RUMBLE_DOWN,	ID.TWM_RUMBLE_04,	ID.TWM_RUMBLE_04	), //st_04
			new ModuleChanges(ID.TWM_RUMBLE_02_2,	ID.TWM_RUMBLE_02_2,	ID.TWM_RUMBLE_04_2,	ID.TWM_RUMBLE_02_2,	ID.TWM_RUMBLE_02_2	), //st_02_2
			new ModuleChanges(ID.TWM_RUMBLE_04_2,	ID.TWM_RUMBLE_02_2,	ID.TWM_RUMBLE_DOWN_CARPET,	ID.TWM_RUMBLE_04_2,	ID.TWM_RUMBLE_04_2	), //st_04_2

			new ModuleChanges(ID.TWM_CROSS_ROAD, ID.TWM_CROSS_ROAD_HALF_PIPE, ID.TWM_BANK_CROSS_ROAD_05, ID.TWM_CROSS_ROAD, ID.TWM_CROSS_ROAD), //X

			new ModuleChanges(ID.TWM_ZIGZAG,	ID.TWM_ZIGZAG,		ID.TWM_ZIGZAG_MIRROR,	ID.TWM_ZIGZAG,		ID.TWM_ZIGZAG	), //zigzag
			new ModuleChanges(ID.TWM_ZIGZAG_2,	ID.TWM_ZIGZAG_2,	ID.TWM_ZIGZAG_MIRROR_2,	ID.TWM_ZIGZAG_2,	ID.TWM_ZIGZAG_2	), //zigzag_2

			new ModuleChanges(ID.TWM_JUMP, ID.TWM_JUMP, ID.TWM_JUMP, ID.TWM_JUMP, ID.TWM_JUMP),	//jump piece

			new ModuleChanges(ID.TWM_RAMP_00_2_N, ID.TWM_RAMP_00_2_N, ID.TWM_RAMP_05_2_N, ID.TWM_RAMP_00_2, ID.TWM_RAMP_00_2), //r_00_2_N

			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS,		ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_1X1_NO_ENDS		),
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_FRONT_END	),
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END,		ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END,	ID.TWM_PIPE_SMOOTH_TURN_1X1_SIDE_END	),
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS,	ID.TWM_PIPEC_2,							ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS	),
			
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,		ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_2X2_NO_ENDS		),
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_FRONT_END	),
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END,		ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END,	ID.TWM_PIPE_SMOOTH_TURN_2X2_SIDE_END	),
			new ModuleChanges(ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_1X1_BOTH_ENDS,	ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,		ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,	ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS	),

			new ModuleChanges(ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS,			ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS,		ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS,		ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS,		ID.TWM_PIPE_RAMP_BOTTOM_NO_ENDS			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END,		ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END,		ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END,		ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END,		ID.TWM_PIPE_RAMP_BOTTOM_FRONT_END		),
			new ModuleChanges(ID.TWM_PIPE_RAMP_BOTTOM_BACK_END,			ID.TWM_PIPE_RAMP_BOTTOM_BACK_END,		ID.TWM_PIPE_RAMP_BOTTOM_BACK_END,		ID.TWM_PIPE_RAMP_BOTTOM_BACK_END,		ID.TWM_PIPE_RAMP_BOTTOM_BACK_END		),
			new ModuleChanges(ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,		ID.TWM_PIPE_SMOOTH_TURN_2X2_BOTH_ENDS,	ID.TWM_PIPE_RAMP_5_BOTH_ENDS,			ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,		ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS		),

			new ModuleChanges(ID.TWM_PIPE_RAMP_UP_NO_ENDS,				ID.TWM_PIPE_RAMP_UP_NO_ENDS,			ID.TWM_PIPE_RAMP_UP_NO_ENDS,			ID.TWM_PIPE_RAMP_UP_NO_ENDS,			ID.TWM_PIPE_RAMP_UP_NO_ENDS				),
			new ModuleChanges(ID.TWM_PIPE_RAMP_UP_FRONT_END,			ID.TWM_PIPE_RAMP_UP_FRONT_END,			ID.TWM_PIPE_RAMP_UP_FRONT_END,			ID.TWM_PIPE_RAMP_UP_FRONT_END,			ID.TWM_PIPE_RAMP_UP_FRONT_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_UP_BACK_END,				ID.TWM_PIPE_RAMP_UP_BACK_END,			ID.TWM_PIPE_RAMP_UP_BACK_END,			ID.TWM_PIPE_RAMP_UP_BACK_END,			ID.TWM_PIPE_RAMP_UP_BACK_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_UP_BOTH_ENDS,			ID.TWM_PIPE_20_2,						ID.TWM_PIPE_RAMP_UP_BOTH_ENDS,			ID.TWM_PIPE_RAMP_UP_BOTH_ENDS,			ID.TWM_PIPE_RAMP_UP_BOTH_ENDS			),

			new ModuleChanges(ID.TWM_PIPE_RAMP_15_NO_ENDS,				ID.TWM_PIPE_RAMP_15_NO_ENDS,			ID.TWM_PIPE_RAMP_15_NO_ENDS,			ID.TWM_PIPE_RAMP_15_NO_ENDS,			ID.TWM_PIPE_RAMP_15_NO_ENDS				),
			new ModuleChanges(ID.TWM_PIPE_RAMP_15_FRONT_END,			ID.TWM_PIPE_RAMP_15_FRONT_END,			ID.TWM_PIPE_RAMP_15_FRONT_END,			ID.TWM_PIPE_RAMP_15_FRONT_END,			ID.TWM_PIPE_RAMP_15_FRONT_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_15_BACK_END,				ID.TWM_PIPE_RAMP_15_BACK_END,			ID.TWM_PIPE_RAMP_15_BACK_END,			ID.TWM_PIPE_RAMP_15_BACK_END,			ID.TWM_PIPE_RAMP_15_BACK_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_15_BOTH_ENDS,			ID.TWM_PIPE_RAMP_10_BOTH_ENDS,			ID.TWM_PIPE_20_2,						ID.TWM_PIPE_RAMP_15_BOTH_ENDS,			ID.TWM_PIPE_RAMP_15_BOTH_ENDS			),

			new ModuleChanges(ID.TWM_PIPE_RAMP_10_NO_ENDS,				ID.TWM_PIPE_RAMP_10_NO_ENDS,			ID.TWM_PIPE_RAMP_10_NO_ENDS,			ID.TWM_PIPE_RAMP_10_NO_ENDS,			ID.TWM_PIPE_RAMP_10_NO_ENDS				),
			new ModuleChanges(ID.TWM_PIPE_RAMP_10_FRONT_END,			ID.TWM_PIPE_RAMP_10_FRONT_END,			ID.TWM_PIPE_RAMP_10_FRONT_END,			ID.TWM_PIPE_RAMP_10_FRONT_END,			ID.TWM_PIPE_RAMP_10_FRONT_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_10_BACK_END,				ID.TWM_PIPE_RAMP_10_BACK_END,			ID.TWM_PIPE_RAMP_10_BACK_END,			ID.TWM_PIPE_RAMP_10_BACK_END,			ID.TWM_PIPE_RAMP_10_BACK_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_10_BOTH_ENDS,			ID.TWM_PIPE_RAMP_5_BOTH_ENDS,			ID.TWM_PIPE_RAMP_15_BOTH_ENDS,			ID.TWM_PIPE_RAMP_10_BOTH_ENDS,			ID.TWM_PIPE_RAMP_10_BOTH_ENDS			),

			new ModuleChanges(ID.TWM_PIPE_RAMP_5_NO_ENDS,				ID.TWM_PIPE_RAMP_5_NO_ENDS,				ID.TWM_PIPE_RAMP_5_NO_ENDS,				ID.TWM_PIPE_RAMP_5_NO_ENDS,				ID.TWM_PIPE_RAMP_5_NO_ENDS				),
			new ModuleChanges(ID.TWM_PIPE_RAMP_5_FRONT_END,				ID.TWM_PIPE_RAMP_5_FRONT_END,			ID.TWM_PIPE_RAMP_5_FRONT_END,			ID.TWM_PIPE_RAMP_5_FRONT_END,			ID.TWM_PIPE_RAMP_5_FRONT_END			),
			new ModuleChanges(ID.TWM_PIPE_RAMP_5_BACK_END,				ID.TWM_PIPE_RAMP_5_BACK_END,			ID.TWM_PIPE_RAMP_5_BACK_END,			ID.TWM_PIPE_RAMP_5_BACK_END,			ID.TWM_PIPE_RAMP_5_BACK_END				),
			new ModuleChanges(ID.TWM_PIPE_RAMP_5_BOTH_ENDS,				ID.TWM_PIPE_RAMP_BOTTOM_BOTH_ENDS,		ID.TWM_PIPE_RAMP_10_BOTH_ENDS,			ID.TWM_PIPE_RAMP_5_BOTH_ENDS,			ID.TWM_PIPE_RAMP_5_BOTH_ENDS			),

			new ModuleChanges(ID.TWM_BANK_CROSS_ROAD_05,				ID.TWM_CROSS_ROAD,						ID.TWM_BANK_CROSS_ROAD_10,				ID.TWM_BANK_CROSS_ROAD_05,				ID.TWM_BANK_CROSS_ROAD_05				),
			new ModuleChanges(ID.TWM_BANK_CROSS_ROAD_10,				ID.TWM_BANK_CROSS_ROAD_05,				ID.TWM_BANK_CROSS_ROAD_20,				ID.TWM_BANK_CROSS_ROAD_10,				ID.TWM_BANK_CROSS_ROAD_10				),
			new ModuleChanges(ID.TWM_BANK_CROSS_ROAD_20,				ID.TWM_BANK_CROSS_ROAD_10,				ID.TWM_CROSS_ROAD_2_LINES,				ID.TWM_BANK_CROSS_ROAD_20,				ID.TWM_BANK_CROSS_ROAD_20				),
			
			new ModuleChanges(ID.TWM_HUMP_SQUARE,						ID.TWM_HUMP_XT,							ID.TWM_HUMP_ROUND_SMALL,				ID.TWM_HUMP_SQUARE,						ID.TWM_HUMP_SQUARE						),
			new ModuleChanges(ID.TWM_DIP_SQUARE,						ID.TWM_DIP_XT,							ID.TWM_DIP_ROUND_SMALL,					ID.TWM_DIP_SQUARE,						ID.TWM_DIP_SQUARE						),
			
			new ModuleChanges(ID.TWM_BANK_UP_TURN_05,					ID.TWM_BANK_UP_TURN2_20,				ID.TWM_BANK_UP_TURN_10,					ID.TWM_BANK_UP_TURN_05,					ID.TWM_BANK_UP_TURN_05					),
			new ModuleChanges(ID.TWM_BANK_UP_TURN_10,					ID.TWM_BANK_UP_TURN_05,					ID.TWM_BANK_UP_TURN_20,					ID.TWM_BANK_UP_TURN_10,					ID.TWM_BANK_UP_TURN_10					),
			new ModuleChanges(ID.TWM_BANK_UP_TURN_20,					ID.TWM_BANK_UP_TURN_10,					ID.TWM_BANK_IN_05,						ID.TWM_BANK_UP_TURN_20,					ID.TWM_BANK_UP_TURN_20					),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN_05,					ID.TWM_BANK_DOWN_TURN2_20,				ID.TWM_BANK_DOWN_TURN_10,				ID.TWM_BANK_DOWN_TURN_05,				ID.TWM_BANK_DOWN_TURN_05				),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN_10,					ID.TWM_BANK_DOWN_TURN_05,				ID.TWM_BANK_DOWN_TURN_20,				ID.TWM_BANK_DOWN_TURN_10,				ID.TWM_BANK_DOWN_TURN_10				),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN_20,					ID.TWM_BANK_DOWN_TURN_10,				ID.TWM_BANK_UP_TURN2_05,				ID.TWM_BANK_DOWN_TURN_20,				ID.TWM_BANK_DOWN_TURN_20				),
			
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_05,			ID.TWM_BANK_IN_20_LH,					ID.TWM_BANK_SMOOTH_TURN_1X1_10,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_05,			ID.TWM_BANK_SMOOTH_TURN_1X1_20,			ID.TWM_BANK_SMOOTH_TURN_2X2_10,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_05,			ID.TWM_BANK_SMOOTH_TURN_2X2_20,			ID.TWM_BANK_SMOOTH_TURN_3X3_10,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_10,			ID.TWM_BANK_SMOOTH_TURN_1X1_05,			ID.TWM_BANK_SMOOTH_TURN_1X1_20,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_10,			ID.TWM_BANK_SMOOTH_TURN_2X2_05,			ID.TWM_BANK_SMOOTH_TURN_2X2_20,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_10,			ID.TWM_BANK_SMOOTH_TURN_3X3_05,			ID.TWM_BANK_SMOOTH_TURN_3X3_20,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_20,			ID.TWM_BANK_SMOOTH_TURN_1X1_10,			ID.TWM_BANK_SMOOTH_TURN_2X2_05,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_20,			ID.TWM_BANK_SMOOTH_TURN_2X2_10,			ID.TWM_BANK_SMOOTH_TURN_3X3_05,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_20,			ID.TWM_BANK_SMOOTH_TURN_3X3_10,			ID.TWM_BANK_FLAT_TO_5,					ID.TWM_BANK_SMOOTH_TURN_3X3_20_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_L		),

			new ModuleChanges(ID.TWM_BANK_UP_TURN2_05,					ID.TWM_BANK_DOWN_TURN_20,				ID.TWM_BANK_UP_TURN2_10,				ID.TWM_BANK_UP_TURN2_05,				ID.TWM_BANK_UP_TURN2_05					),
			new ModuleChanges(ID.TWM_BANK_UP_TURN2_10,					ID.TWM_BANK_UP_TURN2_05,				ID.TWM_BANK_UP_TURN2_20,				ID.TWM_BANK_UP_TURN2_10,				ID.TWM_BANK_UP_TURN2_10					),
			new ModuleChanges(ID.TWM_BANK_UP_TURN2_20,					ID.TWM_BANK_UP_TURN2_10,				ID.TWM_BANK_UP_TURN_05,					ID.TWM_BANK_UP_TURN2_20,				ID.TWM_BANK_UP_TURN2_20					),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN2_05,				ID.TWM_BANK_SWITCH_20_TO_20_2,			ID.TWM_BANK_DOWN_TURN2_10,				ID.TWM_BANK_DOWN_TURN2_05,				ID.TWM_BANK_DOWN_TURN2_05				),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN2_10,				ID.TWM_BANK_DOWN_TURN2_05,				ID.TWM_BANK_DOWN_TURN2_20,				ID.TWM_BANK_DOWN_TURN2_10,				ID.TWM_BANK_DOWN_TURN2_10				),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN2_20,				ID.TWM_BANK_DOWN_TURN2_10,				ID.TWM_BANK_DOWN_TURN_05,				ID.TWM_BANK_DOWN_TURN2_20,				ID.TWM_BANK_DOWN_TURN2_20				),

			new ModuleChanges(ID.TWM_RUMBLE_DOWN,						ID.TWM_RUMBLE_04,						ID.TWM_RUMBLE_DOWN,						ID.TWM_RUMBLE_DOWN,						ID.TWM_RUMBLE_DOWN						),
			
			new ModuleChanges(ID.TWM_ZIGZAG_MIRROR,						ID.TWM_ZIGZAG,							ID.TWM_ZIGZAG_HALF,						ID.TWM_ZIGZAG_MIRROR,					ID.TWM_ZIGZAG_MIRROR					),
			new ModuleChanges(ID.TWM_ZIGZAG_MIRROR_2,					ID.TWM_ZIGZAG_2,						ID.TWM_ZIGZAG_HALF_CARPET_NEUTRAL,		ID.TWM_ZIGZAG_MIRROR_2,					ID.TWM_ZIGZAG_MIRROR_2					),
			new ModuleChanges(ID.TWM_ZIGZAG_HALF,						ID.TWM_ZIGZAG_MIRROR,					ID.TWM_PILLAR_CENTER_LONG,					ID.TWM_ZIGZAG_HALF,						ID.TWM_ZIGZAG_HALF						),
			
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_05_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_05_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_05_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_10_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_10_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_10_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_20_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_R,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_20_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_R,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_R		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_20_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_R,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_R		),
			
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_05_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_05_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_05_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_10_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_10_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_10_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_20_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_L,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_20_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_L,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_L		),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_20_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_L,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_L		),

			new ModuleChanges(ID.TWM_FINISH, ID.TWM_START, ID.TWM_FINISH, ID.TWM_FINISH, ID.TWM_FINISH), //finish line

			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5,			ID.TWM_BANK_SMOOTH_TURN_3X3_20,		ID.TWM_BANK_FLAT_TO_10,				ID.TWM_BANK_FLAT_TO_5,				ID.TWM_BANK_FLAT_TO_5				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10,			ID.TWM_BANK_FLAT_TO_5,				ID.TWM_BANK_5_TO_10,				ID.TWM_BANK_FLAT_TO_10,				ID.TWM_BANK_FLAT_TO_10				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20,			ID.TWM_BANK_FLAT_TO_10,				ID.TWM_BANK_10_TO_20,				ID.TWM_BANK_FLAT_TO_20,				ID.TWM_BANK_FLAT_TO_20				),
			new ModuleChanges(ID.TWM_BANK_5_TO_10,				ID.TWM_BANK_FLAT_TO_10,				ID.TWM_BANK_FLAT_TO_20,				ID.TWM_BANK_5_TO_10,				ID.TWM_BANK_5_TO_10					),
			new ModuleChanges(ID.TWM_BANK_10_TO_20,				ID.TWM_BANK_FLAT_TO_20,				ID.TWM_BANK_FLAT_TO_5_2,			ID.TWM_BANK_10_TO_20,				ID.TWM_BANK_10_TO_20				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_2,			ID.TWM_BANK_10_TO_20,				ID.TWM_BANK_FLAT_TO_10_2,			ID.TWM_BANK_FLAT_TO_5_2,			ID.TWM_BANK_FLAT_TO_5_2				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_2,			ID.TWM_BANK_FLAT_TO_5_2,			ID.TWM_BANK_5_TO_10_2,				ID.TWM_BANK_FLAT_TO_10_2,			ID.TWM_BANK_FLAT_TO_10_2			),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_2,			ID.TWM_BANK_5_TO_10_2,				ID.TWM_BANK_10_TO_20_2,				ID.TWM_BANK_FLAT_TO_20_2,			ID.TWM_BANK_FLAT_TO_20_2			),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_2,			ID.TWM_BANK_FLAT_TO_10_2,			ID.TWM_BANK_FLAT_TO_20_2,			ID.TWM_BANK_5_TO_10_2,				ID.TWM_BANK_5_TO_10_2				),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_2,			ID.TWM_BANK_5_TO_10_2,				ID.TWM_BANK_10_TO_20_2,				ID.TWM_BANK_10_TO_20_2,				ID.TWM_BANK_10_TO_20_2				),
			
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH,			ID.TWM_DIAGONAL_SMOOTH_UP5,			ID.TWM_DIAGONAL_02_LH,				ID.TWM_DIAGONAL_SMOOTH,				ID.TWM_DIAGONAL_SMOOTH				),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5,		ID.TWM_DIAGONAL_SMOOTH_BANK_5,		ID.TWM_DIAGONAL_SMOOTH,				ID.TWM_DIAGONAL_SMOOTH_UP5,			ID.TWM_DIAGONAL_SMOOTH_UP5			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_2,			ID.TWM_DIAGONAL_02,					ID.TWM_DIAGONAL_SMOOTH_UP5_2,		ID.TWM_DIAGONAL_SMOOTH_2,			ID.TWM_DIAGONAL_SMOOTH_2			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_2,		ID.TWM_DIAGONAL_SMOOTH_2,			ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	ID.TWM_DIAGONAL_SMOOTH_UP5_2,		ID.TWM_DIAGONAL_SMOOTH_UP5_2		),
			
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5,	ID.TWM_DIAGONAL_SMOOTH_BANK_10,		ID.TWM_DIAGONAL_SMOOTH_UP5,			ID.TWM_DIAGONAL_SMOOTH_BANK_5,		ID.TWM_DIAGONAL_SMOOTH_BANK_5		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10,	ID.TWM_DIAGONAL_SMOOTH_BANK_20,		ID.TWM_DIAGONAL_SMOOTH_BANK_5,		ID.TWM_DIAGONAL_SMOOTH_BANK_10,		ID.TWM_DIAGONAL_SMOOTH_BANK_10		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20,	ID.TWM_DIAGONAL_SMOOTH_BANK_20,		ID.TWM_DIAGONAL_SMOOTH_BANK_10,		ID.TWM_DIAGONAL_SMOOTH_BANK_20,		ID.TWM_DIAGONAL_SMOOTH_BANK_20		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	ID.TWM_DIAGONAL_SMOOTH_UP5_2,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2	),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2	),
			
			new ModuleChanges(ID.TWM_DOUBLE_STRAIGHT,			ID.TWM_DOUBLE_STRAIGHT,				ID.TWM_DOUBLE_SIDE_ENTRY,			ID.TWM_DOUBLE_STRAIGHT,				ID.TWM_DOUBLE_STRAIGHT				),
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY,			ID.TWM_DOUBLE_STRAIGHT,				ID.TWM_DOUBLE_SIDE_ENTRY_2,			ID.TWM_DOUBLE_SIDE_ENTRY,			ID.TWM_DOUBLE_SIDE_ENTRY			),
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_2,		ID.TWM_DOUBLE_SIDE_ENTRY,			ID.TWM_DOUBLE_SQUARE_TURN,			ID.TWM_DOUBLE_SIDE_ENTRY_2,			ID.TWM_DOUBLE_SIDE_ENTRY_2			),
			new ModuleChanges(ID.TWM_DOUBLE_SQUARE_TURN,		ID.TWM_DOUBLE_SIDE_ENTRY_2,			ID.TWM_DOUBLE_SQUARE_TURN_2,		ID.TWM_DOUBLE_SQUARE_TURN,			ID.TWM_DOUBLE_SQUARE_TURN			),
			new ModuleChanges(ID.TWM_DOUBLE_SQUARE_TURN_2,		ID.TWM_DOUBLE_SQUARE_TURN,			ID.TWM_DOUBLE_ROUND_TURN,			ID.TWM_DOUBLE_SQUARE_TURN_2,		ID.TWM_DOUBLE_SQUARE_TURN_2			),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN,			ID.TWM_DOUBLE_SQUARE_TURN_2,		ID.TWM_DOUBLE_ROUND_TURN_2,			ID.TWM_DOUBLE_ROUND_TURN_R,			ID.TWM_DOUBLE_ROUND_TURN_L			),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_2,		ID.TWM_DOUBLE_ROUND_TURN,			ID.TWM_DOUBLE_ROUND_TURN_2,			ID.TWM_DOUBLE_ROUND_TURN_L_2,		ID.TWM_DOUBLE_ROUND_TURN_R_2		),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_L,		ID.TWM_DOUBLE_ROUND_TURN_L,			ID.TWM_DOUBLE_ROUND_TURN_L,			ID.TWM_DOUBLE_ROUND_TURN_L,			ID.TWM_DOUBLE_ROUND_TURN_L			),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_L_2,		ID.TWM_DOUBLE_ROUND_TURN_L_2,		ID.TWM_DOUBLE_ROUND_TURN_L_2,		ID.TWM_DOUBLE_ROUND_TURN_L_2,		ID.TWM_DOUBLE_ROUND_TURN_L_2		),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_R,		ID.TWM_DOUBLE_ROUND_TURN_R,			ID.TWM_DOUBLE_ROUND_TURN_R,			ID.TWM_DOUBLE_ROUND_TURN_R,			ID.TWM_DOUBLE_ROUND_TURN_R			),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_R_2,		ID.TWM_DOUBLE_ROUND_TURN_R_2,		ID.TWM_DOUBLE_ROUND_TURN_R_2,		ID.TWM_DOUBLE_ROUND_TURN_R_2,		ID.TWM_DOUBLE_ROUND_TURN_R_2		),

			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5,		ID.TWM_BANK_SWITCH_5_TO_5,			ID.TWM_BANK_SWITCH_10_TO_10,		ID.TWM_BANK_SWITCH_5_TO_5,			ID.TWM_BANK_SWITCH_5_TO_5			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10,		ID.TWM_BANK_SWITCH_5_TO_5,			ID.TWM_BANK_SWITCH_20_TO_20,		ID.TWM_BANK_SWITCH_10_TO_10,		ID.TWM_BANK_SWITCH_10_TO_10			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20,		ID.TWM_BANK_SWITCH_10_TO_10,		ID.TWM_BANK_SWITCH_5_TO_5_2,		ID.TWM_BANK_SWITCH_20_TO_20,		ID.TWM_BANK_SWITCH_20_TO_20			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_2,		ID.TWM_BANK_SWITCH_20_TO_20,		ID.TWM_BANK_SWITCH_10_TO_10_2,		ID.TWM_BANK_SWITCH_5_TO_5_2,		ID.TWM_BANK_SWITCH_5_TO_5_2			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_2,	ID.TWM_BANK_SWITCH_5_TO_5_2,		ID.TWM_BANK_SWITCH_20_TO_20_2,		ID.TWM_BANK_SWITCH_10_TO_10_2,		ID.TWM_BANK_SWITCH_10_TO_10_2		),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_2,	ID.TWM_BANK_SWITCH_10_TO_10_2,		ID.TWM_BANK_DOWN_TURN2_05,			ID.TWM_BANK_SWITCH_20_TO_20_2,		ID.TWM_BANK_SWITCH_20_TO_20_2		),

			new ModuleChanges(ID.TWM_CROSS_ROAD_HALF_PIPE,		ID.TWM_CROSS_ROAD_HALF_PIPE,		ID.TWM_CROSS_ROAD,					ID.TWM_CROSS_ROAD_HALF_PIPE,		ID.TWM_CROSS_ROAD_HALF_PIPE			),

			new ModuleChanges(ID.TWM_NARROW_SINGLE,				ID.TWM_NARROW_SINGLE,				ID.TWM_NARROW,						ID.TWM_NARROW_SINGLE,				ID.TWM_NARROW_SINGLE				),

			new ModuleChanges(ID.TWM_PILLAR_CENTER,				ID.TWM_PILLAR_CENTER_LONG,			ID.TWM_PILLAR_OFFSET,				ID.TWM_PILLAR_CENTER,				ID.TWM_PILLAR_CENTER				),
			new ModuleChanges(ID.TWM_PILLAR_OFFSET,				ID.TWM_PILLAR_CENTER,				ID.TWM_PILLAR_ZIGZAG,				ID.TWM_PILLAR_OFFSET,				ID.TWM_PILLAR_OFFSET				),
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG,				ID.TWM_PILLAR_OFFSET,				ID.TWM_PILLAR_ZIGZAG_MIRROR,		ID.TWM_PILLAR_ZIGZAG,				ID.TWM_PILLAR_ZIGZAG				),
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_MIRROR,		ID.TWM_PILLAR_ZIGZAG,				ID.TWM_PILLAR_2SIDES,				ID.TWM_PILLAR_ZIGZAG_MIRROR,		ID.TWM_PILLAR_ZIGZAG_MIRROR			),

			new ModuleChanges(ID.TWM_ZIGZAG_HALF_CARPET_FORWARD,				ID.TWM_ZIGZAG_HALF_CARPET_FORWARD,					ID.TWM_ZIGZAG_HALF_CARPET_FORWARD,					ID.TWM_ZIGZAG_HALF_CARPET_FORWARD,					ID.TWM_ZIGZAG_HALF_CARPET_FORWARD					),
			new ModuleChanges(ID.TWM_ZIGZAG_HALF_CARPET_BACKWARD,				ID.TWM_ZIGZAG_HALF_CARPET_BACKWARD,					ID.TWM_ZIGZAG_HALF_CARPET_BACKWARD,					ID.TWM_ZIGZAG_HALF_CARPET_BACKWARD,					ID.TWM_ZIGZAG_HALF_CARPET_BACKWARD					),
			new ModuleChanges(ID.TWM_ZIGZAG_HALF_CARPET_NEUTRAL,				ID.TWM_ZIGZAG_MIRROR_2,								ID.TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL,			ID.TWM_ZIGZAG_HALF_CARPET_FORWARD,					ID.TWM_ZIGZAG_HALF_CARPET_BACKWARD					),

			new ModuleChanges(ID.TWM_NARROW_SINGLE_CARPET,						ID.TWM_NARROW_SINGLE_CARPET,						ID.TWM_NARROW_CARPET,								ID.TWM_NARROW_SINGLE_CARPET,						ID.TWM_NARROW_SINGLE_CARPET							),

			new ModuleChanges(ID.TWM_PILLAR_CENTER_CARPET_FORWARD,				ID.TWM_PILLAR_CENTER_CARPET_FORWARD,				ID.TWM_PILLAR_CENTER_CARPET_FORWARD,				ID.TWM_PILLAR_CENTER_CARPET_FORWARD,				ID.TWM_PILLAR_CENTER_CARPET_FORWARD					),
			new ModuleChanges(ID.TWM_PILLAR_CENTER_CARPET_BACKWARD,				ID.TWM_PILLAR_CENTER_CARPET_BACKWARD,				ID.TWM_PILLAR_CENTER_CARPET_BACKWARD,				ID.TWM_PILLAR_CENTER_CARPET_BACKWARD,				ID.TWM_PILLAR_CENTER_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_PILLAR_CENTER_CARPET_NEUTRAL,				ID.TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL,			ID.TWM_PILLAR_OFFSET_CARPET_NEUTRAL,				ID.TWM_PILLAR_CENTER_CARPET_FORWARD,				ID.TWM_PILLAR_CENTER_CARPET_BACKWARD				),

			new ModuleChanges(ID.TWM_PILLAR_OFFSET_CARPET_FORWARD,				ID.TWM_PILLAR_OFFSET_CARPET_FORWARD,				ID.TWM_PILLAR_OFFSET_CARPET_FORWARD,				ID.TWM_PILLAR_OFFSET_CARPET_FORWARD,				ID.TWM_PILLAR_OFFSET_CARPET_FORWARD					),
			new ModuleChanges(ID.TWM_PILLAR_OFFSET_CARPET_BACKWARD,				ID.TWM_PILLAR_OFFSET_CARPET_BACKWARD,				ID.TWM_PILLAR_OFFSET_CARPET_BACKWARD,				ID.TWM_PILLAR_OFFSET_CARPET_BACKWARD,				ID.TWM_PILLAR_OFFSET_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_PILLAR_OFFSET_CARPET_NEUTRAL,				ID.TWM_PILLAR_CENTER_CARPET_NEUTRAL,				ID.TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL,				ID.TWM_PILLAR_OFFSET_CARPET_FORWARD,				ID.TWM_PILLAR_OFFSET_CARPET_BACKWARD				),

			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_CARPET_FORWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_FORWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_FORWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_FORWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_FORWARD					),
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_CARPET_BACKWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_BACKWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_BACKWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_BACKWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL,				ID.TWM_PILLAR_OFFSET_CARPET_NEUTRAL,				ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL,			ID.TWM_PILLAR_ZIGZAG_CARPET_FORWARD,				ID.TWM_PILLAR_ZIGZAG_CARPET_BACKWARD				),
			
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,		ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,			ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,			ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,			ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD,		ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD,		ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD,		ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD,		ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL,		ID.TWM_PILLAR_ZIGZAG_CARPET_NEUTRAL,				ID.TWM_PILLAR_2SIDES_CARPET_NEUTRAL,				ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_FORWARD,			ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_BACKWARD			),
			
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R				),
			
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L				),
	
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL,	ID.TWM_BANK_CORNER_20_2,							ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_1X1_05_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_1X1_10_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_2X2_05_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_1X1_20_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_2X2_10_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_3X3_05_CARPET_NEUTRAL,		ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_2X2_20_CARPET_L				),
			new ModuleChanges(ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL,	ID.TWM_BANK_SMOOTH_TURN_3X3_10_CARPET_NEUTRAL,		ID.TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL,				ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_R,			ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_L				),
			
			new ModuleChanges(ID.TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,			ID.TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD,			ID.TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL,			ID.TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL,				ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL,			ID.TWM_DOUBLE_STRAIGHT_CARPET_FORWARD,				ID.TWM_DOUBLE_STRAIGHT_CARPET_BACKWARD				),
			
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL,			ID.TWM_DOUBLE_STRAIGHT_CARPET_NEUTRAL,				ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_BACKWARD			),
			
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,		ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD,		ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL,		ID.TWM_DOUBLE_SIDE_ENTRY_CARPET_NEUTRAL,			ID.TWM_DOUBLE_SQUARE_TURN_CARPET,					ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_FORWARD,			ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_BACKWARD			),
			
			new ModuleChanges(ID.TWM_DOUBLE_SQUARE_TURN_CARPET,					ID.TWM_DOUBLE_SIDE_ENTRY_2_CARPET_NEUTRAL,			ID.TWM_DOUBLE_SQUARE_TURN_CARPET_2,					ID.TWM_DOUBLE_SQUARE_TURN_CARPET,					ID.TWM_DOUBLE_SQUARE_TURN_CARPET					),
			new ModuleChanges(ID.TWM_DOUBLE_SQUARE_TURN_CARPET_2,				ID.TWM_DOUBLE_SQUARE_TURN_CARPET,					ID.TWM_DOUBLE_ROUND_TURN_CARPET,					ID.TWM_DOUBLE_SQUARE_TURN_CARPET_2,					ID.TWM_DOUBLE_SQUARE_TURN_CARPET_2					),
			
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_CARPET,					ID.TWM_DOUBLE_SQUARE_TURN_CARPET_2,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_2,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_R,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_L					),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_CARPET_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_2,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2					),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_CARPET_L,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_L,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_L,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_L,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_L					),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_L_2					),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_CARPET_R,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_R,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_R,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_R,					ID.TWM_DOUBLE_ROUND_TURN_CARPET_R					),
			new ModuleChanges(ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2,				ID.TWM_DOUBLE_ROUND_TURN_CARPET_R_2					),
			
			new ModuleChanges(ID.TWM_BANK_UP_TURN_05_CARPET,					ID.TWM_BANK_UP_TURN2_20_CARPET,						ID.TWM_BANK_UP_TURN_10_CARPET,						ID.TWM_BANK_UP_TURN_05_CARPET,						ID.TWM_BANK_UP_TURN_05_CARPET						),
			new ModuleChanges(ID.TWM_BANK_UP_TURN_10_CARPET,					ID.TWM_BANK_UP_TURN_05_CARPET,						ID.TWM_BANK_UP_TURN_20_CARPET,						ID.TWM_BANK_UP_TURN_10_CARPET,						ID.TWM_BANK_UP_TURN_10_CARPET						),
			new ModuleChanges(ID.TWM_BANK_UP_TURN_20_CARPET,					ID.TWM_BANK_UP_TURN_10_CARPET,						ID.TWM_BANK_IN_05_2_N,								ID.TWM_BANK_UP_TURN_20_CARPET,						ID.TWM_BANK_UP_TURN_20_CARPET						),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN_05_CARPET,					ID.TWM_BANK_DOWN_TURN2_20_CARPET,					ID.TWM_BANK_DOWN_TURN_10_CARPET,					ID.TWM_BANK_DOWN_TURN_05_CARPET,					ID.TWM_BANK_DOWN_TURN_05_CARPET						),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN_10_CARPET,					ID.TWM_BANK_DOWN_TURN_05_CARPET,					ID.TWM_BANK_DOWN_TURN_20_CARPET,					ID.TWM_BANK_DOWN_TURN_10_CARPET,					ID.TWM_BANK_DOWN_TURN_10_CARPET						),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN_20_CARPET,					ID.TWM_BANK_DOWN_TURN_10_CARPET,					ID.TWM_BANK_UP_TURN2_05_CARPET,						ID.TWM_BANK_DOWN_TURN_20_CARPET,					ID.TWM_BANK_DOWN_TURN_20_CARPET						),
			new ModuleChanges(ID.TWM_BANK_UP_TURN2_05_CARPET,					ID.TWM_BANK_DOWN_TURN_20_CARPET,					ID.TWM_BANK_UP_TURN2_10_CARPET,						ID.TWM_BANK_UP_TURN2_05_CARPET,						ID.TWM_BANK_UP_TURN2_05_CARPET						),
			new ModuleChanges(ID.TWM_BANK_UP_TURN2_10_CARPET,					ID.TWM_BANK_UP_TURN2_05_CARPET,						ID.TWM_BANK_UP_TURN2_20_CARPET,						ID.TWM_BANK_UP_TURN2_10_CARPET,						ID.TWM_BANK_UP_TURN2_10_CARPET						),
			new ModuleChanges(ID.TWM_BANK_UP_TURN2_20_CARPET,					ID.TWM_BANK_UP_TURN2_10_CARPET,						ID.TWM_BANK_UP_TURN_05_CARPET,						ID.TWM_BANK_UP_TURN2_20_CARPET,						ID.TWM_BANK_UP_TURN2_20_CARPET						),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN2_05_CARPET,					ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL,		ID.TWM_BANK_DOWN_TURN2_10_CARPET,					ID.TWM_BANK_DOWN_TURN2_05_CARPET,					ID.TWM_BANK_DOWN_TURN2_05_CARPET					),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN2_10_CARPET,					ID.TWM_BANK_DOWN_TURN2_05_CARPET,					ID.TWM_BANK_DOWN_TURN2_20_CARPET,					ID.TWM_BANK_DOWN_TURN2_10_CARPET,					ID.TWM_BANK_DOWN_TURN2_10_CARPET					),
			new ModuleChanges(ID.TWM_BANK_DOWN_TURN2_20_CARPET,					ID.TWM_BANK_DOWN_TURN2_10_CARPET,					ID.TWM_BANK_DOWN_TURN_05_CARPET,					ID.TWM_BANK_DOWN_TURN2_20_CARPET,					ID.TWM_BANK_DOWN_TURN2_20_CARPET					),
			
			new ModuleChanges(ID.TWM_HUMP_SQUARE_CARPET,						ID.TWM_HUMP_XT_2,									ID.TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL,				ID.TWM_HUMP_SQUARE_CARPET,							ID.TWM_HUMP_SQUARE_CARPET							),
			new ModuleChanges(ID.TWM_DIP_SQUARE_CARPET,							ID.TWM_DIP_XT_2,									ID.TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL,				ID.TWM_DIP_SQUARE_CARPET,							ID.TWM_DIP_SQUARE_CARPET							),
			new ModuleChanges(ID.TWM_RUMBLE_DOWN_CARPET,						ID.TWM_RUMBLE_04_2,									ID.TWM_RUMBLE_DOWN_CARPET,							ID.TWM_RUMBLE_DOWN_CARPET,							ID.TWM_RUMBLE_DOWN_CARPET							),
			
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_10_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_20_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_CARPET_FORWARD,				ID.TWM_BANK_5_TO_10_CARPET_FORWARD,					ID.TWM_BANK_5_TO_10_CARPET_FORWARD,					ID.TWM_BANK_5_TO_10_CARPET_FORWARD,					ID.TWM_BANK_5_TO_10_CARPET_FORWARD					),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_CARPET_FORWARD					),
			
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_2_CARPET_FORWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_FORWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_FORWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_FORWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_2_CARPET_FORWARD,			ID.TWM_BANK_10_TO_20_2_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_FORWARD				),
			
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD		),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD		),
			
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_5_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_CARPET_BACKWARD					),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_CARPET_BACKWARD				),
			
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_2_CARPET_BACKWARD,			ID.TWM_BANK_5_TO_10_2_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_BACKWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_2_CARPET_BACKWARD,			ID.TWM_BANK_10_TO_20_2_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_BACKWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_BACKWARD				),
			
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD,	ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD,	ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD		),
			
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL,				ID.TWM_BANK_SMOOTH_TURN_3X3_20_CARPET_NEUTRAL,		ID.TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_5_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL,			ID.TWM_BANK_FLAT_TO_5_CARPET_NEUTRAL,				ID.TWM_BANK_5_TO_10_CARPET_NEUTRAL,					ID.TWM_BANK_FLAT_TO_10_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_10_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL,			ID.TWM_BANK_5_TO_10_CARPET_NEUTRAL,					ID.TWM_BANK_10_TO_20_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_20_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_20_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_10_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL,				ID.TWM_BANK_5_TO_10_CARPET_FORWARD,					ID.TWM_BANK_5_TO_10_CARPET_BACKWARD					),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_20_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL,				ID.TWM_BANK_10_TO_20_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_CARPET_BACKWARD				),
			
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL,			ID.TWM_BANK_10_TO_20_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_FORWARD,				ID.TWM_BANK_FLAT_TO_5_2_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL,			ID.TWM_BANK_FLAT_TO_5_2_CARPET_NEUTRAL,				ID.TWM_BANK_5_TO_10_2_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_10_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_10_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL,			ID.TWM_BANK_5_TO_10_2_CARPET_NEUTRAL,				ID.TWM_BANK_10_TO_20_2_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_20_2_CARPET_FORWARD,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_5_TO_10_2_CARPET_NEUTRAL,				ID.TWM_BANK_FLAT_TO_10_2_CARPET_NEUTRAL,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL,			ID.TWM_BANK_5_TO_10_2_CARPET_FORWARD,				ID.TWM_BANK_5_TO_10_2_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_BANK_10_TO_20_2_CARPET_NEUTRAL,			ID.TWM_BANK_FLAT_TO_20_2_CARPET_NEUTRAL,			ID.TWM_BANK_10_TO_20_2_CARPET_NEUTRAL,				ID.TWM_BANK_10_TO_20_2_CARPET_FORWARD,				ID.TWM_BANK_10_TO_20_2_CARPET_BACKWARD				),
			
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_5_TO_5_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_10_TO_10_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_10_TO_10_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_10_TO_10_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_20_TO_20_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_20_TO_20_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_20_TO_20_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_FORWARD,			ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_5_TO_5_2_CARPET_NEUTRAL,			ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_NEUTRAL,		ID.TWM_BANK_SWITCH_10_TO_10_2_CARPET_NEUTRAL,		ID.TWM_BANK_DOWN_TURN2_05_CARPET,					ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_FORWARD,		ID.TWM_BANK_SWITCH_20_TO_20_2_CARPET_BACKWARD		),
			
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD				),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD		),
			
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD	),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD	),
			
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL,			ID.TWM_DIAGONAL_02_2_LH,							ID.TWM_DIAGONAL_SMOOTH_CARPET_FORWARD,				ID.TWM_DIAGONAL_SMOOTH_CARPET_BACKWARD				),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_CARPET_NEUTRAL,				ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL,			ID.TWM_DIAGONAL_02_2,								ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_2_CARPET_FORWARD,			ID.TWM_DIAGONAL_SMOOTH_2_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_2_CARPET_NEUTRAL,			ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_UP5_CARPET_NEUTRAL,			ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_UP5_2_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_FORWARD,		ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_5_2_CARPET_NEUTRAL,		ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_BACKWARD	),
			new ModuleChanges(ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_10_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_NEUTRAL,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_FORWARD,	ID.TWM_DIAGONAL_SMOOTH_BANK_20_2_CARPET_BACKWARD	),
		
			new ModuleChanges(ID.TWM_NARROW_CARPET, ID.TWM_NARROW_SINGLE_CARPET, ID.TWM_NARROWF_2, ID.TWM_NARROW_CARPET, ID.TWM_NARROW_CARPET), //narrow copy so narrow have its carpet variant available

			new ModuleChanges(ID.TWM_DIP_R_2_FORWARD,						ID.TWM_DIP_R_2_FORWARD,							ID.TWM_DIP_R_2_FORWARD,							ID.TWM_DIP_R_2_FORWARD,							ID.TWM_DIP_R_2_FORWARD						),			
			new ModuleChanges(ID.TWM_DIP_X_2_FORWARD,						ID.TWM_DIP_X_2_FORWARD,							ID.TWM_DIP_X_2_FORWARD,							ID.TWM_DIP_X_2_FORWARD,							ID.TWM_DIP_X_2_FORWARD						),			
			new ModuleChanges(ID.TWM_DIP_XT_2_FORWARD,						ID.TWM_DIP_XT_2_FORWARD,						ID.TWM_DIP_XT_2_FORWARD,						ID.TWM_DIP_XT_2_FORWARD,						ID.TWM_DIP_XT_2_FORWARD						),			
			new ModuleChanges(ID.TWM_HUMP_R_2_FORWARD,						ID.TWM_HUMP_R_2_FORWARD,						ID.TWM_HUMP_R_2_FORWARD,						ID.TWM_HUMP_R_2_FORWARD,						ID.TWM_HUMP_R_2_FORWARD						),			
			new ModuleChanges(ID.TWM_HUMP_X_2_FORWARD,						ID.TWM_HUMP_X_2_FORWARD,						ID.TWM_HUMP_X_2_FORWARD,						ID.TWM_HUMP_X_2_FORWARD,						ID.TWM_HUMP_X_2_FORWARD						),			
			new ModuleChanges(ID.TWM_HUMP_XT_2_FORWARD,						ID.TWM_HUMP_XT_2_FORWARD,						ID.TWM_HUMP_XT_2_FORWARD,						ID.TWM_HUMP_XT_2_FORWARD,						ID.TWM_HUMP_XT_2_FORWARD					),			
			
			new ModuleChanges(ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD,		ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,		ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,			ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,			ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,			ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD			),						
			new ModuleChanges(ID.TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL,		ID.TWM_DIP_SQUARE_CARPET,						ID.TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL,			ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_DIP_ROUND_SMALL_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL,		ID.TWM_DIP_ROUND_SMALL_CARPET_NEUTRAL,			ID.TWM_DIP_ROUND_BIG_CARPET_NEUTRAL,			ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD,			ID.TWM_DIP_ROUND_MEDIUM_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_DIP_ROUND_BIG_CARPET_NEUTRAL,			ID.TWM_DIP_ROUND_MEDIUM_CARPET_NEUTRAL,			ID.TWM_DIP_ROUND_BIG_CARPET_NEUTRAL,			ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_DIP_ROUND_BIG_CARPET_FORWARD			),						
			
			new ModuleChanges(ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,		ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,		ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,		ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,		ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,		ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD		),						
			new ModuleChanges(ID.TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL,		ID.TWM_HUMP_SQUARE_CARPET,						ID.TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL,		ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_SMALL_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL,		ID.TWM_HUMP_ROUND_SMALL_CARPET_NEUTRAL,			ID.TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL,			ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD,		ID.TWM_HUMP_ROUND_MEDIUM_CARPET_FORWARD		),							
			new ModuleChanges(ID.TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL,			ID.TWM_HUMP_ROUND_MEDIUM_CARPET_NEUTRAL,		ID.TWM_HUMP_ROUND_BIG_CARPET_NEUTRAL,			ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD,			ID.TWM_HUMP_ROUND_BIG_CARPET_FORWARD		),						
			
			new ModuleChanges(ID.TWM_RAMP_TOP,								ID.TWM_RAMP_BOTTOM,								ID.TWM_RAMP_TOP,								ID.TWM_RAMP_TOP,								ID.TWM_RAMP_TOP								),	
			new ModuleChanges(ID.TWM_RAMP_BOTTOM,							ID.TWM_RAMP_30,									ID.TWM_RAMP_TOP,								ID.TWM_RAMP_BOTTOM,								ID.TWM_RAMP_BOTTOM							),		
			
			new ModuleChanges(ID.TWM_RAMP_TOP_CARPET_FORWARD,				ID.TWM_RAMP_TOP_CARPET_FORWARD,					ID.TWM_RAMP_TOP_CARPET_FORWARD,					ID.TWM_RAMP_TOP_CARPET_FORWARD,					ID.TWM_RAMP_TOP_CARPET_FORWARD				),			
			new ModuleChanges(ID.TWM_RAMP_TOP_CARPET_BACKWARD,				ID.TWM_RAMP_TOP_CARPET_BACKWARD,				ID.TWM_RAMP_TOP_CARPET_BACKWARD,				ID.TWM_RAMP_TOP_CARPET_BACKWARD,				ID.TWM_RAMP_TOP_CARPET_BACKWARD				),			
			new ModuleChanges(ID.TWM_RAMP_TOP_CARPET_NEUTRAL,				ID.TWM_RAMP_BOTTOM_CARPET_NEUTRAL,				ID.TWM_RAMP_TOP_CARPET_NEUTRAL,					ID.TWM_RAMP_TOP_CARPET_FORWARD,					ID.TWM_RAMP_TOP_CARPET_BACKWARD				),			
			new ModuleChanges(ID.TWM_RAMP_BOTTOM_CARPET_FORWARD,			ID.TWM_RAMP_BOTTOM_CARPET_FORWARD,				ID.TWM_RAMP_BOTTOM_CARPET_FORWARD,				ID.TWM_RAMP_BOTTOM_CARPET_FORWARD,				ID.TWM_RAMP_BOTTOM_CARPET_FORWARD			),				
			new ModuleChanges(ID.TWM_RAMP_BOTTOM_CARPET_BACKWARD,			ID.TWM_RAMP_BOTTOM_CARPET_BACKWARD,				ID.TWM_RAMP_BOTTOM_CARPET_BACKWARD,				ID.TWM_RAMP_BOTTOM_CARPET_BACKWARD,				ID.TWM_RAMP_BOTTOM_CARPET_BACKWARD			),				
			new ModuleChanges(ID.TWM_RAMP_BOTTOM_CARPET_NEUTRAL,			ID.TWM_RAMP_30_2_N,								ID.TWM_RAMP_TOP_CARPET_NEUTRAL,					ID.TWM_RAMP_BOTTOM_CARPET_FORWARD,				ID.TWM_RAMP_BOTTOM_CARPET_BACKWARD			),				
			
			new ModuleChanges(ID.TWM_DIP_ROUND_SMALL,						ID.TWM_DIP_SQUARE,								ID.TWM_DIP_ROUND_MEDIUM,						ID.TWM_DIP_ROUND_SMALL,							ID.TWM_DIP_ROUND_SMALL						),			
			new ModuleChanges(ID.TWM_DIP_ROUND_MEDIUM,						ID.TWM_DIP_ROUND_SMALL,							ID.TWM_DIP_ROUND_BIG,							ID.TWM_DIP_ROUND_MEDIUM,						ID.TWM_DIP_ROUND_MEDIUM						),			
			new ModuleChanges(ID.TWM_DIP_ROUND_BIG,							ID.TWM_DIP_ROUND_MEDIUM,						ID.TWM_DIP_ROUND_BIG,							ID.TWM_DIP_ROUND_BIG,							ID.TWM_DIP_ROUND_BIG						),		
			
			new ModuleChanges(ID.TWM_HUMP_ROUND_SMALL,						ID.TWM_HUMP_SQUARE,								ID.TWM_HUMP_ROUND_MEDIUM,						ID.TWM_HUMP_ROUND_SMALL,						ID.TWM_HUMP_ROUND_SMALL						),			
			new ModuleChanges(ID.TWM_HUMP_ROUND_MEDIUM,						ID.TWM_HUMP_ROUND_SMALL,						ID.TWM_HUMP_ROUND_BIG,							ID.TWM_HUMP_ROUND_MEDIUM,						ID.TWM_HUMP_ROUND_MEDIUM					),			
			new ModuleChanges(ID.TWM_HUMP_ROUND_BIG,						ID.TWM_HUMP_ROUND_MEDIUM,						ID.TWM_HUMP_ROUND_BIG,							ID.TWM_HUMP_ROUND_BIG,							ID.TWM_HUMP_ROUND_BIG						),

			new ModuleChanges(ID.TWM_PILLAR_CENTER_LONG,					ID.TWM_ZIGZAG_HALF,								ID.TWM_PILLAR_CENTER,							ID.TWM_PILLAR_CENTER_LONG,						ID.TWM_PILLAR_CENTER_LONG					),
			new ModuleChanges(ID.TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_FORWARD	),
			new ModuleChanges(ID.TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD,	ID.TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD	),
			new ModuleChanges(ID.TWM_PILLAR_CENTER_LONG_CARPET_NEUTRAL,		ID.TWM_ZIGZAG_HALF_CARPET_NEUTRAL,				ID.TWM_PILLAR_CENTER_CARPET_NEUTRAL,			ID.TWM_PILLAR_CENTER_LONG_CARPET_FORWARD,		ID.TWM_PILLAR_CENTER_LONG_CARPET_BACKWARD	),

			new ModuleChanges(ID.TWM_PILLAR_2SIDES,							ID.TWM_PILLAR_ZIGZAG_MIRROR,					ID.TWM_PILLAR_1SIDE,							ID.TWM_PILLAR_2SIDES,							ID.TWM_PILLAR_2SIDES						),
			new ModuleChanges(ID.TWM_PILLAR_2SIDES_CARPET_FORWARD,			ID.TWM_PILLAR_2SIDES_CARPET_FORWARD,			ID.TWM_PILLAR_2SIDES_CARPET_FORWARD,			ID.TWM_PILLAR_2SIDES_CARPET_FORWARD,			ID.TWM_PILLAR_2SIDES_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_PILLAR_2SIDES_CARPET_BACKWARD,			ID.TWM_PILLAR_2SIDES_CARPET_BACKWARD,			ID.TWM_PILLAR_2SIDES_CARPET_BACKWARD,			ID.TWM_PILLAR_2SIDES_CARPET_BACKWARD,			ID.TWM_PILLAR_2SIDES_CARPET_BACKWARD		),
			new ModuleChanges(ID.TWM_PILLAR_2SIDES_CARPET_NEUTRAL,			ID.TWM_PILLAR_ZIGZAG_MIRROR_CARPET_NEUTRAL,		ID.TWM_PILLAR_1SIDE_CARPET_NEUTRAL,				ID.TWM_PILLAR_2SIDES_CARPET_FORWARD,			ID.TWM_PILLAR_2SIDES_CARPET_BACKWARD		),

			new ModuleChanges(ID.TWM_PILLAR_1SIDE,							ID.TWM_PILLAR_2SIDES,							ID.TWM_PILLAR_1SIDE,							ID.TWM_PILLAR_1SIDE,							ID.TWM_PILLAR_1SIDE							),
			new ModuleChanges(ID.TWM_PILLAR_1SIDE_CARPET_FORWARD,			ID.TWM_PILLAR_1SIDE_CARPET_FORWARD,				ID.TWM_PILLAR_1SIDE_CARPET_FORWARD,				ID.TWM_PILLAR_1SIDE_CARPET_FORWARD,				ID.TWM_PILLAR_1SIDE_CARPET_FORWARD			),
			new ModuleChanges(ID.TWM_PILLAR_1SIDE_CARPET_BACKWARD,			ID.TWM_PILLAR_1SIDE_CARPET_BACKWARD,			ID.TWM_PILLAR_1SIDE_CARPET_BACKWARD,			ID.TWM_PILLAR_1SIDE_CARPET_BACKWARD,			ID.TWM_PILLAR_1SIDE_CARPET_BACKWARD			),
			new ModuleChanges(ID.TWM_PILLAR_1SIDE_CARPET_NEUTRAL,			ID.TWM_PILLAR_2SIDES_CARPET_NEUTRAL,			ID.TWM_PILLAR_1SIDE_CARPET_NEUTRAL,				ID.TWM_PILLAR_1SIDE_CARPET_FORWARD,				ID.TWM_PILLAR_1SIDE_CARPET_BACKWARD			),

			new ModuleChanges(ID.TWM_CROSS_ROAD_2_LINES, ID.TWM_BANK_CROSS_ROAD_20, ID.TWM_CROSS_ROAD_2_LINES, ID.TWM_CROSS_ROAD_2_LINES, ID.TWM_CROSS_ROAD_2_LINES),
		};

	}

	public struct ModuleGroup
    {
		public LocString Name;
		public int[] ModuleIDs;

		public bool HasVariant => (ModuleIDs[0] != ModuleIDs[1]);

		public ModuleGroup(LocString name, int moduleId0, int moduleId1)
        {
			Name = name;
			ModuleIDs = new int[] { moduleId0, moduleId1 };
        }

		public ModuleGroup(LocString name, ID moduleId0, ID moduleId1) : this(name, (int)moduleId0, (int)moduleId1)
        {

        }
    }

	public struct ModuleChanges
    {
        public int Original;
        public int PreviousVar;
        public int NextVar;
        public int Forward;
        public int Reverse;

        public ModuleChanges(int original, int previousVar, int nextVar, int forward, int reverse)
        {
            this.Original = original;
            this.PreviousVar = previousVar;
            this.NextVar = nextVar;
            this.Forward = forward;
            this.Reverse = reverse;
        }

		public ModuleChanges(ID original, ID previousVar, ID nextVar, ID forward, ID reverse) :
			this((int)original, (int)previousVar, (int)nextVar, (int)forward, (int)reverse)
		{ }

		public bool HasVariants()
		{
			return (int)this.Original != (int)this.Forward;
		}
		public bool HasSingleDirectionVariant()
		{
			return this.HasVariants() && (int)this.Forward == (int)this.Reverse;
		}
    }

    public struct ModuleGroupInfo
    {
        public int ModuleID;
        public int AlternateID;
        public int TextIndex;

        public ModuleGroupInfo(int moduleId, int alternateId, int textIndex)
        {
            this.ModuleID = moduleId;
            this.AlternateID = alternateId;
            this.TextIndex = textIndex;
        }
    }
}
