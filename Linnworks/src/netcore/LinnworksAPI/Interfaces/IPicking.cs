using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IPickingController
	{
		CheckAllocatableToPickwaveResponse CheckAllocatableToPickwave(CheckAllocatableToPickwaveRequest request);
		DeleteOrdersFromPickingWavesResponse DeleteOrdersFromPickingWaves(DeleteOrdersFromPickingWavesRequest request);
		GeneratePickingWaveResponse GeneratePickingWave(PickingWaveGenerate request);
		GetPickingWavesResponse GetAllPickingWaves(GetPickingWavesRequest request);
		GetItemBinracksResponse GetItemBinracks(GetItemBinracksRequest request);
		GetPickingWavesResponse GetMyPickingWaves(GetPickingWavesRequest request);
		GetPickingWavesResponse GetPickingWave(GetPickingWaveRequest request);
		GetPickingWavesResponse UpdatePickedItemDelta(UpdatePickedItemDeltaRequest request);
		GetPickingWavesResponse UpdatePickingWaveHeader(PickingWaveUpdateRequest request);
		GetPickingWavesResponse UpdatePickingWaveItem(PickingWaveItemUpdateRequest request);
		GetPickingWavesResponse UpdatePickingWaveItemWithNewBinrack(UpdatePickingWaveItemWithNewBinrackRequest request);
	} 
}