/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class TeamManager : PluginInterface2 {
  private HandleRef swigCPtr;

  internal TeamManager(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.TeamManager_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TeamManager obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TeamManager() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_TeamManager(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static TeamManager GetInstance() {
    IntPtr cPtr = RakNetPINVOKE.TeamManager_GetInstance();
    TeamManager ret = (cPtr == IntPtr.Zero) ? null : new TeamManager(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(TeamManager i) {
    RakNetPINVOKE.TeamManager_DestroyInstance(TeamManager.getCPtr(i));
  }

  public TeamManager() : this(RakNetPINVOKE.new_TeamManager(), true) {
  }

  public TM_World AddWorld(byte worldId) {
    IntPtr cPtr = RakNetPINVOKE.TeamManager_AddWorld(swigCPtr, worldId);
    TM_World ret = (cPtr == IntPtr.Zero) ? null : new TM_World(cPtr, false);
    return ret;
  }

  public void RemoveWorld(byte worldId) {
    RakNetPINVOKE.TeamManager_RemoveWorld(swigCPtr, worldId);
  }

  public uint GetWorldCount() {
    uint ret = RakNetPINVOKE.TeamManager_GetWorldCount(swigCPtr);
    return ret;
  }

  public TM_World GetWorldAtIndex(uint index) {
    IntPtr cPtr = RakNetPINVOKE.TeamManager_GetWorldAtIndex(swigCPtr, index);
    TM_World ret = (cPtr == IntPtr.Zero) ? null : new TM_World(cPtr, false);
    return ret;
  }

  public TM_World GetWorldWithId(byte worldId) {
    IntPtr cPtr = RakNetPINVOKE.TeamManager_GetWorldWithId(swigCPtr, worldId);
    TM_World ret = (cPtr == IntPtr.Zero) ? null : new TM_World(cPtr, false);
    return ret;
  }

  public void SetAutoManageConnections(bool autoAdd) {
    RakNetPINVOKE.TeamManager_SetAutoManageConnections(swigCPtr, autoAdd);
  }

  public void SetTopology(TMTopology _topology) {
    RakNetPINVOKE.TeamManager_SetTopology(swigCPtr, (int)_topology);
  }

  public void DecomposeTeamFull(Packet packet, SWIGTYPE_p_p_RakNet__TM_World world, SWIGTYPE_p_p_RakNet__TM_TeamMember teamMember, SWIGTYPE_p_p_RakNet__TM_Team team, SWIGTYPE_p_unsigned_short currentMembers, SWIGTYPE_p_unsigned_short memberLimitIncludingBalancing, SWIGTYPE_p_bool balancingIsActive, SWIGTYPE_p_unsigned_char joinPermissions) {
    RakNetPINVOKE.TeamManager_DecomposeTeamFull(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_p_RakNet__TM_World.getCPtr(world), SWIGTYPE_p_p_RakNet__TM_TeamMember.getCPtr(teamMember), SWIGTYPE_p_p_RakNet__TM_Team.getCPtr(team), SWIGTYPE_p_unsigned_short.getCPtr(currentMembers), SWIGTYPE_p_unsigned_short.getCPtr(memberLimitIncludingBalancing), SWIGTYPE_p_bool.getCPtr(balancingIsActive), SWIGTYPE_p_unsigned_char.getCPtr(joinPermissions));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DecomposeTeamLocked(Packet packet, SWIGTYPE_p_p_RakNet__TM_World world, SWIGTYPE_p_p_RakNet__TM_TeamMember teamMember, SWIGTYPE_p_p_RakNet__TM_Team team, SWIGTYPE_p_unsigned_short currentMembers, SWIGTYPE_p_unsigned_short memberLimitIncludingBalancing, SWIGTYPE_p_bool balancingIsActive, SWIGTYPE_p_unsigned_char joinPermissions) {
    RakNetPINVOKE.TeamManager_DecomposeTeamLocked(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_p_RakNet__TM_World.getCPtr(world), SWIGTYPE_p_p_RakNet__TM_TeamMember.getCPtr(teamMember), SWIGTYPE_p_p_RakNet__TM_Team.getCPtr(team), SWIGTYPE_p_unsigned_short.getCPtr(currentMembers), SWIGTYPE_p_unsigned_short.getCPtr(memberLimitIncludingBalancing), SWIGTYPE_p_bool.getCPtr(balancingIsActive), SWIGTYPE_p_unsigned_char.getCPtr(joinPermissions));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    RakNetPINVOKE.TeamManager_Clear(swigCPtr);
  }

  public void DecodeTeamAssigned(Packet packet, SWIGTYPE_p_p_RakNet__TM_World world, SWIGTYPE_p_p_RakNet__TM_TeamMember teamMember) {
    RakNetPINVOKE.TeamManager_DecodeTeamAssigned(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_p_RakNet__TM_World.getCPtr(world), SWIGTYPE_p_p_RakNet__TM_TeamMember.getCPtr(teamMember));
  }

  public void DecodeTeamCancelled(Packet packet, SWIGTYPE_p_p_RakNet__TM_World world, SWIGTYPE_p_p_RakNet__TM_TeamMember teamMember, SWIGTYPE_p_p_RakNet__TM_Team teamCancelled) {
    RakNetPINVOKE.TeamManager_DecodeTeamCancelled(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_p_RakNet__TM_World.getCPtr(world), SWIGTYPE_p_p_RakNet__TM_TeamMember.getCPtr(teamMember), SWIGTYPE_p_p_RakNet__TM_Team.getCPtr(teamCancelled));
  }

}

}
