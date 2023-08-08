﻿namespace ClothoSharedItems.Import.VISA
{
    public enum ViEventType
    {
        VI_EVENT_TRIG = -1073799158, // -0x4000DFF6
        VI_EVENT_EXCEPTION = -1073799154, // -0x4000DFF2
        VI_EVENT_VXI_VME_INTR = -1073799135, // -0x4000DFDF
        VI_EVENT_IO_COMPLETION = 1073684489, // 0x3FFF2009
        VI_EVENT_SERVICE_REQ = 1073684491, // 0x3FFF200B
        VI_EVENT_CLEAR = 1073684493, // 0x3FFF200D
        VI_EVENT_GPIB_CIC = 1073684498, // 0x3FFF2012
        VI_EVENT_GPIB_TALK = 1073684499, // 0x3FFF2013
        VI_EVENT_GPIB_LISTEN = 1073684500, // 0x3FFF2014
        VI_EVENT_VXI_VME_SYSFAIL = 1073684509, // 0x3FFF201D
        VI_EVENT_VXI_VME_SYSRESET = 1073684510, // 0x3FFF201E
        VI_EVENT_VXI_SIGP = 1073684512, // 0x3FFF2020
        VI_EVENT_TCPIP_CONNECT = 1073684534, // 0x3FFF2036
        VI_EVENT_USB_INTR = 1073684535, // 0x3FFF2037
        VI_ALL_ENABLED_EVENTS = 1073709055, // 0x3FFF7FFF
    }
}