/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.core;

public class MgCmdManagerFactory {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected MgCmdManagerFactory(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgCmdManagerFactory obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        touchvgJNI.delete_MgCmdManagerFactory(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static MgCmdManager create() {
    long cPtr = touchvgJNI.MgCmdManagerFactory_create();
    return (cPtr == 0) ? null : new MgCmdManager(cPtr, false);
  }

  public MgCmdManagerFactory() {
    this(touchvgJNI.new_MgCmdManagerFactory(), true);
  }

}
