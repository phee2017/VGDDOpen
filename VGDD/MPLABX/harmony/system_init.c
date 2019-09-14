// ----------------------------------------------------------------------------
// VGDD system.c Skeleton
// System level initializations for the specific Development Board used
// ----------------------------------------------------------------------------
// FileName:          system.c
// Generated by:      VGDD [VGDDVERSION] MPLAB X Wizard [COPYRIGHT]
// Dependencies:      vgdd_main.h, [PROJECTFILENAME_SCREENSC], [PROJECTFILENAME_SCREENSH]
// Compiler:          [COMPILER]
// Development Board: [DEVBOARD]
// Expansion Board:   [EXPANSIONBOARD]
// Display Board:     [DISPLAYBOARD] - Orientation: [DISP_ORIENTATION] degrees
// Company:           VirtualFab, with adapted parts from Microchip Technology Incorporated
//
// ----------------------------------------------------------------------------
// VirtualFab Software License Agreement:
// ----------------------------------------------------------------------------
// [COPYRIGHT] - All rights reserved.
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// Redistributions of source code must retain the above and following copyright notices,
// this list of conditions and the following disclaimer.
// Neither the name of Fabio Violino or VirtualFab may be used to endorse or promote 
// products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE AUTHOR �AS IS� AND ANY EXPRESS OR IMPLIED WARRANTIES,
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
// IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT 
// OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY 
// OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
// ----------------------------------------------------------------------------
// Microchip's Software License Agreement:
// ----------------------------------------------------------------------------
// Copyright (c) 2013-2015 released Microchip Technology Inc.  All rights reserved.
// 
// Microchip licenses to you the right to use, modify, copy and distribute
// Software only when embedded on a Microchip microcontroller or digital signal
// controller that is integrated into your product or third party product
// (pursuant to the sublicense terms in the accompanying license agreement).
// 
// You should refer to the license agreement accompanying this Software for
// additional information regarding your rights and obligations.
// 
// SOFTWARE AND DOCUMENTATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY KIND,
// EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION, ANY WARRANTY OF
// MERCHANTABILITY, TITLE, NON-INFRINGEMENT AND FITNESS FOR A PARTICULAR PURPOSE.
// IN NO EVENT SHALL MICROCHIP OR ITS LICENSORS BE LIABLE OR OBLIGATED UNDER
// CONTRACT, NEGLIGENCE, STRICT LIABILITY, CONTRIBUTION, BREACH OF WARRANTY, OR
// OTHER LEGAL EQUITABLE THEORY ANY DIRECT OR INDIRECT DAMAGES OR EXPENSES
// INCLUDING BUT NOT LIMITED TO ANY INCIDENTAL, SPECIAL, INDIRECT, PUNITIVE OR
// CONSEQUENTIAL DAMAGES, LOST PROFITS OR LOST DATA, COST OF PROCUREMENT OF
// SUBSTITUTE GOODS, TECHNOLOGY, SERVICES, OR ANY CLAIMS BY THIRD PARTIES
// (INCLUDING BUT NOT LIMITED TO ANY DEFENSE THEREOF), OR OTHER SIMILAR COSTS.
// ----------------------------------------------------------------------------
// Author               Date        Comment
//
// VirtualFab        2016/03/23     Harmony 1.07.01
// ----------------------------------------------------------------------------
#include "app.h"

// --------------------------------------------------------------------
// ConfigBits
// --------------------------------------------------------------------
// <editor-fold defaultstate="collapsed" desc="Generated Code">
// VGDD_MPLABX_WIZARD_START_SECTION: ConfigBits *** DO NOT DELETE THIS LINE! ***
// These lines will be replaced by VGDD MPLAB X Wizard with lines for the ConfigBits Section
// Don't delete the starting and ending markers!
// VGDD_MPLABX_WIZARD_END_SECTION *** DO NOT DELETE THIS LINE! ***
// </editor-fold>

// --------------------------------------------------------------------
// SystemSettings
// --------------------------------------------------------------------
// <editor-fold defaultstate="collapsed" desc="Generated Code">
// VGDD_MPLABX_WIZARD_START_SECTION: SystemSettings *** DO NOT DELETE THIS LINE! ***
// These lines will be replaced by VGDD MPLAB X Wizard with lines for the SystemSettings Section
// Don't delete the starting and ending markers!
// VGDD_MPLABX_WIZARD_END_SECTION *** DO NOT DELETE THIS LINE! ***
// </editor-fold>

SYS_MODULE_OBJ   object, oSpiObject;
DRV_PMP_INIT     init;
//DRV_SPI_INIT     SPI_Init_Data; // MOVED
SYS_MSG_INSTANCE iSysMsg = SYS_MSG_0;
SYS_OBJ_HANDLE hSysMsg, hMsgType, hMailbox;
DRV_PMP_MODE_CONFIG cSpiCommConfig;
DRV_HANDLE hSpiHandle;

// --------------------------------------------------------------------
//   Function:
//     void SYS_Initialize ( void *data )
// 
//   Summary:
//     Initializes the board, services, drivers, application and other modules.
// 
//   Remarks:
//     See prototype in system/common/sys_module.h.

// <editor-fold defaultstate="collapsed" desc="Generated Code">
// VGDD_MPLABX_WIZARD_START_SECTION: InitializeObjects *** DO NOT DELETE THIS LINE! ***
// These lines will be replaced by VGDD MPLAB X Wizard with lines for the InitializeObjects Section
// Don't delete the starting and ending markers!
// VGDD_MPLABX_WIZARD_END_SECTION *** DO NOT DELETE THIS LINE! ***
// </editor-fold>

void SYS_Initialize ( void* data ) {   
// <editor-fold defaultstate="collapsed" desc="Generated Code">
// VGDD_MPLABX_WIZARD_START_SECTION: InitializeBoard *** DO NOT DELETE THIS LINE! ***
// These lines will be replaced by VGDD MPLAB X Wizard with lines for the InitializeBoard Section
// Don't delete the starting and ending markers!
// VGDD_MPLABX_WIZARD_END_SECTION *** DO NOT DELETE THIS LINE! ***
// </editor-fold>
}

// --------------------------------------------------------------------
// BSP Functions
// --------------------------------------------------------------------
// <editor-fold defaultstate="collapsed" desc="Generated Code">
// VGDD_MPLABX_WIZARD_START_SECTION: BspFunctions *** DO NOT DELETE THIS LINE! ***
// These lines will be replaced by VGDD MPLAB X Wizard with lines for the BspFunctions Section
// Don't delete the starting and ending markers!
// VGDD_MPLABX_WIZARD_END_SECTION *** DO NOT DELETE THIS LINE! ***
// </editor-fold>

// --------------------------------------------------------------------
// End of File
// --------------------------------------------------------------------
