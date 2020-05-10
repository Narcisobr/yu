using System;
using System.Collections.Generic;

namespace Lotd
{
    partial class NativeScript
    {
        public class Script_Lotd : Script
        {
            public Script_Lotd()
            {
                ScriptHash = "CEFC97D3F66F26ED49E065883270FC8F92E6193AD17846ED519E9F6EC04F13DF";
                GlobalsAddressOffset = 2;
                Functions = new Dictionary<string, int>()
                {
                    { "GetGlobals", 0 },
                    { "MillisecondsToSeconds", 32 },
                    { "Rand", 80 },
                    { "WriteProcessMemoryEx", 544 },
                    { "UnsafeHook", 752 },
                    { "UnsafeUnHook", 912 },
                    { "GetPopcornCoreAddress", 976 },
                    { "SetScreenState", 1040 },
                    { "SetScreenStateId", 1152 },
                    { "LoadDuel", 1248 },
                    { "LoadAndStartDuel", 1328 },
                    { "SetCardCollection", 1376 },
                    { "DeckEditSelectDeck", 1472 },
                    { "OpenDeckEditTrunkPanel", 1616 },
                    { "SetDeckEditTrunkCards", 1712 },
                    { "CardShopOpenPack", 1824 },
                    { "CardShopRefreshDuelPoints", 1968 },
                    { "InitCardShopPackOpener", 2032 },
                    { "PlayAudio", 2080 },
                    { "StopAudio", 2128 },
                    { "StopAllAudio", 2208 },
                    { "GetLoadBattlePackYdcFunctionAddress", 2272 },
                    { "HookLoadBattlePackYdc", 2304 },
                    { "UnhookLoadBattlePackYdc", 2368 },
                    { "LoadBattlePackYdc_hook", 2480 },
                    { "GetDuelInitDeckHandLPFunctionAddress", 2736 },
                    { "HookDuelInitDeckHandLP", 2768 },
                    { "UnhookDuelInitDeckHandLP", 2832 },
                    { "DuelInitDeckHandLP_hook", 2944 },
                    { "GetActionHandlerFunctionAddress", 3136 },
                    { "HookActionHandler", 3168 },
                    { "UnhookActionHandler", 3232 },
                    { "GetAnimationHandlerFunctionAddress", 3344 },
                    { "HookAnimationHandler", 3376 },
                    { "UnhookAnimationHandler", 3440 },
                    { "GetDuelThreadCriticalSection", 3552 },
                    { "ProcessAction", 3584 },
                    { "DoAction", 3648 },
                    { "ActionHandler_hook", 4592 },
                    { "AnimationHandler_hook", 4752 },
                    { "QueryPerformanceCounter_hook", 4912 },
                    { "GetTickCount64_hook", 5072 },
                    { "GetTickCount_hook", 5280 },
                    { "timeGetTime_hook", 5392 },
                    { "SetTimeMultiplierInfo", 5520 },
                    { "GetStructSizeInfo", 5568 },
                    { "EntryPoint", 5712 },
                };
                Buffer = new byte[]
                {
                    0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x18,0xC7,0x04,0x24,0xE8,0x03,0x00,0x00,
                    0xF2,0x48,0x0F,0x2A,0x44,0x24,0x20,0xF2,0x0F,0x2A,0x0C,0x24,0xF2,0x0F,0x5E,0xC1,
                    0x48,0x83,0xC4,0x18,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0xA7,0xFF,0xFF,0xFF,0x48,0x89,0x44,0x24,0x28,0xC7,0x44,
                    0x24,0x20,0x00,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x28,0x83,0xB8,0x98,0x00,0x00,
                    0x00,0x02,0x77,0x0F,0x48,0x8B,0x44,0x24,0x28,0xC7,0x80,0x98,0x00,0x00,0x00,0x39,
                    0x30,0x00,0x00,0x48,0x8B,0x44,0x24,0x28,0x83,0xB8,0x9C,0x00,0x00,0x00,0x04,0x77,
                    0x0F,0x48,0x8B,0x44,0x24,0x28,0xC7,0x80,0x9C,0x00,0x00,0x00,0x39,0x30,0x00,0x00,
                    0x48,0x8B,0x44,0x24,0x28,0x83,0xB8,0xA0,0x00,0x00,0x00,0x10,0x77,0x0F,0x48,0x8B,
                    0x44,0x24,0x28,0xC7,0x80,0xA0,0x00,0x00,0x00,0x39,0x30,0x00,0x00,0x48,0x8B,0x44,
                    0x24,0x28,0x81,0xB8,0xA4,0x00,0x00,0x00,0x80,0x00,0x00,0x00,0x77,0x0F,0x48,0x8B,
                    0x44,0x24,0x28,0xC7,0x80,0xA4,0x00,0x00,0x00,0x39,0x30,0x00,0x00,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0x98,0x00,0x00,0x00,0xC1,0xE0,0x06,0x48,0x8B,0x4C,0x24,0x28,
                    0x33,0x81,0x98,0x00,0x00,0x00,0xC1,0xE8,0x0D,0x89,0x44,0x24,0x20,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0x98,0x00,0x00,0x00,0x83,0xE0,0xFE,0xC1,0xE0,0x12,0x33,0x44,
                    0x24,0x20,0x48,0x8B,0x4C,0x24,0x28,0x89,0x81,0x98,0x00,0x00,0x00,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0x9C,0x00,0x00,0x00,0xC1,0xE0,0x02,0x48,0x8B,0x4C,0x24,0x28,
                    0x33,0x81,0x9C,0x00,0x00,0x00,0xC1,0xE8,0x1B,0x89,0x44,0x24,0x20,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0x9C,0x00,0x00,0x00,0x83,0xE0,0xF8,0xC1,0xE0,0x02,0x33,0x44,
                    0x24,0x20,0x48,0x8B,0x4C,0x24,0x28,0x89,0x81,0x9C,0x00,0x00,0x00,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0xA0,0x00,0x00,0x00,0xC1,0xE0,0x0D,0x48,0x8B,0x4C,0x24,0x28,
                    0x33,0x81,0xA0,0x00,0x00,0x00,0xC1,0xE8,0x15,0x89,0x44,0x24,0x20,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0xA0,0x00,0x00,0x00,0x83,0xE0,0xF0,0xC1,0xE0,0x07,0x33,0x44,
                    0x24,0x20,0x48,0x8B,0x4C,0x24,0x28,0x89,0x81,0xA0,0x00,0x00,0x00,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0xA4,0x00,0x00,0x00,0xC1,0xE0,0x03,0x48,0x8B,0x4C,0x24,0x28,
                    0x33,0x81,0xA4,0x00,0x00,0x00,0xC1,0xE8,0x0C,0x89,0x44,0x24,0x20,0x48,0x8B,0x44,
                    0x24,0x28,0x8B,0x80,0xA4,0x00,0x00,0x00,0x83,0xE0,0x80,0xC1,0xE0,0x0D,0x33,0x44,
                    0x24,0x20,0x48,0x8B,0x4C,0x24,0x28,0x89,0x81,0xA4,0x00,0x00,0x00,0x48,0x8B,0x44,
                    0x24,0x28,0x48,0x8B,0x4C,0x24,0x28,0x8B,0x89,0x9C,0x00,0x00,0x00,0x8B,0x80,0x98,
                    0x00,0x00,0x00,0x33,0xC1,0x48,0x8B,0x4C,0x24,0x28,0x33,0x81,0xA0,0x00,0x00,0x00,
                    0x48,0x8B,0x4C,0x24,0x28,0x33,0x81,0xA4,0x00,0x00,0x00,0x48,0x83,0xC4,0x38,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x4C,0x89,0x4C,0x24,0x20,0x4C,0x89,0x44,0x24,0x18,0x48,0x89,0x54,0x24,0x10,0x48,
                    0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x58,0xE8,0xC3,0xFD,0xFF,0xFF,0x48,0x89,0x44,
                    0x24,0x38,0x48,0x8B,0x44,0x24,0x38,0xFF,0x50,0x08,0x48,0x89,0x44,0x24,0x40,0x48,
                    0x8B,0x44,0x24,0x78,0x48,0x89,0x44,0x24,0x20,0x4C,0x8B,0x4C,0x24,0x70,0x4C,0x8B,
                    0x44,0x24,0x68,0x48,0x8B,0x54,0x24,0x60,0x48,0x8B,0x4C,0x24,0x40,0x48,0x8B,0x44,
                    0x24,0x38,0xFF,0x50,0x10,0x85,0xC0,0x75,0x65,0x4C,0x8D,0x4C,0x24,0x30,0x41,0xB8,
                    0x40,0x00,0x00,0x00,0x48,0x8B,0x54,0x24,0x70,0x48,0x8B,0x4C,0x24,0x60,0x48,0x8B,
                    0x44,0x24,0x38,0xFF,0x50,0x18,0x85,0xC0,0x75,0x02,0xEB,0x42,0x48,0x8B,0x44,0x24,
                    0x78,0x48,0x89,0x44,0x24,0x20,0x4C,0x8B,0x4C,0x24,0x70,0x4C,0x8B,0x44,0x24,0x68,
                    0x48,0x8B,0x54,0x24,0x60,0x48,0x8B,0x4C,0x24,0x40,0x48,0x8B,0x44,0x24,0x38,0xFF,
                    0x50,0x10,0x4C,0x8D,0x4C,0x24,0x30,0x44,0x8B,0x44,0x24,0x30,0x48,0x8B,0x54,0x24,
                    0x70,0x48,0x8B,0x4C,0x24,0x60,0x48,0x8B,0x44,0x24,0x38,0xFF,0x50,0x18,0x48,0x83,
                    0xC4,0x58,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x54,0x24,0x10,0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x48,0xB8,0x01,
                    0x00,0x00,0x00,0x48,0x6B,0xC0,0x00,0xC6,0x44,0x04,0x28,0xFF,0xB8,0x01,0x00,0x00,
                    0x00,0x48,0x6B,0xC0,0x01,0xC6,0x44,0x04,0x28,0x25,0xB8,0x01,0x00,0x00,0x00,0x48,
                    0x6B,0xC0,0x02,0xC6,0x44,0x04,0x28,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0x6B,0xC0,
                    0x03,0xC6,0x44,0x04,0x28,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0x6B,0xC0,0x04,0xC6,
                    0x44,0x04,0x28,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0x6B,0xC0,0x05,0xC6,0x44,0x04,
                    0x28,0x00,0x48,0x8B,0x44,0x24,0x58,0x48,0x89,0x44,0x24,0x2E,0x4C,0x8D,0x4C,0x24,
                    0x20,0x41,0xB8,0x0E,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x28,0x48,0x8B,0x4C,0x24,
                    0x50,0xE8,0xAA,0xFE,0xFF,0xFF,0x48,0x83,0xC4,0x48,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x44,0x89,0x44,0x24,0x18,0x48,0x89,0x54,0x24,0x10,0x48,0x89,0x4C,0x24,0x08,0x48,
                    0x83,0xEC,0x38,0x48,0x63,0x44,0x24,0x50,0x4C,0x8D,0x4C,0x24,0x20,0x4C,0x8B,0xC0,
                    0x48,0x8B,0x54,0x24,0x48,0x48,0x8B,0x4C,0x24,0x40,0xE8,0x61,0xFE,0xFF,0xFF,0x48,
                    0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x18,0x48,0xB8,0x48,0x21,0xEA,0x40,0x01,0x00,0x00,0x00,0x48,0x8B,
                    0x00,0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x8B,0x80,0xD8,0x01,0x00,0x00,
                    0x48,0x89,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x18,0xC3,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x58,0xE8,0xB2,0xFF,0xFF,0xFF,0x48,0x89,
                    0x44,0x24,0x40,0x48,0x8B,0x44,0x24,0x60,0x8B,0x00,0x89,0x44,0x24,0x34,0x48,0x8B,
                    0x44,0x24,0x60,0x8B,0x40,0x04,0x89,0x44,0x24,0x30,0x48,0x8B,0x44,0x24,0x60,0xF2,
                    0x0F,0x10,0x40,0x08,0xF2,0x0F,0x11,0x44,0x24,0x38,0xC6,0x44,0x24,0x20,0x01,0x44,
                    0x8B,0x4C,0x24,0x30,0xF2,0x0F,0x10,0x54,0x24,0x38,0x8B,0x54,0x24,0x34,0x48,0x8B,
                    0x4C,0x24,0x40,0x48,0xB8,0x40,0xD1,0x62,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,
                    0x83,0xC4,0x58,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x38,0x8B,0x44,0x24,0x40,0x89,0x44,0x24,0x20,
                    0xC7,0x44,0x24,0x24,0x11,0x01,0x00,0x00,0xE8,0x63,0xFB,0xFF,0xFF,0x83,0xB8,0xA8,
                    0x00,0x00,0x00,0x00,0x74,0x12,0xB9,0x96,0x00,0x00,0x00,0xE8,0x70,0xFB,0xFF,0xFF,
                    0xF2,0x0F,0x11,0x44,0x24,0x28,0xEB,0x09,0x0F,0x57,0xC0,0xF2,0x0F,0x11,0x44,0x24,
                    0x28,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x45,0xFF,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x38,0xE8,0x12,0xFB,0xFF,0xFF,0x48,0x89,
                    0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x20,0x8B,0x88,0x94,0x01,0x00,0x00,0x48,0x8B,
                    0x44,0x24,0x20,0xFF,0x50,0x30,0x48,0xB8,0x30,0xF4,0x0C,0x41,0x01,0x00,0x00,0x00,
                    0x48,0x8B,0x08,0x48,0xB8,0x20,0x42,0x89,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,
                    0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x28,0x48,0x8B,0x4C,0x24,0x30,0xE8,0x9D,
                    0xFF,0xFF,0xFF,0xB9,0x0B,0x00,0x00,0x00,0xE8,0x33,0xFF,0xFF,0xFF,0x48,0x83,0xC4,
                    0x28,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x44,0x89,0x4C,0x24,0x20,0x4C,0x89,0x44,0x24,0x18,0x89,0x54,0x24,0x10,0x48,0x89,
                    0x4C,0x24,0x08,0x48,0x83,0xEC,0x38,0x48,0xC7,0x44,0x24,0x28,0x00,0x00,0x00,0x00,
                    0x48,0xC7,0x44,0x24,0x20,0x00,0x00,0x00,0x00,0x44,0x8B,0x4C,0x24,0x58,0x4C,0x8B,
                    0x44,0x24,0x50,0x8B,0x54,0x24,0x48,0x48,0x8B,0x4C,0x24,0x40,0x48,0xB8,0xB0,0x76,
                    0x65,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x48,0xE8,0x02,0xFE,0xFF,0xFF,0x48,0x89,
                    0x44,0x24,0x30,0x48,0x8B,0x44,0x24,0x30,0x48,0x8B,0x80,0x60,0x02,0x00,0x00,0x48,
                    0x89,0x44,0x24,0x28,0x48,0x8B,0x44,0x24,0x28,0x48,0x05,0xA8,0x16,0x00,0x00,0x48,
                    0x89,0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x20,0x48,0x05,0xE8,0x00,0x00,0x00,0x48,
                    0x89,0x44,0x24,0x38,0x8B,0x54,0x24,0x50,0x48,0x8B,0x4C,0x24,0x38,0x48,0xB8,0x10,
                    0xBD,0x6B,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x8B,0x4C,0x24,0x20,0x48,0xB8,
                    0x10,0xEB,0x65,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x8B,0x4C,0x24,0x28,0x48,
                    0xB8,0x30,0xDA,0x64,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x83,0xC4,0x48,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0x77,0xFD,0xFF,0xFF,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,
                    0x44,0x24,0x28,0x48,0x8B,0x80,0x60,0x02,0x00,0x00,0x48,0x89,0x44,0x24,0x20,0x48,
                    0x8B,0x44,0x24,0x20,0xC7,0x80,0xA8,0x02,0x00,0x00,0x02,0x00,0x00,0x00,0x48,0x8B,
                    0x44,0x24,0x20,0xC7,0x80,0x78,0x02,0x00,0x00,0x02,0x00,0x00,0x00,0x48,0x8B,0x4C,
                    0x24,0x20,0x48,0xB8,0xD0,0xE6,0x64,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x83,
                    0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x48,0xE8,0x12,0xFD,0xFF,0xFF,0x48,0x89,
                    0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x20,0x48,0x8B,0x80,0x60,0x02,0x00,0x00,0x48,
                    0x89,0x44,0x24,0x28,0x48,0x8B,0x44,0x24,0x28,0x48,0x05,0x28,0x26,0x00,0x00,0x48,
                    0x89,0x44,0x24,0x30,0x48,0x8B,0x44,0x24,0x50,0x48,0x83,0xC0,0x08,0x48,0x8B,0x4C,
                    0x24,0x50,0x44,0x8B,0x49,0x04,0x4C,0x8B,0xC0,0x48,0x8B,0x44,0x24,0x50,0x8B,0x10,
                    0x48,0x8B,0x4C,0x24,0x30,0xE8,0x56,0xFE,0xFF,0xFF,0x48,0x83,0xC4,0x48,0xC3,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x28,0x48,0x8B,0x44,0x24,0x30,0x48,0x83,
                    0xC0,0x04,0x48,0xB9,0xA0,0x21,0xEA,0x40,0x01,0x00,0x00,0x00,0x48,0x8B,0x09,0x48,
                    0x81,0xC1,0x60,0x08,0x00,0x00,0x41,0xB9,0xFF,0xFF,0xFF,0xFF,0x4C,0x8B,0xC0,0x48,
                    0x8B,0x44,0x24,0x30,0x8B,0x10,0xE8,0x05,0xFE,0xFF,0xFF,0x48,0xB8,0xA0,0x21,0xEA,
                    0x40,0x01,0x00,0x00,0x00,0x0F,0x57,0xD2,0xBA,0x02,0x00,0x00,0x00,0x48,0x8B,0x08,
                    0x48,0xB8,0x10,0x39,0x65,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0xB8,0xA0,0x21,
                    0xEA,0x40,0x01,0x00,0x00,0x00,0x0F,0x57,0xD2,0xBA,0x03,0x00,0x00,0x00,0x48,0x8B,
                    0x08,0x48,0xB8,0x10,0x39,0x65,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x83,0xC4,
                    0x28,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x28,0x48,0xB8,0xA0,0x21,0xEA,0x40,0x01,
                    0x00,0x00,0x00,0x48,0x8B,0x00,0x48,0x05,0x78,0x02,0x00,0x00,0x48,0x8B,0xC8,0x48,
                    0xB8,0x20,0x5C,0x68,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,0x83,0xC4,0x28,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x28,0xBA,0x08,0x00,0x00,0x00,0x48,0x8B,
                    0x4C,0x24,0x30,0x48,0xB8,0x10,0xE0,0x5D,0x40,0x01,0x00,0x00,0x00,0xFF,0xD0,0x48,
                    0x83,0xC4,0x28,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x28,0x48,0x83,0x7C,0x24,0x30,0x32,0x7D,
                    0x10,0x8B,0x4C,0x24,0x30,0x48,0xB8,0x70,0xEF,0x5E,0x40,0x01,0x00,0x00,0x00,0xFF,
                    0xD0,0x48,0x83,0xC4,0x28,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x38,0x48,0x83,0x7C,0x24,0x40,0x32,0x7D,
                    0x33,0x48,0xB8,0x40,0xB1,0xE8,0x40,0x01,0x00,0x00,0x00,0x48,0x8B,0x4C,0x24,0x40,
                    0x48,0x8B,0x04,0xC8,0x48,0x89,0x44,0x24,0x20,0x48,0x83,0x7C,0x24,0x20,0x00,0x74,
                    0x13,0x33,0xD2,0x48,0x8B,0x4C,0x24,0x20,0x48,0xB8,0xD0,0x94,0x8F,0x40,0x01,0x00,
                    0x00,0x00,0xFF,0xD0,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x38,0xC7,0x44,0x24,0x20,0x00,0x00,0x00,
                    0x00,0xEB,0x0A,0x8B,0x44,0x24,0x20,0xFF,0xC0,0x89,0x44,0x24,0x20,0x83,0x7C,0x24,
                    0x20,0x32,0x7D,0x0F,0x48,0x63,0x44,0x24,0x20,0x48,0x8B,0xC8,0xE8,0x7F,0xFF,0xFF,
                    0xFF,0xEB,0xE0,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0xB8,0xE0,0xE9,0x88,0x40,0x01,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0xF7,0xF6,0xFF,0xFF,0x48,0x89,0x44,0x24,0x20,0xE8,0xCD,
                    0xFF,0xFF,0xFF,0x48,0x8B,0x4C,0x24,0x20,0x48,0x8B,0x91,0xA8,0x01,0x00,0x00,0x48,
                    0x8B,0xC8,0xE8,0xC9,0xF9,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xC6,0x44,0x24,0x20,0x48,0xC6,0x44,0x24,0x21,0x8B,0xC6,0x44,
                    0x24,0x22,0xC4,0xC6,0x44,0x24,0x23,0x57,0xC6,0x44,0x24,0x24,0x48,0xC6,0x44,0x24,
                    0x25,0x81,0xC6,0x44,0x24,0x26,0xEC,0xC6,0x44,0x24,0x27,0x60,0xC6,0x44,0x24,0x28,
                    0x01,0xC6,0x44,0x24,0x29,0x00,0xC6,0x44,0x24,0x2A,0x00,0xC6,0x44,0x24,0x2B,0x48,
                    0xC6,0x44,0x24,0x2C,0xC7,0xC6,0x44,0x24,0x2D,0x44,0xE8,0x51,0xFF,0xFF,0xFF,0x41,
                    0xB8,0x0E,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x20,0x48,0x8B,0xC8,0xE8,0xEE,0xF9,
                    0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x4C,0x89,0x4C,0x24,0x20,0x4C,0x89,0x44,0x24,0x18,0x48,0x89,0x54,0x24,0x10,0x48,
                    0x89,0x4C,0x24,0x08,0x56,0x57,0x48,0x83,0xEC,0x48,0xE8,0x31,0xF6,0xFF,0xFF,0x48,
                    0x89,0x44,0x24,0x30,0xC7,0x44,0x24,0x24,0x00,0x00,0x00,0x00,0xC7,0x44,0x24,0x20,
                    0x00,0x00,0x00,0x00,0xEB,0x0A,0x8B,0x44,0x24,0x20,0xFF,0xC0,0x89,0x44,0x24,0x20,
                    0x83,0x7C,0x24,0x20,0x64,0x7D,0x29,0x48,0x63,0x44,0x24,0x20,0x48,0x69,0xC0,0x30,
                    0x01,0x00,0x00,0x48,0x8B,0x4C,0x24,0x30,0x83,0xBC,0x01,0xE0,0x02,0x00,0x00,0x00,
                    0x75,0x02,0xEB,0x0C,0x8B,0x44,0x24,0x24,0xFF,0xC0,0x89,0x44,0x24,0x24,0xEB,0xC6,
                    0x48,0x8B,0x44,0x24,0x30,0x83,0xB8,0xB0,0x01,0x00,0x00,0x00,0x74,0x07,0x83,0x7C,
                    0x24,0x24,0x00,0x75,0x2F,0xE8,0x06,0xFF,0xFF,0xFF,0xE8,0xA1,0xFE,0xFF,0xFF,0x4C,
                    0x8B,0x4C,0x24,0x78,0x4C,0x8B,0x44,0x24,0x70,0x48,0x8B,0x54,0x24,0x68,0x48,0x8B,
                    0x4C,0x24,0x60,0xFF,0xD0,0x89,0x44,0x24,0x28,0xE8,0xA2,0xFE,0xFF,0xFF,0x8B,0x44,
                    0x24,0x28,0xEB,0x34,0xE8,0xE7,0xF5,0xFF,0xFF,0x33,0xD2,0xF7,0x74,0x24,0x24,0x8B,
                    0xC2,0x8B,0xC0,0x48,0x69,0xC0,0x30,0x01,0x00,0x00,0x48,0x8B,0x4C,0x24,0x30,0x48,
                    0x8B,0x7C,0x24,0x68,0x48,0x8D,0xB4,0x01,0xB4,0x01,0x00,0x00,0xB9,0x30,0x01,0x00,
                    0x00,0xF3,0xA4,0xB8,0x01,0x00,0x00,0x00,0x48,0x83,0xC4,0x48,0x5F,0x5E,0xC3,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0xB8,0x80,0x0A,0x08,0x40,0x01,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0x27,0xF5,0xFF,0xFF,0x48,0x89,0x44,0x24,0x20,0xE8,0xCD,
                    0xFF,0xFF,0xFF,0x48,0x8B,0x4C,0x24,0x20,0x48,0x8B,0x91,0x98,0x01,0x00,0x00,0x48,
                    0x8B,0xC8,0xE8,0xF9,0xF7,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xC6,0x44,0x24,0x20,0x40,0xC6,0x44,0x24,0x21,0x53,0xC6,0x44,
                    0x24,0x22,0x48,0xC6,0x44,0x24,0x23,0x83,0xC6,0x44,0x24,0x24,0xEC,0xC6,0x44,0x24,
                    0x25,0x20,0xC6,0x44,0x24,0x26,0x83,0xC6,0x44,0x24,0x27,0x3D,0xC6,0x44,0x24,0x28,
                    0x7F,0xC6,0x44,0x24,0x29,0x00,0xC6,0x44,0x24,0x2A,0x10,0xC6,0x44,0x24,0x2B,0x01,
                    0xC6,0x44,0x24,0x2C,0x00,0xC6,0x44,0x24,0x2D,0xB8,0xE8,0x51,0xFF,0xFF,0xFF,0x41,
                    0xB8,0x0E,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x20,0x48,0x8B,0xC8,0xE8,0x1E,0xF8,
                    0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0x77,0xF4,0xFF,0xFF,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,
                    0x44,0x24,0x20,0x83,0xB8,0xA0,0x01,0x00,0x00,0x00,0x74,0x27,0x48,0xB8,0x0C,0x0B,
                    0x18,0x41,0x01,0x00,0x00,0x00,0x48,0x8B,0x4C,0x24,0x20,0x0F,0xB6,0x89,0xA0,0x01,
                    0x00,0x00,0x88,0x08,0x48,0x8B,0x44,0x24,0x20,0xC7,0x80,0xA0,0x01,0x00,0x00,0x00,
                    0x00,0x00,0x00,0xE8,0x48,0xFF,0xFF,0xFF,0xE8,0xE3,0xFE,0xFF,0xFF,0xFF,0xD0,0x48,
                    0x89,0x44,0x24,0x28,0xE8,0xF7,0xFE,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x20,0x83,0xB8,
                    0xA4,0x01,0x00,0x00,0x00,0x7C,0x3D,0x48,0xB8,0x8C,0xD5,0x17,0x41,0x01,0x00,0x00,
                    0x00,0x48,0x8B,0x4C,0x24,0x20,0x8B,0x89,0xA4,0x01,0x00,0x00,0x89,0x08,0x48,0xB8,
                    0x1C,0xE3,0x17,0x41,0x01,0x00,0x00,0x00,0x48,0x8B,0x4C,0x24,0x20,0x8B,0x89,0xA4,
                    0x01,0x00,0x00,0x89,0x08,0x48,0x8B,0x44,0x24,0x20,0xC7,0x80,0xA4,0x01,0x00,0x00,
                    0xFF,0xFF,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0xB8,0xD0,0x12,0x10,0x40,0x01,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0x97,0xF3,0xFF,0xFF,0x48,0x89,0x44,0x24,0x20,0xE8,0xCD,
                    0xFF,0xFF,0xFF,0x48,0x8B,0x4C,0x24,0x20,0x48,0x8B,0x91,0x20,0x01,0x00,0x00,0x48,
                    0x8B,0xC8,0xE8,0x69,0xF6,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xC6,0x44,0x24,0x20,0x40,0xC6,0x44,0x24,0x21,0x53,0xC6,0x44,
                    0x24,0x22,0x48,0xC6,0x44,0x24,0x23,0x83,0xC6,0x44,0x24,0x24,0xEC,0xC6,0x44,0x24,
                    0x25,0x30,0xC6,0x44,0x24,0x26,0x0F,0xC6,0x44,0x24,0x27,0xB7,0xC6,0x44,0x24,0x28,
                    0x0D,0xC6,0x44,0x24,0x29,0xE3,0xC6,0x44,0x24,0x2A,0x6C,0xC6,0x44,0x24,0x2B,0xFD,
                    0xC6,0x44,0x24,0x2C,0x00,0xC6,0x44,0x24,0x2D,0x41,0xE8,0x51,0xFF,0xFF,0xFF,0x41,
                    0xB8,0x0E,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x20,0x48,0x8B,0xC8,0xE8,0x8E,0xF6,
                    0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0xB8,0xB0,0x1D,0x88,0x40,0x01,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xE8,0xC7,0xF2,0xFF,0xFF,0x48,0x89,0x44,0x24,0x20,0xE8,0xCD,
                    0xFF,0xFF,0xFF,0x48,0x8B,0x4C,0x24,0x20,0x48,0x8B,0x91,0x88,0x01,0x00,0x00,0x48,
                    0x8B,0xC8,0xE8,0x99,0xF5,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x83,0xEC,0x38,0xC6,0x44,0x24,0x20,0x48,0xC6,0x44,0x24,0x21,0x89,0xC6,0x44,
                    0x24,0x22,0x5C,0xC6,0x44,0x24,0x23,0x24,0xC6,0x44,0x24,0x24,0x08,0xC6,0x44,0x24,
                    0x25,0x48,0xC6,0x44,0x24,0x26,0x89,0xC6,0x44,0x24,0x27,0x6C,0xC6,0x44,0x24,0x28,
                    0x24,0xC6,0x44,0x24,0x29,0x10,0xC6,0x44,0x24,0x2A,0x48,0xC6,0x44,0x24,0x2B,0x89,
                    0xC6,0x44,0x24,0x2C,0x74,0xC6,0x44,0x24,0x2D,0x24,0xE8,0x51,0xFF,0xFF,0xFF,0x41,
                    0xB8,0x0E,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x20,0x48,0x8B,0xC8,0xE8,0xBE,0xF5,
                    0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0xB8,0x70,0x4C,0x0D,0x41,0x01,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0xF3,0x0F,0x11,0x54,0x24,0x18,0x48,0x89,0x54,0x24,0x10,0x48,0x89,0x4C,0x24,0x08,
                    0x48,0x83,0xEC,0x28,0xE8,0x27,0xFE,0xFF,0xFF,0xF3,0x0F,0x10,0x54,0x24,0x40,0x48,
                    0x8B,0x54,0x24,0x38,0x48,0x8B,0x4C,0x24,0x30,0xFF,0xD0,0x48,0x83,0xC4,0x28,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x81,0xEC,0x98,0x00,0x00,0x00,0xE8,0xAF,0xF1,0xFF,
                    0xFF,0x48,0x89,0x44,0x24,0x50,0x48,0xB8,0xC0,0x7F,0x0D,0x41,0x01,0x00,0x00,0x00,
                    0x48,0x89,0x44,0x24,0x30,0x48,0xB8,0xC8,0x7F,0x0D,0x41,0x01,0x00,0x00,0x00,0x48,
                    0x89,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0xB8,0xF8,0x0B,0x18,0x41,0x01,0x00,0x00,
                    0x00,0x48,0x89,0x44,0x24,0x68,0x48,0xB8,0xC8,0x87,0x0D,0x41,0x01,0x00,0x00,0x00,
                    0x48,0x89,0x44,0x24,0x40,0x48,0xB8,0xCC,0x87,0x0D,0x41,0x01,0x00,0x00,0x00,0x48,
                    0x89,0x44,0x24,0x48,0x48,0xB8,0xD0,0x87,0x0D,0x41,0x01,0x00,0x00,0x00,0x48,0x89,
                    0x44,0x24,0x58,0xE8,0x28,0xFF,0xFF,0xFF,0x48,0x89,0x44,0x24,0x70,0x48,0x8B,0x44,
                    0x24,0x50,0x48,0x83,0x78,0x20,0x00,0x74,0x14,0x48,0x8B,0x44,0x24,0x50,0x48,0x83,
                    0x78,0x28,0x00,0x74,0x08,0x48,0x83,0x7C,0x24,0x70,0x00,0x75,0x05,0xE9,0xF2,0x02,
                    0x00,0x00,0x48,0x8B,0x4C,0x24,0x70,0x48,0x8B,0x44,0x24,0x50,0xFF,0x50,0x20,0x48,
                    0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x38,0x00,0x74,0x32,0x48,0x8B,0x84,0x24,
                    0xA0,0x00,0x00,0x00,0x83,0x78,0x14,0x04,0x74,0x24,0x48,0x8B,0x44,0x24,0x48,0x48,
                    0x8B,0x8C,0x24,0xA0,0x00,0x00,0x00,0x8B,0x49,0x04,0x89,0x08,0x48,0x8B,0x44,0x24,
                    0x58,0x48,0x8B,0x8C,0x24,0xA0,0x00,0x00,0x00,0x8B,0x49,0x08,0x89,0x08,0x48,0x8B,
                    0x44,0x24,0x68,0x8B,0x00,0x89,0x44,0x24,0x7C,0x48,0x8B,0x44,0x24,0x40,0x8B,0x00,
                    0x89,0x44,0x24,0x20,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x14,0x01,
                    0x75,0x2F,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8B,0x40,0x0C,0x48,0x63,
                    0x4C,0x24,0x20,0x48,0x8B,0x94,0x24,0x80,0x00,0x00,0x00,0x48,0x89,0x04,0xCA,0x8B,
                    0x44,0x24,0x20,0xFF,0xC0,0x48,0x8B,0x4C,0x24,0x40,0x89,0x01,0xE9,0x46,0x02,0x00,
                    0x00,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x14,0x02,0x75,0x19,0x48,
                    0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8B,0x40,0x0C,0x48,0x8B,0x4C,0x24,0x30,
                    0x48,0x89,0x01,0xE9,0x1F,0x02,0x00,0x00,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,
                    0x83,0x78,0x14,0x03,0x0F,0x85,0xA5,0x00,0x00,0x00,0x48,0x8B,0x84,0x24,0xA0,0x00,
                    0x00,0x00,0x8B,0x40,0x18,0x89,0x44,0x24,0x28,0x83,0x7C,0x24,0x20,0x00,0x75,0x0F,
                    0x83,0x7C,0x24,0x7C,0x00,0x75,0x08,0xC7,0x44,0x24,0x28,0x01,0x00,0x00,0x00,0x8B,
                    0x44,0x24,0x20,0x39,0x44,0x24,0x28,0x7E,0x0A,0x8B,0x44,0x24,0x20,0xFF,0xC0,0x89,
                    0x44,0x24,0x28,0x8B,0x44,0x24,0x20,0x89,0x44,0x24,0x24,0xEB,0x0A,0x8B,0x44,0x24,
                    0x24,0xFF,0xC8,0x89,0x44,0x24,0x24,0x8B,0x44,0x24,0x28,0x39,0x44,0x24,0x24,0x7C,
                    0x22,0x48,0x63,0x44,0x24,0x24,0x48,0x8B,0x4C,0x24,0x30,0x48,0x8B,0x04,0xC1,0x8B,
                    0x4C,0x24,0x24,0xFF,0xC1,0x48,0x63,0xC9,0x48,0x8B,0x54,0x24,0x30,0x48,0x89,0x04,
                    0xCA,0xEB,0xCA,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8B,0x40,0x0C,0x48,
                    0x63,0x4C,0x24,0x28,0x48,0x8B,0x54,0x24,0x30,0x48,0x89,0x04,0xCA,0x8B,0x44,0x24,
                    0x20,0xFF,0xC0,0x48,0x8B,0x4C,0x24,0x40,0x89,0x01,0xE9,0x68,0x01,0x00,0x00,0x48,
                    0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x14,0x04,0x0F,0x85,0xD8,0x00,0x00,
                    0x00,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x18,0x00,0x0F,0x8E,0xC6,
                    0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x30,0x48,0x8B,0x00,0x48,0x89,0x84,0x24,0x88,
                    0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x48,0x8B,0x00,0x89,0x44,0x24,0x60,0x48,0x8B,
                    0x44,0x24,0x58,0x8B,0x00,0x89,0x44,0x24,0x78,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,
                    0x00,0x48,0x8B,0x40,0x0C,0x48,0x8B,0x4C,0x24,0x30,0x48,0x89,0x01,0xC7,0x44,0x24,
                    0x38,0x00,0x00,0x00,0x00,0xEB,0x0A,0x8B,0x44,0x24,0x38,0xFF,0xC0,0x89,0x44,0x24,
                    0x38,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x8B,0x40,0x18,0x39,0x44,0x24,0x38,
                    0x7D,0x3F,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x38,0x00,0x74,0x24,0x48,
                    0x8B,0x44,0x24,0x48,0x48,0x8B,0x8C,0x24,0xA0,0x00,0x00,0x00,0x8B,0x49,0x04,0x89,
                    0x08,0x48,0x8B,0x44,0x24,0x58,0x48,0x8B,0x8C,0x24,0xA0,0x00,0x00,0x00,0x8B,0x49,
                    0x08,0x89,0x08,0x0F,0x57,0xD2,0x33,0xD2,0x33,0xC9,0xE8,0xE1,0xFC,0xFF,0xFF,0xEB,
                    0xA6,0x48,0x8B,0x44,0x24,0x30,0x48,0x8B,0x8C,0x24,0x88,0x00,0x00,0x00,0x48,0x89,
                    0x08,0x48,0x8B,0x44,0x24,0x48,0x8B,0x4C,0x24,0x60,0x89,0x08,0x48,0x8B,0x44,0x24,
                    0x58,0x8B,0x4C,0x24,0x78,0x89,0x08,0xEB,0x7E,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,
                    0x00,0x83,0x78,0x14,0x05,0x75,0x0D,0x48,0x8B,0x44,0x24,0x68,0xC7,0x00,0x00,0x00,
                    0x00,0x00,0xEB,0x63,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x14,0x06,
                    0x75,0x0D,0x48,0x8B,0x44,0x24,0x40,0xC7,0x00,0x00,0x00,0x00,0x00,0xEB,0x48,0x48,
                    0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x14,0x07,0x75,0x18,0x48,0x8B,0x44,
                    0x24,0x68,0xC7,0x00,0x00,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x40,0xC7,0x00,0x00,
                    0x00,0x00,0x00,0xEB,0x22,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x83,0x78,0x14,
                    0x08,0x75,0x14,0xE8,0xA8,0xFA,0xFF,0xFF,0xE8,0x73,0xFB,0xFF,0xFF,0xE8,0x0E,0xF9,
                    0xFF,0xFF,0xE8,0x39,0xF7,0xFF,0xFF,0x48,0x8B,0x4C,0x24,0x70,0x48,0x8B,0x44,0x24,
                    0x50,0xFF,0x50,0x28,0x48,0x81,0xC4,0x98,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x54,0x24,0x10,0x48,0x89,0x4C,0x24,0x08,0x48,0x83,0xEC,0x48,0x48,0xB8,
                    0xC0,0x7F,0x0D,0x41,0x01,0x00,0x00,0x00,0x48,0x89,0x44,0x24,0x28,0x48,0xB8,0xF8,
                    0x0B,0x18,0x41,0x01,0x00,0x00,0x00,0x48,0x89,0x44,0x24,0x38,0xE8,0xDF,0xED,0xFF,
                    0xFF,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0x44,0x24,0x28,0x0F,0xB7,0x00,0x25,0xFF,
                    0x0F,0x00,0x00,0x66,0x89,0x44,0x24,0x20,0x0F,0xB7,0x44,0x24,0x20,0x83,0xF8,0x70,
                    0x7D,0x23,0x0F,0xB7,0x44,0x24,0x20,0x48,0x8B,0x4C,0x24,0x30,0x0F,0xB6,0x84,0x01,
                    0xAC,0x00,0x00,0x00,0x85,0xC0,0x74,0x0D,0x48,0x8B,0x44,0x24,0x38,0xC7,0x00,0x00,
                    0x00,0x00,0x00,0xEB,0x1B,0xE8,0x36,0xFA,0xFF,0xFF,0xE8,0xD1,0xF9,0xFF,0xFF,0x48,
                    0x8B,0x54,0x24,0x58,0x48,0x8B,0x4C,0x24,0x50,0xFF,0xD0,0xE8,0xE0,0xF9,0xFF,0xFF,
                    0x48,0x83,0xC4,0x48,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x44,0x89,0x4C,0x24,0x20,0x44,0x89,0x44,0x24,0x18,0x89,0x54,0x24,0x10,0x89,0x4C,
                    0x24,0x08,0x48,0x83,0xEC,0x48,0xE8,0x55,0xED,0xFF,0xFF,0x48,0x89,0x44,0x24,0x30,
                    0x48,0x8B,0x44,0x24,0x30,0x8B,0x4C,0x24,0x50,0x89,0x88,0x90,0x01,0x00,0x00,0x83,
                    0x7C,0x24,0x50,0x5A,0x7D,0x1C,0x48,0x63,0x44,0x24,0x50,0x48,0x8B,0x4C,0x24,0x30,
                    0x0F,0xB6,0x84,0x01,0x28,0x01,0x00,0x00,0x85,0xC0,0x74,0x06,0x33,0xC0,0xEB,0x3B,
                    0xEB,0x39,0xE8,0x89,0xFA,0xFF,0xFF,0xE8,0x24,0xFA,0xFF,0xFF,0xF3,0x0F,0x10,0x44,
                    0x24,0x70,0xF3,0x0F,0x11,0x44,0x24,0x20,0x44,0x8B,0x4C,0x24,0x68,0x44,0x8B,0x44,
                    0x24,0x60,0x8B,0x54,0x24,0x58,0x8B,0x4C,0x24,0x50,0xFF,0xD0,0x48,0x89,0x44,0x24,
                    0x38,0xE8,0x1A,0xFA,0xFF,0xFF,0x48,0x8B,0x44,0x24,0x38,0x48,0x83,0xC4,0x48,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x56,0x57,0x48,0x81,0xEC,0x88,0x00,0x00,0x00,0xE8,0xBD,
                    0xEC,0xFF,0xFF,0x48,0x89,0x44,0x24,0x30,0x48,0x8D,0x44,0x24,0x40,0x48,0x8B,0x4C,
                    0x24,0x30,0x48,0x8B,0xF8,0x48,0x8D,0x71,0x58,0xB9,0x40,0x00,0x00,0x00,0xF3,0xA4,
                    0x48,0x8D,0x4C,0x24,0x28,0x48,0x8B,0x44,0x24,0x30,0xFF,0x50,0x38,0x89,0x44,0x24,
                    0x20,0x48,0x8B,0x44,0x24,0x40,0x48,0x8B,0x4C,0x24,0x28,0x48,0x2B,0xC8,0x48,0x8B,
                    0xC1,0xF2,0x48,0x0F,0x2A,0xC0,0xF2,0x0F,0x59,0x44,0x24,0x70,0xF2,0x48,0x0F,0x2A,
                    0x4C,0x24,0x58,0xF2,0x0F,0x58,0xC1,0xF2,0x48,0x0F,0x2C,0xC0,0x48,0x89,0x44,0x24,
                    0x28,0x48,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x48,0x8B,0x4C,0x24,0x28,0x48,0x89,
                    0x08,0x8B,0x44,0x24,0x20,0x48,0x81,0xC4,0x88,0x00,0x00,0x00,0x5F,0x5E,0xC3,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x40,0x56,0x57,0x48,0x83,0xEC,0x78,0xE8,0x24,0xEC,0xFF,0xFF,0x48,0x89,0x44,0x24,
                    0x28,0x48,0x8D,0x44,0x24,0x30,0x48,0x8B,0x4C,0x24,0x28,0x48,0x8B,0xF8,0x48,0x8D,
                    0x71,0x58,0xB9,0x40,0x00,0x00,0x00,0xF3,0xA4,0x48,0x8B,0x44,0x24,0x28,0xFF,0x50,
                    0x40,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x38,0x48,0x8B,0x4C,0x24,0x20,
                    0x48,0x2B,0xC8,0x48,0x8B,0xC1,0xF2,0x48,0x0F,0x2A,0xC0,0x48,0x85,0xC0,0x7D,0x08,
                    0xF2,0x0F,0x58,0x05,0x00,0x00,0x00,0x00,0xF2,0x0F,0x59,0x44,0x24,0x60,0x48,0x8B,
                    0x44,0x24,0x50,0xF2,0x48,0x0F,0x2A,0xC8,0x48,0x85,0xC0,0x7D,0x08,0xF2,0x0F,0x58,
                    0x0D,0x00,0x00,0x00,0x00,0xF2,0x0F,0x58,0xC1,0x33,0xC0,0x66,0x0F,0x2F,0x05,0x00,
                    0x00,0x00,0x00,0x72,0x1F,0xF2,0x0F,0x5C,0x05,0x00,0x00,0x00,0x00,0x66,0x0F,0x2F,
                    0x05,0x00,0x00,0x00,0x00,0x73,0x0D,0x48,0xB9,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
                    0x80,0x48,0x03,0xC1,0xF2,0x48,0x0F,0x2C,0xC8,0x48,0x03,0xC8,0x48,0x8B,0xC1,0x48,
                    0x89,0x44,0x24,0x20,0x48,0x8B,0x44,0x24,0x20,0x48,0x83,0xC4,0x78,0x5F,0x5E,0xC3,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x40,0x56,0x57,0x48,0x83,0xEC,0x78,0xE8,0x54,0xEB,0xFF,0xFF,0x48,0x89,0x44,0x24,
                    0x28,0x48,0x8D,0x44,0x24,0x30,0x48,0x8B,0x4C,0x24,0x28,0x48,0x8B,0xF8,0x48,0x8D,
                    0x71,0x58,0xB9,0x40,0x00,0x00,0x00,0xF3,0xA4,0x48,0x8B,0x44,0x24,0x28,0xFF,0x50,
                    0x48,0x89,0x44,0x24,0x20,0x8B,0x44,0x24,0x40,0x8B,0x4C,0x24,0x20,0x2B,0xC8,0x8B,
                    0xC1,0xF2,0x0F,0x2A,0xC0,0xF2,0x0F,0x59,0x44,0x24,0x60,0xF2,0x0F,0x2A,0x4C,0x24,
                    0x58,0xF2,0x0F,0x58,0xC1,0xF2,0x0F,0x2C,0xC0,0x89,0x44,0x24,0x20,0x8B,0x44,0x24,
                    0x20,0x48,0x83,0xC4,0x78,0x5F,0x5E,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x40,0x56,0x57,0x48,0x83,0xEC,0x78,0xE8,0xE4,0xEA,0xFF,0xFF,0x48,0x89,0x44,0x24,
                    0x28,0x48,0x8D,0x44,0x24,0x30,0x48,0x8B,0x4C,0x24,0x28,0x48,0x8B,0xF8,0x48,0x8D,
                    0x71,0x58,0xB9,0x40,0x00,0x00,0x00,0xF3,0xA4,0x48,0x8B,0x44,0x24,0x28,0xFF,0x50,
                    0x50,0x89,0x44,0x24,0x20,0x8B,0x44,0x24,0x44,0x8B,0x4C,0x24,0x20,0x2B,0xC8,0x8B,
                    0xC1,0x8B,0xC0,0xF2,0x48,0x0F,0x2A,0xC0,0xF2,0x0F,0x59,0x44,0x24,0x60,0x8B,0x44,
                    0x24,0x5C,0xF2,0x48,0x0F,0x2A,0xC8,0xF2,0x0F,0x58,0xC1,0xF2,0x48,0x0F,0x2C,0xC0,
                    0x89,0x44,0x24,0x20,0x8B,0x44,0x24,0x20,0x48,0x83,0xC4,0x78,0x5F,0x5E,0xC3,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x56,0x57,0x48,0x83,0xEC,0x28,0xE8,0x60,0xEA,0xFF,0xFF,
                    0x48,0x8D,0x78,0x58,0x48,0x8B,0x74,0x24,0x40,0xB9,0x40,0x00,0x00,0x00,0xF3,0xA4,
                    0x48,0x83,0xC4,0x28,0x5F,0x5E,0xC3,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC7,0x00,0x28,0x00,0x00,0x00,
                    0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x04,0x78,0x78,0x00,0x00,0x48,0x8B,0x44,0x24,
                    0x08,0xC7,0x40,0x08,0x10,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x0C,
                    0x40,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x10,0x10,0x00,0x00,0x00,
                    0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x14,0x08,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,
                    0x08,0xC7,0x40,0x18,0x08,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x1C,
                    0x1C,0x00,0x00,0x00,0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x20,0x48,0x9C,0x00,0x00,
                    0x48,0x8B,0x44,0x24,0x08,0xC7,0x40,0x24,0x14,0x00,0x00,0x00,0xC3,0xCC,0xCC,0xCC,
                    0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,0xCC,
                    0x48,0x89,0x4C,0x24,0x08,0x33,0xC0,0xC3
                };
            }
        }
    }
}