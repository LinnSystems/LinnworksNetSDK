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
		GetPickingWaveHeadersResponse GetAllPickingWaveHeaders(GetPickingWavesRequest request);
		GetPickingWavesResponse GetAllPickingWaves(GetPickingWavesRequest request);
		GetItemBinracksResponse GetItemBinracks(GetItemBinracksRequest request);
		GetPickingWaveHeadersResponse GetMyPickingWaveHeaders(GetPickingWavesRequest request);
		GetPickingWavesResponse GetMyPickingWaves(GetPickingWavesRequest request);
		GetPickingWavesResponse GetPickingWave(GetPickingWaveRequest request);
		GetPickwaveUsersWithSummaryResponse GetPickwaveUsersWithSummary(GetPickingWavesRequest request);
		GetPickingWavesResponse UpdatePickedItemDelta(UpdatePickedItemDeltaRequest request);
		GetPickingWavesResponse UpdatePickingWaveHeader(PickingWaveUpdateRequest request);
		GetPickingWavesResponse UpdatePickingWaveItem(PickingWaveItemUpdateRequest request);
		GetPickingWavesResponse UpdatePickingWaveItemWithNewBinrack(UpdatePickingWaveItemWithNewBinrackRequest request);
	} 
}