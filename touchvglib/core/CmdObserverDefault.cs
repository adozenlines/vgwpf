/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class CmdObserverDefault : CmdObserver {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CmdObserverDefault(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.CmdObserverDefault_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CmdObserverDefault obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CmdObserverDefault() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_CmdObserverDefault(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CmdObserverDefault() : this(touchvgPINVOKE.new_CmdObserverDefault(), true) {
    SwigDirectorConnect();
  }

  public override void onDocLoaded(MgMotion sender, bool forUndo) {
    if (SwigDerivedClassHasMethod("onDocLoaded", swigMethodTypes0)) touchvgPINVOKE.CmdObserverDefault_onDocLoadedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), forUndo); else touchvgPINVOKE.CmdObserverDefault_onDocLoaded(swigCPtr, MgMotion.getCPtr(sender), forUndo);
  }

  public override void onEnterSelectCommand(MgMotion sender) {
    if (SwigDerivedClassHasMethod("onEnterSelectCommand", swigMethodTypes1)) touchvgPINVOKE.CmdObserverDefault_onEnterSelectCommandSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender)); else touchvgPINVOKE.CmdObserverDefault_onEnterSelectCommand(swigCPtr, MgMotion.getCPtr(sender));
  }

  public override void onUnloadCommands(MgCmdManager sender) {
    if (SwigDerivedClassHasMethod("onUnloadCommands", swigMethodTypes2)) touchvgPINVOKE.CmdObserverDefault_onUnloadCommandsSwigExplicitCmdObserverDefault(swigCPtr, MgCmdManager.getCPtr(sender)); else touchvgPINVOKE.CmdObserverDefault_onUnloadCommands(swigCPtr, MgCmdManager.getCPtr(sender));
  }

  public override bool selectActionsNeedHided(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("selectActionsNeedHided", swigMethodTypes3) ? touchvgPINVOKE.CmdObserverDefault_selectActionsNeedHidedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.CmdObserverDefault_selectActionsNeedHided(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool doAction(MgMotion sender, int action) {
    bool ret = (SwigDerivedClassHasMethod("doAction", swigMethodTypes5) ? touchvgPINVOKE.CmdObserverDefault_doActionSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), action) : touchvgPINVOKE.CmdObserverDefault_doAction(swigCPtr, MgMotion.getCPtr(sender), action));
    return ret;
  }

  public override bool doEndAction(MgMotion sender, int action) {
    bool ret = (SwigDerivedClassHasMethod("doEndAction", swigMethodTypes6) ? touchvgPINVOKE.CmdObserverDefault_doEndActionSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), action) : touchvgPINVOKE.CmdObserverDefault_doEndAction(swigCPtr, MgMotion.getCPtr(sender), action));
    return ret;
  }

  public override void drawInShapeCommand(MgMotion sender, MgCommand cmd, GiGraphics gs) {
    if (SwigDerivedClassHasMethod("drawInShapeCommand", swigMethodTypes7)) touchvgPINVOKE.CmdObserverDefault_drawInShapeCommandSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgCommand.getCPtr(cmd), GiGraphics.getCPtr(gs)); else touchvgPINVOKE.CmdObserverDefault_drawInShapeCommand(swigCPtr, MgMotion.getCPtr(sender), MgCommand.getCPtr(cmd), GiGraphics.getCPtr(gs));
  }

  public override void drawInSelectCommand(MgMotion sender, MgShape sp, int handleIndex, GiGraphics gs) {
    if (SwigDerivedClassHasMethod("drawInSelectCommand", swigMethodTypes8)) touchvgPINVOKE.CmdObserverDefault_drawInSelectCommandSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), handleIndex, GiGraphics.getCPtr(gs)); else touchvgPINVOKE.CmdObserverDefault_drawInSelectCommand(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), handleIndex, GiGraphics.getCPtr(gs));
  }

  public override void onSelectionChanged(MgMotion sender) {
    if (SwigDerivedClassHasMethod("onSelectionChanged", swigMethodTypes9)) touchvgPINVOKE.CmdObserverDefault_onSelectionChangedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender)); else touchvgPINVOKE.CmdObserverDefault_onSelectionChanged(swigCPtr, MgMotion.getCPtr(sender));
  }

  public override bool onShapeWillAdded(MgMotion sender, MgShape sp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeWillAdded", swigMethodTypes10) ? touchvgPINVOKE.CmdObserverDefault_onShapeWillAddedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeWillAdded(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override void onShapeAdded(MgMotion sender, MgShape sp) {
    if (SwigDerivedClassHasMethod("onShapeAdded", swigMethodTypes11)) touchvgPINVOKE.CmdObserverDefault_onShapeAddedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)); else touchvgPINVOKE.CmdObserverDefault_onShapeAdded(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
  }

  public override bool onShapeWillDeleted(MgMotion sender, MgShape sp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeWillDeleted", swigMethodTypes12) ? touchvgPINVOKE.CmdObserverDefault_onShapeWillDeletedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeWillDeleted(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override int onShapeDeleted(MgMotion sender, MgShape sp) {
    int ret = (SwigDerivedClassHasMethod("onShapeDeleted", swigMethodTypes13) ? touchvgPINVOKE.CmdObserverDefault_onShapeDeletedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeDeleted(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override bool onShapeCanRotated(MgMotion sender, MgShape sp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeCanRotated", swigMethodTypes14) ? touchvgPINVOKE.CmdObserverDefault_onShapeCanRotatedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeCanRotated(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override bool onShapeCanTransform(MgMotion sender, MgShape sp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeCanTransform", swigMethodTypes15) ? touchvgPINVOKE.CmdObserverDefault_onShapeCanTransformSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeCanTransform(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override bool onShapeCanUnlock(MgMotion sender, MgShape sp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeCanUnlock", swigMethodTypes16) ? touchvgPINVOKE.CmdObserverDefault_onShapeCanUnlockSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeCanUnlock(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override bool onShapeCanUngroup(MgMotion sender, MgShape sp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeCanUngroup", swigMethodTypes17) ? touchvgPINVOKE.CmdObserverDefault_onShapeCanUngroupSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_onShapeCanUngroup(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)));
    return ret;
  }

  public override bool onShapeCanMovedHandle(MgMotion sender, MgShape sp, int index) {
    bool ret = (SwigDerivedClassHasMethod("onShapeCanMovedHandle", swigMethodTypes18) ? touchvgPINVOKE.CmdObserverDefault_onShapeCanMovedHandleSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), index) : touchvgPINVOKE.CmdObserverDefault_onShapeCanMovedHandle(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), index));
    return ret;
  }

  public override void onShapeMoved(MgMotion sender, MgShape sp, int segment) {
    if (SwigDerivedClassHasMethod("onShapeMoved", swigMethodTypes19)) touchvgPINVOKE.CmdObserverDefault_onShapeMovedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), segment); else touchvgPINVOKE.CmdObserverDefault_onShapeMoved(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), segment);
  }

  public override bool onShapeWillChanged(MgMotion sender, MgShape sp, MgShape oldsp) {
    bool ret = (SwigDerivedClassHasMethod("onShapeWillChanged", swigMethodTypes20) ? touchvgPINVOKE.CmdObserverDefault_onShapeWillChangedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), MgShape.getCPtr(oldsp)) : touchvgPINVOKE.CmdObserverDefault_onShapeWillChanged(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), MgShape.getCPtr(oldsp)));
    return ret;
  }

  public override void onShapeChanged(MgMotion sender, MgShape shape) {
    if (SwigDerivedClassHasMethod("onShapeChanged", swigMethodTypes21)) touchvgPINVOKE.CmdObserverDefault_onShapeChangedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(shape)); else touchvgPINVOKE.CmdObserverDefault_onShapeChanged(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(shape));
  }

  public override MgBaseShape createShape(MgMotion sender, int type) {
    global::System.IntPtr cPtr = (SwigDerivedClassHasMethod("createShape", swigMethodTypes22) ? touchvgPINVOKE.CmdObserverDefault_createShapeSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), type) : touchvgPINVOKE.CmdObserverDefault_createShape(swigCPtr, MgMotion.getCPtr(sender), type));
    MgBaseShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgBaseShape(cPtr, false);
    return ret;
  }

  public override MgCommand createCommand(MgMotion sender, string name) {
    global::System.IntPtr cPtr = (SwigDerivedClassHasMethod("createCommand", swigMethodTypes23) ? touchvgPINVOKE.CmdObserverDefault_createCommandSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), name) : touchvgPINVOKE.CmdObserverDefault_createCommand(swigCPtr, MgMotion.getCPtr(sender), name));
    MgCommand ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

  public override int addShapeActions(MgMotion sender, Ints actions, int n, MgShape sp) {
    int ret = (SwigDerivedClassHasMethod("addShapeActions", swigMethodTypes4) ? touchvgPINVOKE.CmdObserverDefault_addShapeActionsSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), Ints.getCPtr(actions), n, MgShape.getCPtr(sp)) : touchvgPINVOKE.CmdObserverDefault_addShapeActions(swigCPtr, MgMotion.getCPtr(sender), Ints.getCPtr(actions), n, MgShape.getCPtr(sp)));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool onPreGesture(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("onPreGesture", swigMethodTypes24) ? touchvgPINVOKE.CmdObserverDefault_onPreGestureSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.CmdObserverDefault_onPreGesture(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override void onPostGesture(MgMotion sender) {
    if (SwigDerivedClassHasMethod("onPostGesture", swigMethodTypes25)) touchvgPINVOKE.CmdObserverDefault_onPostGestureSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender)); else touchvgPINVOKE.CmdObserverDefault_onPostGesture(swigCPtr, MgMotion.getCPtr(sender));
  }

  public override void onPointSnapped(MgMotion sender, MgShape sp) {
    if (SwigDerivedClassHasMethod("onPointSnapped", swigMethodTypes26)) touchvgPINVOKE.CmdObserverDefault_onPointSnappedSwigExplicitCmdObserverDefault(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp)); else touchvgPINVOKE.CmdObserverDefault_onPointSnapped(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onDocLoaded", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateCmdObserverDefault_0(SwigDirectoronDocLoaded);
    if (SwigDerivedClassHasMethod("onEnterSelectCommand", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateCmdObserverDefault_1(SwigDirectoronEnterSelectCommand);
    if (SwigDerivedClassHasMethod("onUnloadCommands", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateCmdObserverDefault_2(SwigDirectoronUnloadCommands);
    if (SwigDerivedClassHasMethod("selectActionsNeedHided", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateCmdObserverDefault_3(SwigDirectorselectActionsNeedHided);
    if (SwigDerivedClassHasMethod("addShapeActions", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateCmdObserverDefault_4(SwigDirectoraddShapeActions);
    if (SwigDerivedClassHasMethod("doAction", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateCmdObserverDefault_5(SwigDirectordoAction);
    if (SwigDerivedClassHasMethod("doEndAction", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateCmdObserverDefault_6(SwigDirectordoEndAction);
    if (SwigDerivedClassHasMethod("drawInShapeCommand", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateCmdObserverDefault_7(SwigDirectordrawInShapeCommand);
    if (SwigDerivedClassHasMethod("drawInSelectCommand", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateCmdObserverDefault_8(SwigDirectordrawInSelectCommand);
    if (SwigDerivedClassHasMethod("onSelectionChanged", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateCmdObserverDefault_9(SwigDirectoronSelectionChanged);
    if (SwigDerivedClassHasMethod("onShapeWillAdded", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateCmdObserverDefault_10(SwigDirectoronShapeWillAdded);
    if (SwigDerivedClassHasMethod("onShapeAdded", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateCmdObserverDefault_11(SwigDirectoronShapeAdded);
    if (SwigDerivedClassHasMethod("onShapeWillDeleted", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateCmdObserverDefault_12(SwigDirectoronShapeWillDeleted);
    if (SwigDerivedClassHasMethod("onShapeDeleted", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateCmdObserverDefault_13(SwigDirectoronShapeDeleted);
    if (SwigDerivedClassHasMethod("onShapeCanRotated", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateCmdObserverDefault_14(SwigDirectoronShapeCanRotated);
    if (SwigDerivedClassHasMethod("onShapeCanTransform", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateCmdObserverDefault_15(SwigDirectoronShapeCanTransform);
    if (SwigDerivedClassHasMethod("onShapeCanUnlock", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateCmdObserverDefault_16(SwigDirectoronShapeCanUnlock);
    if (SwigDerivedClassHasMethod("onShapeCanUngroup", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateCmdObserverDefault_17(SwigDirectoronShapeCanUngroup);
    if (SwigDerivedClassHasMethod("onShapeCanMovedHandle", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateCmdObserverDefault_18(SwigDirectoronShapeCanMovedHandle);
    if (SwigDerivedClassHasMethod("onShapeMoved", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateCmdObserverDefault_19(SwigDirectoronShapeMoved);
    if (SwigDerivedClassHasMethod("onShapeWillChanged", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateCmdObserverDefault_20(SwigDirectoronShapeWillChanged);
    if (SwigDerivedClassHasMethod("onShapeChanged", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateCmdObserverDefault_21(SwigDirectoronShapeChanged);
    if (SwigDerivedClassHasMethod("createShape", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateCmdObserverDefault_22(SwigDirectorcreateShape);
    if (SwigDerivedClassHasMethod("createCommand", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateCmdObserverDefault_23(SwigDirectorcreateCommand);
    if (SwigDerivedClassHasMethod("onPreGesture", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateCmdObserverDefault_24(SwigDirectoronPreGesture);
    if (SwigDerivedClassHasMethod("onPostGesture", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateCmdObserverDefault_25(SwigDirectoronPostGesture);
    if (SwigDerivedClassHasMethod("onPointSnapped", swigMethodTypes26))
      swigDelegate26 = new SwigDelegateCmdObserverDefault_26(SwigDirectoronPointSnapped);
    touchvgPINVOKE.CmdObserverDefault_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25, swigDelegate26);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(CmdObserverDefault));
    return hasDerivedMethod;
  }

  private void SwigDirectoronDocLoaded(global::System.IntPtr sender, bool forUndo) {
    onDocLoaded((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), forUndo);
  }

  private void SwigDirectoronEnterSelectCommand(global::System.IntPtr sender) {
    onEnterSelectCommand((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private void SwigDirectoronUnloadCommands(global::System.IntPtr sender) {
    onUnloadCommands((sender == global::System.IntPtr.Zero) ? null : new MgCmdManager(sender, false));
  }

  private bool SwigDirectorselectActionsNeedHided(global::System.IntPtr sender) {
    return selectActionsNeedHided((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private int SwigDirectoraddShapeActions(global::System.IntPtr sender, global::System.IntPtr actions, int n, global::System.IntPtr sp) {
    return addShapeActions((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), new Ints(actions, false), n, (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectordoAction(global::System.IntPtr sender, int action) {
    return doAction((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), action);
  }

  private bool SwigDirectordoEndAction(global::System.IntPtr sender, int action) {
    return doEndAction((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), action);
  }

  private void SwigDirectordrawInShapeCommand(global::System.IntPtr sender, global::System.IntPtr cmd, global::System.IntPtr gs) {
    drawInShapeCommand((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (cmd == global::System.IntPtr.Zero) ? null : new MgCommand(cmd, false), (gs == global::System.IntPtr.Zero) ? null : new GiGraphics(gs, false));
  }

  private void SwigDirectordrawInSelectCommand(global::System.IntPtr sender, global::System.IntPtr sp, int handleIndex, global::System.IntPtr gs) {
    drawInSelectCommand((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false), handleIndex, (gs == global::System.IntPtr.Zero) ? null : new GiGraphics(gs, false));
  }

  private void SwigDirectoronSelectionChanged(global::System.IntPtr sender) {
    onSelectionChanged((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectoronShapeWillAdded(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeWillAdded((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private void SwigDirectoronShapeAdded(global::System.IntPtr sender, global::System.IntPtr sp) {
    onShapeAdded((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectoronShapeWillDeleted(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeWillDeleted((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private int SwigDirectoronShapeDeleted(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeDeleted((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectoronShapeCanRotated(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeCanRotated((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectoronShapeCanTransform(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeCanTransform((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectoronShapeCanUnlock(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeCanUnlock((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectoronShapeCanUngroup(global::System.IntPtr sender, global::System.IntPtr sp) {
    return onShapeCanUngroup((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  private bool SwigDirectoronShapeCanMovedHandle(global::System.IntPtr sender, global::System.IntPtr sp, int index) {
    return onShapeCanMovedHandle((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false), index);
  }

  private void SwigDirectoronShapeMoved(global::System.IntPtr sender, global::System.IntPtr sp, int segment) {
    onShapeMoved((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false), segment);
  }

  private bool SwigDirectoronShapeWillChanged(global::System.IntPtr sender, global::System.IntPtr sp, global::System.IntPtr oldsp) {
    return onShapeWillChanged((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false), (oldsp == global::System.IntPtr.Zero) ? null : new MgShape(oldsp, false));
  }

  private void SwigDirectoronShapeChanged(global::System.IntPtr sender, global::System.IntPtr shape) {
    onShapeChanged((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (shape == global::System.IntPtr.Zero) ? null : new MgShape(shape, false));
  }

  private global::System.IntPtr SwigDirectorcreateShape(global::System.IntPtr sender, int type) {
    return MgBaseShape.getCPtr(createShape((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), type)).Handle;
  }

  private global::System.IntPtr SwigDirectorcreateCommand(global::System.IntPtr sender, string name) {
    return MgCommand.getCPtr(createCommand((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), name)).Handle;
  }

  private bool SwigDirectoronPreGesture(global::System.IntPtr sender) {
    return onPreGesture((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private void SwigDirectoronPostGesture(global::System.IntPtr sender) {
    onPostGesture((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private void SwigDirectoronPointSnapped(global::System.IntPtr sender, global::System.IntPtr sp) {
    onPointSnapped((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (sp == global::System.IntPtr.Zero) ? null : new MgShape(sp, false));
  }

  public delegate void SwigDelegateCmdObserverDefault_0(global::System.IntPtr sender, bool forUndo);
  public delegate void SwigDelegateCmdObserverDefault_1(global::System.IntPtr sender);
  public delegate void SwigDelegateCmdObserverDefault_2(global::System.IntPtr sender);
  public delegate bool SwigDelegateCmdObserverDefault_3(global::System.IntPtr sender);
  public delegate int SwigDelegateCmdObserverDefault_4(global::System.IntPtr sender, global::System.IntPtr actions, int n, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_5(global::System.IntPtr sender, int action);
  public delegate bool SwigDelegateCmdObserverDefault_6(global::System.IntPtr sender, int action);
  public delegate void SwigDelegateCmdObserverDefault_7(global::System.IntPtr sender, global::System.IntPtr cmd, global::System.IntPtr gs);
  public delegate void SwigDelegateCmdObserverDefault_8(global::System.IntPtr sender, global::System.IntPtr sp, int handleIndex, global::System.IntPtr gs);
  public delegate void SwigDelegateCmdObserverDefault_9(global::System.IntPtr sender);
  public delegate bool SwigDelegateCmdObserverDefault_10(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate void SwigDelegateCmdObserverDefault_11(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_12(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate int SwigDelegateCmdObserverDefault_13(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_14(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_15(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_16(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_17(global::System.IntPtr sender, global::System.IntPtr sp);
  public delegate bool SwigDelegateCmdObserverDefault_18(global::System.IntPtr sender, global::System.IntPtr sp, int index);
  public delegate void SwigDelegateCmdObserverDefault_19(global::System.IntPtr sender, global::System.IntPtr sp, int segment);
  public delegate bool SwigDelegateCmdObserverDefault_20(global::System.IntPtr sender, global::System.IntPtr sp, global::System.IntPtr oldsp);
  public delegate void SwigDelegateCmdObserverDefault_21(global::System.IntPtr sender, global::System.IntPtr shape);
  public delegate global::System.IntPtr SwigDelegateCmdObserverDefault_22(global::System.IntPtr sender, int type);
  public delegate global::System.IntPtr SwigDelegateCmdObserverDefault_23(global::System.IntPtr sender, string name);
  public delegate bool SwigDelegateCmdObserverDefault_24(global::System.IntPtr sender);
  public delegate void SwigDelegateCmdObserverDefault_25(global::System.IntPtr sender);
  public delegate void SwigDelegateCmdObserverDefault_26(global::System.IntPtr sender, global::System.IntPtr sp);

  private SwigDelegateCmdObserverDefault_0 swigDelegate0;
  private SwigDelegateCmdObserverDefault_1 swigDelegate1;
  private SwigDelegateCmdObserverDefault_2 swigDelegate2;
  private SwigDelegateCmdObserverDefault_3 swigDelegate3;
  private SwigDelegateCmdObserverDefault_4 swigDelegate4;
  private SwigDelegateCmdObserverDefault_5 swigDelegate5;
  private SwigDelegateCmdObserverDefault_6 swigDelegate6;
  private SwigDelegateCmdObserverDefault_7 swigDelegate7;
  private SwigDelegateCmdObserverDefault_8 swigDelegate8;
  private SwigDelegateCmdObserverDefault_9 swigDelegate9;
  private SwigDelegateCmdObserverDefault_10 swigDelegate10;
  private SwigDelegateCmdObserverDefault_11 swigDelegate11;
  private SwigDelegateCmdObserverDefault_12 swigDelegate12;
  private SwigDelegateCmdObserverDefault_13 swigDelegate13;
  private SwigDelegateCmdObserverDefault_14 swigDelegate14;
  private SwigDelegateCmdObserverDefault_15 swigDelegate15;
  private SwigDelegateCmdObserverDefault_16 swigDelegate16;
  private SwigDelegateCmdObserverDefault_17 swigDelegate17;
  private SwigDelegateCmdObserverDefault_18 swigDelegate18;
  private SwigDelegateCmdObserverDefault_19 swigDelegate19;
  private SwigDelegateCmdObserverDefault_20 swigDelegate20;
  private SwigDelegateCmdObserverDefault_21 swigDelegate21;
  private SwigDelegateCmdObserverDefault_22 swigDelegate22;
  private SwigDelegateCmdObserverDefault_23 swigDelegate23;
  private SwigDelegateCmdObserverDefault_24 swigDelegate24;
  private SwigDelegateCmdObserverDefault_25 swigDelegate25;
  private SwigDelegateCmdObserverDefault_26 swigDelegate26;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(MgMotion), typeof(bool) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(MgCmdManager) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(MgMotion), typeof(Ints), typeof(int), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(MgMotion), typeof(int) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(MgMotion), typeof(int) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(MgMotion), typeof(MgCommand), typeof(GiGraphics) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape), typeof(int), typeof(GiGraphics) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape), typeof(int) };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape), typeof(int) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(MgMotion), typeof(int) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(MgMotion), typeof(string) };
  private static global::System.Type[] swigMethodTypes24 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes25 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes26 = new global::System.Type[] { typeof(MgMotion), typeof(MgShape) };
}

}
