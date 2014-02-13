using System;

namespace FreeQuant.NxCoreLib
{
	public class TapeFile
	{
		private string path;
//		private IMessageReceiver dyoW602sJA;
//		private twdoksMNpxZIumpxuq NC2WHwLVfD;
//		private volatile byte xJaWIK04pm;

		
		public TapeFile(string path):base()
		{
			this.path = path;
		}

		
		public void Play(IMessageReceiver receiver, PlaybackOptions options)
		{
			//      this.dyoW602sJA = receiver;
			//      this.NC2WHwLVfD = options != null ? new twdoksMNpxZIumpxuq(options) : new twdoksMNpxZIumpxuq(new PlaybackOptions());
			//      if (Environment.Is64BitProcess)
			//      {
			//        this.xJaWIK04pm = 0;
			//        q5MvANBnPa6CFYed7NI.Vh1gSi0InU(this.path, (string) null, 0U, 0U, new DVPVC6BSxkKNJHTPTfU(this.pRAW3TVs6Y));
			//      }
			//      else
			//      {
			//        this.xJaWIK04pm = 0;
			//        nmD5uEBtLJoqZgMkfld.hvoPYknI3d(this.path, (string) null, 0U, 0U, new TEOWwGRGb1uR7wafRG(this.ak2WwU46ee));
			//      }
		}

		
		public void Stop()
		{
			//      if (Environment.Is64BitProcess)
			//        this.xJaWIK04pm =  1;
			//      else
			//        this.xJaWIK04pm =  1;
		}

		
		//    private unsafe int ak2WwU46ee(IntPtr obj0, IntPtr obj1)
		//    {
		//      jL0yLe0jc1NDJbMsuD* l0yLe0jc1NdJbMsuDPtr = (jL0yLe0jc1NDJbMsuD*) (void*) obj0;
		//      C2Ky85YNGfsGgcnH3Q* ky85YnGfsGgcnH3QPtr = (C2Ky85YNGfsGgcnH3Q*) (void*) obj1;
		//      switch (ky85YnGfsGgcnH3QPtr->sbrosuKBq3)
		//      {
		//        case 0U:
		//          if (l0yLe0jc1NdJbMsuDPtr->uZToaaN6VP >= 3)
		//          {
		//            if ((int) l0yLe0jc1NdJbMsuDPtr->EJWonYXQFj.Ne9ovpP5IE == 24)
		//            {
		//              this.xJaWIK04pm = (byte) 1;
		//              break;
		//            }
		//            else
		//            {
		//              this.PGPWTTmd4h(l0yLe0jc1NdJbMsuDPtr);
		//              break;
		//            }
		//          }
		//          else
		//            break;
		//        case 1U:
		//          if (this.NC2WHwLVfD.JOgWyPsyXN)
		//          {
		//            string symbol = this.D3KWnZXYE2(&ky85YnGfsGgcnH3QPtr->vQKo9xF8dN);
		//            if (this.NC2WHwLVfD.k6kWAb7rpR == null || this.NC2WHwLVfD.k6kWAb7rpR.Contains(symbol))
		//            {
		//              DateTime datetime = this.eWAWqWJ8O2(&ky85YnGfsGgcnH3QPtr->vQKo9xF8dN);
		//              if (datetime.TimeOfDay >= this.NC2WHwLVfD.euVWN9tPZW && datetime.TimeOfDay <= this.NC2WHwLVfD.PBUW7onxM8)
		//              {
		//                SkwbibBTafXYP0yYNhm* skwbibBtafXyP0yYnhmPtr = &ky85YnGfsGgcnH3QPtr->HN9omGyDl1.M70Y3P6Ah;
		//                if (skwbibBtafXyP0yYnhmPtr->rCHgTjE6gr != 0 || skwbibBtafXyP0yYnhmPtr->ULHgq4fjOi != 0 || (skwbibBtafXyP0yYnhmPtr->Ol0g3c1vWo != 0 || skwbibBtafXyP0yYnhmPtr->TmBgaU0clC != 0))
		//                {
		//                  this.dyoW602sJA.OnQuote(symbol, datetime, nmD5uEBtLJoqZgMkfld.TWEho8CVgl(skwbibBtafXyP0yYnhmPtr->JtZgwITmoW, skwbibBtafXyP0yYnhmPtr->m8agfqHdq0.xTsPcwsPPm), skwbibBtafXyP0yYnhmPtr->QPPgnFx0DW, nmD5uEBtLJoqZgMkfld.TWEho8CVgl(skwbibBtafXyP0yYnhmPtr->YAUgpeMKll, skwbibBtafXyP0yYnhmPtr->m8agfqHdq0.xTsPcwsPPm), skwbibBtafXyP0yYnhmPtr->aVfgdC9b9t);
		//                  break;
		//                }
		//                else
		//                  break;
		//              }
		//              else
		//                break;
		//            }
		//            else
		//              break;
		//          }
		//          else
		//            break;
		//        case 3U:
		//          if (this.NC2WHwLVfD.sn4WLlMYDl)
		//          {
		//            string symbol = this.D3KWnZXYE2(&ky85YnGfsGgcnH3QPtr->vQKo9xF8dN);
		//            if (this.NC2WHwLVfD.k6kWAb7rpR == null || this.NC2WHwLVfD.k6kWAb7rpR.Contains(symbol))
		//            {
		//              DateTime datetime = this.eWAWqWJ8O2(&ky85YnGfsGgcnH3QPtr->vQKo9xF8dN);
		//              if (datetime.TimeOfDay >= this.NC2WHwLVfD.euVWN9tPZW && datetime.TimeOfDay <= this.NC2WHwLVfD.PBUW7onxM8)
		//              {
		//                yiE2YYB1RrmQSS1U5Hj* e2YyB1RrmQsS1U5HjPtr = &ky85YnGfsGgcnH3QPtr->HN9omGyDl1.oj3BFBgqBb;
		//                this.dyoW602sJA.OnTrade(symbol, datetime, nmD5uEBtLJoqZgMkfld.TWEho8CVgl(e2YyB1RrmQsS1U5HjPtr->nnX5RvfPct, e2YyB1RrmQsS1U5HjPtr->Ro05CK8APe), e2YyB1RrmQsS1U5HjPtr->pdX5XSPbFg);
		//                break;
		//              }
		//              else
		//                break;
		//            }
		//            else
		//              break;
		//          }
		//          else
		//            break;
		//      }
		//      return (int) this.xJaWIK04pm;
		//    }

		
		//    private unsafe int pRAW3TVs6Y(IntPtr obj0, IntPtr obj1)
		//    {
		//      kl4JrHPym6aGTHEgOv* kl4JrHpym6aGthEgOvPtr = (kl4JrHPym6aGTHEgOv*) (void*) obj0;
		//      oQTTfCtQH3A49xiHw7* qtTfCtQh3A49xiHw7Ptr = (oQTTfCtQH3A49xiHw7*) (void*) obj1;
		//      switch (qtTfCtQh3A49xiHw7Ptr->zV6Bz9ZvHr)
		//      {
		//        case 0U:
		//          if (kl4JrHpym6aGthEgOvPtr->dWRyXujZl >= 3)
		//          {
		//            if ((int) kl4JrHpym6aGthEgOvPtr->mbkLb7MTQ.DbEBPEL7sf == 24)
		//            {
		//              this.xJaWIK04pm = (byte) 1;
		//              break;
		//            }
		//            else
		//            {
		//              this.iIXWd1jZhE(kl4JrHpym6aGthEgOvPtr);
		//              break;
		//            }
		//          }
		//          else
		//            break;
		//        case 1U:
		//          if (this.NC2WHwLVfD.JOgWyPsyXN)
		//          {
		//            string symbol = this.FIFWabEvaY(&qtTfCtQh3A49xiHw7Ptr->Y4yBjoH9SN);
		//            if (this.NC2WHwLVfD.k6kWAb7rpR == null || this.NC2WHwLVfD.k6kWAb7rpR.Contains(symbol))
		//            {
		//              DateTime datetime = this.r0qWb62CQh(&qtTfCtQh3A49xiHw7Ptr->Y4yBjoH9SN);
		//              if (datetime.TimeOfDay >= this.NC2WHwLVfD.euVWN9tPZW && datetime.TimeOfDay <= this.NC2WHwLVfD.PBUW7onxM8)
		//              {
		//                usIO3NWEvCLwEE1vefs* io3NwEvClwEe1vefsPtr = &qtTfCtQh3A49xiHw7Ptr->NsWBYMucub.EyyWUftYDg;
		//                if (io3NwEvClwEe1vefsPtr->eaXA2LiXyV != 0 || io3NwEvClwEe1vefsPtr->Oo0Ax8ciCr != 0 || (io3NwEvClwEe1vefsPtr->JQFAOES8nk != 0 || io3NwEvClwEe1vefsPtr->jkFACWWQlX != 0))
		//                {
		//                  this.dyoW602sJA.OnQuote(symbol, datetime, q5MvANBnPa6CFYed7NI.aPEgZ5vht3(io3NwEvClwEe1vefsPtr->OfpAV5Qhuo, io3NwEvClwEe1vefsPtr->Ej7Asjf8pX.MghAKlJc2Y), io3NwEvClwEe1vefsPtr->OyOARNdUeV, q5MvANBnPa6CFYed7NI.aPEgZ5vht3(io3NwEvClwEe1vefsPtr->h9mAZaFxuP, io3NwEvClwEe1vefsPtr->Ej7Asjf8pX.MghAKlJc2Y), io3NwEvClwEe1vefsPtr->PiqA8ZWy88);
		//                  break;
		//                }
		//                else
		//                  break;
		//              }
		//              else
		//                break;
		//            }
		//            else
		//              break;
		//          }
		//          else
		//            break;
		//        case 3U:
		//          if (this.NC2WHwLVfD.sn4WLlMYDl)
		//          {
		//            string symbol = this.FIFWabEvaY(&qtTfCtQh3A49xiHw7Ptr->Y4yBjoH9SN);
		//            if (this.NC2WHwLVfD.k6kWAb7rpR == null || this.NC2WHwLVfD.k6kWAb7rpR.Contains(symbol))
		//            {
		//              DateTime datetime = this.r0qWb62CQh(&qtTfCtQh3A49xiHw7Ptr->Y4yBjoH9SN);
		//              if (datetime.TimeOfDay >= this.NC2WHwLVfD.euVWN9tPZW && datetime.TimeOfDay <= this.NC2WHwLVfD.PBUW7onxM8)
		//              {
		//                H7RfhJB2hGI6RcUP5Qg* rfhJb2hGi6RcUp5QgPtr = &qtTfCtQh3A49xiHw7Ptr->NsWBYMucub.gsfW1FNw3Z;
		//                this.dyoW602sJA.OnTrade(symbol, datetime, q5MvANBnPa6CFYed7NI.aPEgZ5vht3(rfhJb2hGi6RcUp5QgPtr->I0TlvVSPjj, rfhJb2hGi6RcUp5QgPtr->A32llbHsOP), rfhJb2hGi6RcUp5QgPtr->MunlQkt7i3);
		//                break;
		//              }
		//              else
		//                break;
		//            }
		//            else
		//              break;
		//          }
		//          else
		//            break;
		//      }
		//      return (int) this.xJaWIK04pm;
		//    }

		
		//    private unsafe void PGPWTTmd4h(jL0yLe0jc1NDJbMsuD* obj0)
		//    {
		//      this.dyoW602sJA.OnStatus(this.OYlW4nymXo(&obj0->WtZodyawNO, &obj0->EJWonYXQFj));
		//    }
//
//
		//    private unsafe void iIXWd1jZhE(kl4JrHPym6aGTHEgOv* obj0)
		//    {
		//      this.dyoW602sJA.OnStatus(this.uTcWkLe0Vy(&obj0->uvvA4qbRX, &obj0->mbkLb7MTQ));
		//    }
//
//
		//    private unsafe string D3KWnZXYE2(E8NDrmBFS04KS0I5pnX* obj0)
		//    {
		//      return new string(&obj0->zSooZklXGi->Sqh57NcisN);
		//    }
//
//
		//    private unsafe string FIFWabEvaY(Sxd5h4lAdbajNp8pts* obj0)
		//    {
		//      return new string(&obj0->iu5MihCfE->iHjlJHmCxP);
		//    }
//
//
		//    private unsafe DateTime eWAWqWJ8O2(E8NDrmBFS04KS0I5pnX* obj0)
		//    {
		//      return this.OYlW4nymXo(&obj0->shJoOhGI6R, &obj0->TUPo25QgT5);
		//    }
//
//
		//    private unsafe DateTime r0qWb62CQh(Sxd5h4lAdbajNp8pts* obj0)
		//    {
		//      return this.uTcWkLe0Vy(&obj0->cBPStfuHX, &obj0->oB6irf9iw);
		//    }
//
//
		//    private unsafe DateTime OYlW4nymXo(WH1BMVBf16MYQ7dP2Ub* obj0, meXNQ92SCGjV9Aqu6S* obj1)
		//    {
		//      return new DateTime((int) obj0->yKmghd8smc, (int) obj0->zy6gJnHWuT, (int) obj0->m8MgvxYSfi, (int) obj1->Ne9ovpP5IE, (int) obj1->AYqoJfNRTP, (int) obj1->aeLohnhCUt, (int) obj1->VQToPgKD0v);
		//    }
//
//
		//    private unsafe DateTime uTcWkLe0Vy(yIWTEmxY65L6oxyR5J* obj0, VtgdIIfT8BrNynvabH* obj1)
		//    {
		//      return new DateTime((int) obj0->MXIoNU8ypN, (int) obj0->KD5o7uELJo, (int) obj0->zZgoUMkfld, (int) obj1->DbEBPEL7sf, (int) obj1->EEwBGbSlsi, (int) obj1->OcnBEXR02E, (int) obj1->dE1BgUFSWg);
		//    }
	}
}
