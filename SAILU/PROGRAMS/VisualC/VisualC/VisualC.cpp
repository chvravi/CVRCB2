// VisualC.cpp : Implementation of WinMain


#include "stdafx.h"
#include "resource.h"
#include "VisualC_i.h"



class CVisualCModule : public ATL::CAtlExeModuleT< CVisualCModule >
	{
public :
	DECLARE_LIBID(LIBID_VisualCLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_VISUALC, "{FF86DCB5-98B0-4986-A317-C8FE0E36BF72}")
	};

CVisualCModule _AtlModule;



//
extern "C" int WINAPI _tWinMain(HINSTANCE /*hInstance*/, HINSTANCE /*hPrevInstance*/, 
								LPTSTR /*lpCmdLine*/, int nShowCmd)
{
	return _AtlModule.WinMain(nShowCmd);
}

