/********************************************************************/
/*  Office 2007 Renderer Project                                    */
/*                                                                  */
/*  Use the Office2007Renderer class as a custom renderer by        */
/*  providing it to the ToolStripManager.Renderer property. Then    */
/*  all tool strips, menu strips, status strips etc will be drawn   */
/*  using the Office 2007 style renderer in your application.       */
/*                                                                  */
/*   Author: Phil Wright                                            */
/*  Website: www.componentfactory.com                               */
/*  Contact: phil.wright@componentfactory.com                       */
/********************************************************************/

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Office2007Rendering
{
	/// <summary>
	/// Set the SmoothingMode=AntiAlias until instance disposed.
	/// </summary>
	public class UseAntiAlias : IDisposable
	{
		#region Instance Fields
		private readonly Graphics g;
		private readonly SmoothingMode old;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the UseAntiAlias class.
		/// </summary>
		/// <param name="g">Graphics instance.</param>
		public UseAntiAlias(Graphics g)
		{
			this.g = g;
			old = this.g.SmoothingMode;
			this.g.SmoothingMode = SmoothingMode.AntiAlias;
		}

		/// <summary>
		/// Revert the SmoothingMode back to original setting.
		/// </summary>
		public void Dispose()
		{
			g.SmoothingMode = old;
		}
		#endregion
	}

	/// <summary>
	/// Set the TextRenderingHint.ClearTypeGridFit until instance disposed.
	/// </summary>
	public class UseClearTypeGridFit : IDisposable
	{
		#region Instance Fields
		private readonly Graphics g;
		private readonly TextRenderingHint old;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the UseClearTypeGridFit class.
		/// </summary>
		/// <param name="g">Graphics instance.</param>
		public UseClearTypeGridFit(Graphics g)
		{
			this.g = g;
			old = this.g.TextRenderingHint;
			this.g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
		}

		/// <summary>
		/// Revert the TextRenderingHint back to original setting.
		/// </summary>
		public void Dispose()
		{
			g.TextRenderingHint = old;
		}
		#endregion
	}

	/// <summary>
	/// Set the clipping region until instance disposed.
	/// </summary>
	public class UseClipping : IDisposable
	{
		#region Instance Fields
		private readonly Graphics g;
		private readonly Region old;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the UseClipping class.
		/// </summary>
		/// <param name="g">Graphics instance.</param>
		/// <param name="path">Clipping path.</param>
		public UseClipping(Graphics g, GraphicsPath path)
		{
			this.g = g;
			old = g.Clip;
			Region clip = old.Clone();
			clip.Intersect(path: path);
			this.g.Clip = clip;
		}

		/// <summary>
		/// Initialize a new instance of the UseClipping class.
		/// </summary>
		/// <param name="g">Graphics instance.</param>
		/// <param name="region">Clipping region.</param>
		public UseClipping(Graphics g, Region region)
		{
			this.g = g;
			old = g.Clip;
			Region clip = old.Clone();
			clip.Intersect(region: region);
			this.g.Clip = clip;
		}

		/// <summary>
		/// Revert clipping back to origina setting.
		/// </summary>
		public void Dispose()
		{
			g.Clip = old;
		}
		#endregion
	}
}
