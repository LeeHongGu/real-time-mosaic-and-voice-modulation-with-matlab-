/*
* MATLAB Compiler: 8.2 (R2021a)
* Date: Wed May 26 02:00:30 2021
* Arguments:
* "-B""macro_default""-W""dotnet:AudioPitchShift,Class1,4.0,private,version=1.0""-T""link:
* lib""-d""C:\Users\LeeHonggu\Documents\GitHub\real-time-mosaic-and-voice-modulation\audio
* Matlab\AudioPitchShift\for_testing""-v""class{Class1:C:\Users\LeeHonggu\Documents\GitHub
* \real-time-mosaic-and-voice-modulation\audioMatlab\AudioPitchShift.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace AudioPitchShiftNative
{

  /// <summary>
  /// The Class1 class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\LeeHonggu\Documents\GitHub\real-time-mosaic-and-voice-modulation\audioMatla
  /// b\AudioPitchShift.m
  /// </summary>
  /// <remarks>
  /// @Version 1.0
  /// </remarks>
  public class Class1 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Class1()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

		  int lastDelimiter = ctfFilePath.LastIndexOf(@"/");

	      if (lastDelimiter == -1)
		  {
		    lastDelimiter = ctfFilePath.LastIndexOf(@"\");
		  }

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "AudioPitchShift.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Class1 class.
    /// </summary>
    public Class1()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Class1()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the AudioPitchShift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create test bench input and output
    /// </remarks>
    ///
    public void AudioPitchShift()
    {
      mcr.EvaluateFunction(0, "AudioPitchShift", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the AudioPitchShift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create test bench input and output
    /// </remarks>
    /// <param name="shift_val">Input argument #1</param>
    ///
    public void AudioPitchShift(Object shift_val)
    {
      mcr.EvaluateFunction(0, "AudioPitchShift", shift_val);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the AudioPitchShift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create test bench input and output
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AudioPitchShift(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "AudioPitchShift", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the AudioPitchShift MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Create test bench input and output
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="shift_val">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] AudioPitchShift(int numArgsOut, Object shift_val)
    {
      return mcr.EvaluateFunction(numArgsOut, "AudioPitchShift", shift_val);
    }


    /// <summary>
    /// Provides an interface for the AudioPitchShift function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Create test bench input and output
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("AudioPitchShift", 1, 0, 0)]
    protected void AudioPitchShift(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("AudioPitchShift", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
