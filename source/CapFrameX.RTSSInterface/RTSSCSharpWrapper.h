#pragma once
#include "RTSSCoreControl.h"

#pragma managed
using namespace System;
using namespace System::Threading;
using namespace System::Threading::Tasks;
using namespace System::Collections::Generic;

public ref class RTSSCSharpWrapper
{
public:
  RTSSCSharpWrapper()
  {
    _coreControl = new RTSSCoreControl();
  }

  ~RTSSCSharpWrapper()
  {
    _coreControl->ReleaseOSD();
    delete _coreControl;
  }

  void Refresh()
  {
    _coreControl->Refresh();
  }

  void ReleaseOSD()
  {
    _coreControl->ReleaseOSD();
  }

  void SetShowCaptureTimer(bool showTimer)
  {
    _coreControl->ShowCaptureTimer = showTimer;
  }

  void SetCaptureTimerValue(UINT captureTimerValue)
  {
    _coreControl->CaptureTimerValue = captureTimerValue;
  }

private:
  RTSSCoreControl* _coreControl;
};
