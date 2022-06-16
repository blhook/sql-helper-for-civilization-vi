// Copyright (C) 2022 Brandon Hook
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using Test.ORM.Gameplay;

namespace Test.ORM
{
    public partial class GameplayDB : BaseDBContext
    {
        public GameplayDB() : base((new SQLiteConnection()
        {
            ConnectionString =
                                                                                        new SQLiteConnectionStringBuilder()
                                                                                        { DataSource = Path.Combine(SQLHelper_Civ.Properties.Settings.Default.GameplayPath), ForeignKeys = true }
                                                                                        .ConnectionString
        }), true)
        {
        }

        //public virtual DbSet<AiLists> AiLists { get; set; }
        //public virtual DbSet<ObsoletePolicies> ObsoletePolicies { get; set; }
        public virtual DbSet<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }
        public virtual DbSet<AgendaPreferredLeaders> AgendaPreferredLeaders { get; set; }
        public virtual DbSet<AgendaTags> AgendaTags { get; set; }
        public virtual DbSet<AgendaTraits> AgendaTraits { get; set; }
        public virtual DbSet<Agendas> Agendas { get; set; }
        public virtual DbSet<AiBuildSpecializations> AiBuildSpecializations { get; set; }
        public virtual DbSet<AiEvents> AiEvents { get; set; }
        public virtual DbSet<AiFavoredItems> AiFavoredItems { get; set; }
        public virtual DbSet<AiListTypes> AiListTypes { get; set; }
        public virtual DbSet<AiOperationDefs> AiOperationDefs { get; set; }
        public virtual DbSet<AiOperationLimits> AiOperationLimits { get; set; }
        public virtual DbSet<AiOperationLists> AiOperationLists { get; set; }
        public virtual DbSet<AiOperationTeams> AiOperationTeams { get; set; }
        public virtual DbSet<AiOperationTypes> AiOperationTypes { get; set; }
        public virtual DbSet<AiScoutUses> AiScoutUses { get; set; }
        public virtual DbSet<AiTeams> AiTeams { get; set; }
        public virtual DbSet<AllianceEffects> AllianceEffects { get; set; }
        public virtual DbSet<Alliances> Alliances { get; set; }
        public virtual DbSet<AllowedMoves> AllowedMoves { get; set; }
        public virtual DbSet<AllowedOperations> AllowedOperations { get; set; }
        public virtual DbSet<AppealHousingChanges> AppealHousingChanges { get; set; }
        public virtual DbSet<BarbarianAttackForces> BarbarianAttackForces { get; set; }
        public virtual DbSet<BarbarianTribeForces> BarbarianTribeForces { get; set; }
        public virtual DbSet<BarbarianTribeNames> BarbarianTribeNames { get; set; }
        public virtual DbSet<BarbarianTribes> BarbarianTribes { get; set; }
        public virtual DbSet<BehaviorTreeNodes> BehaviorTreeNodes { get; set; }
        public virtual DbSet<BehaviorTrees> BehaviorTrees { get; set; }
        public virtual DbSet<BeliefClasses> BeliefClasses { get; set; }
        public virtual DbSet<BeliefModifiers> BeliefModifiers { get; set; }
        public virtual DbSet<Beliefs> Beliefs { get; set; }
        public virtual DbSet<BonusMinorStartingUnits> BonusMinorStartingUnits { get; set; }
        public virtual DbSet<BoostHandlers> BoostHandlers { get; set; }
        public virtual DbSet<BoostNames> BoostNames { get; set; }
        public virtual DbSet<Boosts> Boosts { get; set; }
        public virtual DbSet<BuildingModifiers> BuildingModifiers { get; set; }
        public virtual DbSet<BuildingPrereqs> BuildingPrereqs { get; set; }
        public virtual DbSet<BuildingReplaces> BuildingReplaces { get; set; }
        public virtual DbSet<Building_GreatPersonPoints> Building_GreatPersonPoints { get; set; }
        public virtual DbSet<Building_GreatWorks> Building_GreatWorks { get; set; }
        public virtual DbSet<Building_RequiredFeatures> Building_RequiredFeatures { get; set; }
        public virtual DbSet<Building_ResourceCosts> Building_ResourceCosts { get; set; }
        public virtual DbSet<Building_TourismBombs_XP2> Building_TourismBombs_XP2 { get; set; }
        public virtual DbSet<Building_ValidFeatures> Building_ValidFeatures { get; set; }
        public virtual DbSet<Building_ValidTerrains> Building_ValidTerrains { get; set; }
        public virtual DbSet<Building_YieldChanges> Building_YieldChanges { get; set; }
        public virtual DbSet<Building_YieldChangesBonusWithPower> Building_YieldChangesBonusWithPower { get; set; }
        public virtual DbSet<Building_YieldDistrictCopies> Building_YieldDistrictCopies { get; set; }
        public virtual DbSet<Building_YieldsPerEra> Building_YieldsPerEra { get; set; }
        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<Buildings_XP2> Buildings_XP2 { get; set; }
        public virtual DbSet<Calendars> Calendars { get; set; }
        public virtual DbSet<CityEvents> CityEvents { get; set; }
        public virtual DbSet<CityNames> CityNames { get; set; }
        public virtual DbSet<CivicModifiers> CivicModifiers { get; set; }
        public virtual DbSet<CivicPrereqs> CivicPrereqs { get; set; }
        public virtual DbSet<CivicQuotes> CivicQuotes { get; set; }
        public virtual DbSet<CivicRandomCosts> CivicRandomCosts { get; set; }
        public virtual DbSet<Civics> Civics { get; set; }
        public virtual DbSet<Civics_XP2> Civics_XP2 { get; set; }
        public virtual DbSet<CivilizationCitizenNames> CivilizationCitizenNames { get; set; }
        public virtual DbSet<CivilizationInfo> CivilizationInfo { get; set; }
        public virtual DbSet<CivilizationLeaders> CivilizationLeaders { get; set; }
        public virtual DbSet<CivilizationLevels> CivilizationLevels { get; set; }
        public virtual DbSet<CivilizationTraits> CivilizationTraits { get; set; }
        public virtual DbSet<Civilizations> Civilizations { get; set; }
        public virtual DbSet<CivilopediaPageChapterHeaders> CivilopediaPageChapterHeaders { get; set; }
        public virtual DbSet<CivilopediaPageChapterParagraphs> CivilopediaPageChapterParagraphs { get; set; }
        public virtual DbSet<CivilopediaPageExcludes> CivilopediaPageExcludes { get; set; }
        public virtual DbSet<CivilopediaPageGroupExcludes> CivilopediaPageGroupExcludes { get; set; }
        public virtual DbSet<CivilopediaPageGroupQueries> CivilopediaPageGroupQueries { get; set; }
        public virtual DbSet<CivilopediaPageGroups> CivilopediaPageGroups { get; set; }
        public virtual DbSet<CivilopediaPageLayoutChapters> CivilopediaPageLayoutChapters { get; set; }
        public virtual DbSet<CivilopediaPageLayouts> CivilopediaPageLayouts { get; set; }
        public virtual DbSet<CivilopediaPageQueries> CivilopediaPageQueries { get; set; }
        public virtual DbSet<CivilopediaPageSearchTermQueries> CivilopediaPageSearchTermQueries { get; set; }
        public virtual DbSet<CivilopediaPageSearchTerms> CivilopediaPageSearchTerms { get; set; }
        public virtual DbSet<CivilopediaPages> CivilopediaPages { get; set; }
        public virtual DbSet<CivilopediaSectionExcludes> CivilopediaSectionExcludes { get; set; }
        public virtual DbSet<CivilopediaSections> CivilopediaSections { get; set; }
        public virtual DbSet<CoastalLowlands> CoastalLowlands { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<CommemorationModifiers> CommemorationModifiers { get; set; }
        public virtual DbSet<CommemorationTypes> CommemorationTypes { get; set; }
        public virtual DbSet<ComplimentModifiers> ComplimentModifiers { get; set; }
        public virtual DbSet<CongressAiChanges> CongressAiChanges { get; set; }
        public virtual DbSet<Continents> Continents { get; set; }
        public virtual DbSet<DataTypes> DataTypes { get; set; }
        public virtual DbSet<DealItems> DealItems { get; set; }
        public virtual DbSet<Defeats> Defeats { get; set; }
        public virtual DbSet<DeforestationEffects> DeforestationEffects { get; set; }
        public virtual DbSet<DeforestationLevels> DeforestationLevels { get; set; }
        public virtual DbSet<Difficulties_Gameplay> Difficulties_Gameplay { get; set; }
        public virtual DbSet<DiplomacyInfo> DiplomacyInfo { get; set; }
        public virtual DbSet<DiplomacyMoodTypes> DiplomacyMoodTypes { get; set; }
        public virtual DbSet<DiplomacySelections> DiplomacySelections { get; set; }
        public virtual DbSet<DiplomacyStatementSubTypes> DiplomacyStatementSubTypes { get; set; }
        public virtual DbSet<DiplomacyStatementTypes> DiplomacyStatementTypes { get; set; }
        public virtual DbSet<DiplomacyStatements> DiplomacyStatements { get; set; }
        public virtual DbSet<DiplomaticActions> DiplomaticActions { get; set; }
        public virtual DbSet<DiplomaticActions_XP1> DiplomaticActions_XP1 { get; set; }
        public virtual DbSet<DiplomaticActions_XP2> DiplomaticActions_XP2 { get; set; }
        public virtual DbSet<DiplomaticStartStates> DiplomaticStartStates { get; set; }
        public virtual DbSet<DiplomaticStateActions> DiplomaticStateActions { get; set; }
        public virtual DbSet<DiplomaticStateTransitions> DiplomaticStateTransitions { get; set; }
        public virtual DbSet<DiplomaticStates> DiplomaticStates { get; set; }
        public virtual DbSet<DiplomaticTriggeredTransitions> DiplomaticTriggeredTransitions { get; set; }
        public virtual DbSet<DiplomaticTriggers> DiplomaticTriggers { get; set; }
        public virtual DbSet<DiplomaticTriggers_RequiredStates> DiplomaticTriggers_RequiredStates { get; set; }
        public virtual DbSet<DiplomaticVisibilitySources> DiplomaticVisibilitySources { get; set; }
        public virtual DbSet<DiplomaticVisibilitySources_XP1> DiplomaticVisibilitySources_XP1 { get; set; }
        public virtual DbSet<Discussions> Discussions { get; set; }
        public virtual DbSet<DistrictModifiers> DistrictModifiers { get; set; }
        public virtual DbSet<DistrictReplaces> DistrictReplaces { get; set; }
        public virtual DbSet<District_Adjacencies> District_Adjacencies { get; set; }
        public virtual DbSet<District_BuildChargeProductions> District_BuildChargeProductions { get; set; }
        public virtual DbSet<District_CitizenGreatPersonPoints> District_CitizenGreatPersonPoints { get; set; }
        public virtual DbSet<District_CitizenYieldChanges> District_CitizenYieldChanges { get; set; }
        public virtual DbSet<District_GreatPersonPoints> District_GreatPersonPoints { get; set; }
        public virtual DbSet<District_RequiredFeatures> District_RequiredFeatures { get; set; }
        public virtual DbSet<District_TradeRouteYields> District_TradeRouteYields { get; set; }
        public virtual DbSet<District_ValidTerrains> District_ValidTerrains { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<Districts_XP2> Districts_XP2 { get; set; }
        public virtual DbSet<DuplicateCivilizations> DuplicateCivilizations { get; set; }
        public virtual DbSet<DuplicateLeaders> DuplicateLeaders { get; set; }
        public virtual DbSet<DynamicModifiers> DynamicModifiers { get; set; }
        public virtual DbSet<Emergencies_XP2> Emergencies_XP2 { get; set; }
        public virtual DbSet<EmergencyAlliances> EmergencyAlliances { get; set; }
        public virtual DbSet<EmergencyBuffs> EmergencyBuffs { get; set; }
        public virtual DbSet<EmergencyGoalTexts> EmergencyGoalTexts { get; set; }
        public virtual DbSet<EmergencyRewards> EmergencyRewards { get; set; }
        public virtual DbSet<EmergencyScoreSources> EmergencyScoreSources { get; set; }
        public virtual DbSet<EmergencyTexts> EmergencyTexts { get; set; }
        public virtual DbSet<Eras> Eras { get; set; }
        public virtual DbSet<Eras_XP1> Eras_XP1 { get; set; }
        public virtual DbSet<Eras_XP2> Eras_XP2 { get; set; }
        public virtual DbSet<EventPopupData> EventPopupData { get; set; }
        public virtual DbSet<ExcludedAdjacencies> ExcludedAdjacencies { get; set; }
        public virtual DbSet<ExcludedDistricts> ExcludedDistricts { get; set; }
        public virtual DbSet<ExcludedGreatPersonClasses> ExcludedGreatPersonClasses { get; set; }
        public virtual DbSet<ExclusiveAgendas> ExclusiveAgendas { get; set; }
        public virtual DbSet<FavoredReligions> FavoredReligions { get; set; }
        public virtual DbSet<Feature_AdjacentFeatures> Feature_AdjacentFeatures { get; set; }
        public virtual DbSet<Feature_AdjacentTerrains> Feature_AdjacentTerrains { get; set; }
        public virtual DbSet<Feature_AdjacentYields> Feature_AdjacentYields { get; set; }
        public virtual DbSet<Feature_Floodplains> Feature_Floodplains { get; set; }
        public virtual DbSet<Feature_NotAdjacentTerrains> Feature_NotAdjacentTerrains { get; set; }
        public virtual DbSet<Feature_NotNearFeatures> Feature_NotNearFeatures { get; set; }
        public virtual DbSet<Feature_Removes> Feature_Removes { get; set; }
        public virtual DbSet<Feature_ValidTerrains> Feature_ValidTerrains { get; set; }
        public virtual DbSet<Feature_YieldChanges> Feature_YieldChanges { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<Features_XP2> Features_XP2 { get; set; }
        public virtual DbSet<Flavors> Flavors { get; set; }
        public virtual DbSet<GameCapabilities> GameCapabilities { get; set; }
        public virtual DbSet<GameCapabilityDependencies> GameCapabilityDependencies { get; set; }
        public virtual DbSet<GameEffectArguments> GameEffectArguments { get; set; }
        public virtual DbSet<GameEffects> GameEffects { get; set; }
        public virtual DbSet<GameModifiers> GameModifiers { get; set; }
        public virtual DbSet<GameSpeed_Durations> GameSpeed_Durations { get; set; }
        public virtual DbSet<GameSpeed_Scalings> GameSpeed_Scalings { get; set; }
        public virtual DbSet<GameSpeed_Turns> GameSpeed_Turns { get; set; }
        public virtual DbSet<GameSpeeds> GameSpeeds { get; set; }
        public virtual DbSet<GlobalParameters> GlobalParameters { get; set; }
        public virtual DbSet<GoodyHutSubTypes> GoodyHutSubTypes { get; set; }
        public virtual DbSet<GoodyHutSubTypes_XP2> GoodyHutSubTypes_XP2 { get; set; }
        public virtual DbSet<GoodyHuts> GoodyHuts { get; set; }
        public virtual DbSet<Gossips> Gossips { get; set; }
        public virtual DbSet<GovernmentBonusNames> GovernmentBonusNames { get; set; }
        public virtual DbSet<GovernmentModifiers> GovernmentModifiers { get; set; }
        public virtual DbSet<GovernmentSlots> GovernmentSlots { get; set; }
        public virtual DbSet<GovernmentTiers> GovernmentTiers { get; set; }
        public virtual DbSet<Government_SlotCounts> Government_SlotCounts { get; set; }
        public virtual DbSet<Governments> Governments { get; set; }
        public virtual DbSet<Governments_XP2> Governments_XP2 { get; set; }
        public virtual DbSet<GovernorModifiers> GovernorModifiers { get; set; }
        public virtual DbSet<GovernorPromotionModifiers> GovernorPromotionModifiers { get; set; }
        public virtual DbSet<GovernorPromotionPrereqs> GovernorPromotionPrereqs { get; set; }
        public virtual DbSet<GovernorPromotionSets> GovernorPromotionSets { get; set; }
        public virtual DbSet<GovernorPromotions> GovernorPromotions { get; set; }
        public virtual DbSet<GovernorReplaces> GovernorReplaces { get; set; }
        public virtual DbSet<Governors> Governors { get; set; }
        public virtual DbSet<Governors_XP2> Governors_XP2 { get; set; }
        public virtual DbSet<GreatPersonClasses> GreatPersonClasses { get; set; }
        public virtual DbSet<GreatPersonIndividualActionModifiers> GreatPersonIndividualActionModifiers { get; set; }
        public virtual DbSet<GreatPersonIndividualBirthModifiers> GreatPersonIndividualBirthModifiers { get; set; }
        public virtual DbSet<GreatPersonIndividualIconModifiers> GreatPersonIndividualIconModifiers { get; set; }
        public virtual DbSet<GreatPersonIndividuals> GreatPersonIndividuals { get; set; }
        public virtual DbSet<GreatWorkObjectTypes> GreatWorkObjectTypes { get; set; }
        public virtual DbSet<GreatWorkSlotTypes> GreatWorkSlotTypes { get; set; }
        public virtual DbSet<GreatWork_ValidSubTypes> GreatWork_ValidSubTypes { get; set; }
        public virtual DbSet<GreatWork_YieldChanges> GreatWork_YieldChanges { get; set; }
        public virtual DbSet<GreatWorks> GreatWorks { get; set; }
        public virtual DbSet<Happinesses> Happinesses { get; set; }
        public virtual DbSet<Happinesses_XP1> Happinesses_XP1 { get; set; }
        public virtual DbSet<HistoricRankings> HistoricRankings { get; set; }
        public virtual DbSet<HistoricalAgendas> HistoricalAgendas { get; set; }
        public virtual DbSet<ImprovementModifiers> ImprovementModifiers { get; set; }
        public virtual DbSet<Improvement_Adjacencies> Improvement_Adjacencies { get; set; }
        public virtual DbSet<Improvement_BonusYieldChanges> Improvement_BonusYieldChanges { get; set; }
        public virtual DbSet<Improvement_InvalidAdjacentFeatures> Improvement_InvalidAdjacentFeatures { get; set; }
        public virtual DbSet<Improvement_Tourism> Improvement_Tourism { get; set; }
        public virtual DbSet<Improvement_ValidAdjacentResources> Improvement_ValidAdjacentResources { get; set; }
        public virtual DbSet<Improvement_ValidAdjacentTerrains> Improvement_ValidAdjacentTerrains { get; set; }
        public virtual DbSet<Improvement_ValidBuildUnits> Improvement_ValidBuildUnits { get; set; }
        public virtual DbSet<Improvement_ValidFeatures> Improvement_ValidFeatures { get; set; }
        public virtual DbSet<Improvement_ValidResources> Improvement_ValidResources { get; set; }
        public virtual DbSet<Improvement_ValidTerrains> Improvement_ValidTerrains { get; set; }
        public virtual DbSet<Improvement_YieldChanges> Improvement_YieldChanges { get; set; }
        public virtual DbSet<Improvements> Improvements { get; set; }
        public virtual DbSet<Improvements_XP2> Improvements_XP2 { get; set; }
        public virtual DbSet<InterfaceModes> InterfaceModes { get; set; }
        public virtual DbSet<Kinds> Kinds { get; set; }
        public virtual DbSet<LeaderAnimations> LeaderAnimations { get; set; }
        public virtual DbSet<LeaderInfo> LeaderInfo { get; set; }
        public virtual DbSet<LeaderQuotes> LeaderQuotes { get; set; }
        public virtual DbSet<LeaderTraits> LeaderTraits { get; set; }
        public virtual DbSet<Leaders> Leaders { get; set; }
        public virtual DbSet<Leaders_XP2> Leaders_XP2 { get; set; }
        public virtual DbSet<LoadingInfo> LoadingInfo { get; set; }
        public virtual DbSet<LoyaltyLevels> LoyaltyLevels { get; set; }
        public virtual DbSet<MajorStartingUnits> MajorStartingUnits { get; set; }
        public virtual DbSet<MapRainfalls> MapRainfalls { get; set; }
        public virtual DbSet<MapResourceDistributions> MapResourceDistributions { get; set; }
        public virtual DbSet<MapSeaLevels> MapSeaLevels { get; set; }
        public virtual DbSet<MapStartPositions> MapStartPositions { get; set; }
        public virtual DbSet<MapTemperatures> MapTemperatures { get; set; }
        public virtual DbSet<MapWorldAges> MapWorldAges { get; set; }
        public virtual DbSet<Map_GreatPersonClasses> Map_GreatPersonClasses { get; set; }
        public virtual DbSet<Maps> Maps { get; set; }
        public virtual DbSet<Maps_XP2> Maps_XP2 { get; set; }
        public virtual DbSet<MinorCivBonuses> MinorCivBonuses { get; set; }
        public virtual DbSet<ModifierArguments> ModifierArguments { get; set; }
        public virtual DbSet<ModifierStrings> ModifierStrings { get; set; }
        public virtual DbSet<Modifiers> Modifiers { get; set; }
        public virtual DbSet<MomentDataTypes> MomentDataTypes { get; set; }
        public virtual DbSet<MomentIllustrationTypes> MomentIllustrationTypes { get; set; }
        public virtual DbSet<MomentIllustrations> MomentIllustrations { get; set; }
        public virtual DbSet<Moments> Moments { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<MutuallyExclusiveBuildings> MutuallyExclusiveBuildings { get; set; }
        public virtual DbSet<MutuallyExclusiveDistricts> MutuallyExclusiveDistricts { get; set; }
        public virtual DbSet<NamedDesertCivilizations> NamedDesertCivilizations { get; set; }
        public virtual DbSet<NamedDeserts> NamedDeserts { get; set; }
        public virtual DbSet<NamedMountainCivilizations> NamedMountainCivilizations { get; set; }
        public virtual DbSet<NamedMountains> NamedMountains { get; set; }
        public virtual DbSet<NamedRiverCivilizations> NamedRiverCivilizations { get; set; }
        public virtual DbSet<NamedRivers> NamedRivers { get; set; }
        public virtual DbSet<NamedVolcanoCivilizations> NamedVolcanoCivilizations { get; set; }
        public virtual DbSet<NamedVolcanoes> NamedVolcanoes { get; set; }
        public virtual DbSet<NavigationProperties> NavigationProperties { get; set; }
        public virtual DbSet<NodeDataDefinitions> NodeDataDefinitions { get; set; }
        public virtual DbSet<NodeDefinitions> NodeDefinitions { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OpTeamRequirements> OpTeamRequirements { get; set; }
        public virtual DbSet<PlayerColors> PlayerColors { get; set; }
        public virtual DbSet<PlotEvalConditions> PlotEvalConditions { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
        public virtual DbSet<Policies_XP1> Policies_XP1 { get; set; }
        public virtual DbSet<PolicyModifiers> PolicyModifiers { get; set; }
        public virtual DbSet<Policy_GovernmentExclusives_XP2> Policy_GovernmentExclusives_XP2 { get; set; }
        public virtual DbSet<PrevailingWinds> PrevailingWinds { get; set; }
        public virtual DbSet<ProjectCompletionModifiers> ProjectCompletionModifiers { get; set; }
        public virtual DbSet<ProjectPrereqs> ProjectPrereqs { get; set; }
        public virtual DbSet<Project_BuildingCosts> Project_BuildingCosts { get; set; }
        public virtual DbSet<Project_GreatPersonPoints> Project_GreatPersonPoints { get; set; }
        public virtual DbSet<Project_ResourceCosts> Project_ResourceCosts { get; set; }
        public virtual DbSet<Project_YieldConversions> Project_YieldConversions { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Projects_XP1> Projects_XP1 { get; set; }
        public virtual DbSet<Projects_XP2> Projects_XP2 { get; set; }
        public virtual DbSet<ProposalBlockers> ProposalBlockers { get; set; }
        public virtual DbSet<ProposalTypes> ProposalTypes { get; set; }
        public virtual DbSet<PseudoYields> PseudoYields { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<RandomAgendaCivicTags> RandomAgendaCivicTags { get; set; }
        public virtual DbSet<RandomAgendaEraTags> RandomAgendaEraTags { get; set; }
        public virtual DbSet<RandomAgendas> RandomAgendas { get; set; }
        public virtual DbSet<RandomAgendasForCivic> RandomAgendasForCivic { get; set; }
        public virtual DbSet<RandomAgendasInEra> RandomAgendasInEra { get; set; }
        public virtual DbSet<RandomAgendas_XP2> RandomAgendas_XP2 { get; set; }
        public virtual DbSet<RandomEvent_Damages> RandomEvent_Damages { get; set; }
        public virtual DbSet<RandomEvent_Frequencies> RandomEvent_Frequencies { get; set; }
        public virtual DbSet<RandomEvent_PillagedImprovements> RandomEvent_PillagedImprovements { get; set; }
        public virtual DbSet<RandomEvent_Terrains> RandomEvent_Terrains { get; set; }
        public virtual DbSet<RandomEvent_Yields> RandomEvent_Yields { get; set; }
        public virtual DbSet<RandomEvents> RandomEvents { get; set; }
        public virtual DbSet<RealismSettings> RealismSettings { get; set; }
        public virtual DbSet<Religions> Religions { get; set; }
        public virtual DbSet<RequirementArguments> RequirementArguments { get; set; }
        public virtual DbSet<RequirementSetRequirements> RequirementSetRequirements { get; set; }
        public virtual DbSet<RequirementSets> RequirementSets { get; set; }
        public virtual DbSet<RequirementStrings> RequirementStrings { get; set; }
        public virtual DbSet<Requirements> Requirements { get; set; }
        public virtual DbSet<ResolutionEffects> ResolutionEffects { get; set; }
        public virtual DbSet<Resolutions> Resolutions { get; set; }
        public virtual DbSet<Resource_Consumption> Resource_Consumption { get; set; }
        public virtual DbSet<Resource_Distribution> Resource_Distribution { get; set; }
        public virtual DbSet<Resource_Harvests> Resource_Harvests { get; set; }
        public virtual DbSet<Resource_SeaLuxuries> Resource_SeaLuxuries { get; set; }
        public virtual DbSet<Resource_SeaStrategics> Resource_SeaStrategics { get; set; }
        public virtual DbSet<Resource_TradeRouteYields> Resource_TradeRouteYields { get; set; }
        public virtual DbSet<Resource_ValidFeatures> Resource_ValidFeatures { get; set; }
        public virtual DbSet<Resource_ValidTerrains> Resource_ValidTerrains { get; set; }
        public virtual DbSet<Resource_YieldChanges> Resource_YieldChanges { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<Route_ResourceCosts> Route_ResourceCosts { get; set; }
        public virtual DbSet<Route_ValidBuildUnits> Route_ValidBuildUnits { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<Routes_XP2> Routes_XP2 { get; set; }
        public virtual DbSet<SavingTypes> SavingTypes { get; set; }
        public virtual DbSet<ScoringCategories> ScoringCategories { get; set; }
        public virtual DbSet<ScoringLineItems> ScoringLineItems { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<SettlementPreferences> SettlementPreferences { get; set; }
        public virtual DbSet<ShapeDefinitions> ShapeDefinitions { get; set; }
        public virtual DbSet<StartBiasFeatures> StartBiasFeatures { get; set; }
        public virtual DbSet<StartBiasResources> StartBiasResources { get; set; }
        public virtual DbSet<StartBiasRivers> StartBiasRivers { get; set; }
        public virtual DbSet<StartBiasTerrains> StartBiasTerrains { get; set; }
        public virtual DbSet<StartEras> StartEras { get; set; }
        public virtual DbSet<StartEras_XP2> StartEras_XP2 { get; set; }
        public virtual DbSet<StartingBoostedCivics> StartingBoostedCivics { get; set; }
        public virtual DbSet<StartingBoostedTechnologies> StartingBoostedTechnologies { get; set; }
        public virtual DbSet<StartingBuildings> StartingBuildings { get; set; }
        public virtual DbSet<StartingCivics> StartingCivics { get; set; }
        public virtual DbSet<StartingGovernments> StartingGovernments { get; set; }
        public virtual DbSet<Strategies> Strategies { get; set; }
        public virtual DbSet<StrategyConditions> StrategyConditions { get; set; }
        public virtual DbSet<Strategy_Priorities> Strategy_Priorities { get; set; }
        public virtual DbSet<Strategy_YieldPriorities> Strategy_YieldPriorities { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<TargetTypes> TargetTypes { get; set; }
        public virtual DbSet<Technologies> Technologies { get; set; }
        public virtual DbSet<Technologies_XP2> Technologies_XP2 { get; set; }
        public virtual DbSet<TechnologyModifiers> TechnologyModifiers { get; set; }
        public virtual DbSet<TechnologyPrereqs> TechnologyPrereqs { get; set; }
        public virtual DbSet<TechnologyQuotes> TechnologyQuotes { get; set; }
        public virtual DbSet<TechnologyRandomCosts> TechnologyRandomCosts { get; set; }
        public virtual DbSet<TerrainClass_Terrains> TerrainClass_Terrains { get; set; }
        public virtual DbSet<TerrainClasses> TerrainClasses { get; set; }
        public virtual DbSet<Terrain_YieldChanges> Terrain_YieldChanges { get; set; }
        public virtual DbSet<Terrains> Terrains { get; set; }
        public virtual DbSet<TraitModifiers> TraitModifiers { get; set; }
        public virtual DbSet<Traits> Traits { get; set; }
        public virtual DbSet<TreeData> TreeData { get; set; }
        public virtual DbSet<TriggeredBehaviorTrees> TriggeredBehaviorTrees { get; set; }
        public virtual DbSet<TurnPhases> TurnPhases { get; set; }
        public virtual DbSet<TurnSegments> TurnSegments { get; set; }
        public virtual DbSet<TurnTimers> TurnTimers { get; set; }
        public virtual DbSet<TypeProperties> TypeProperties { get; set; }
        public virtual DbSet<TypeTags> TypeTags { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<UnitAbilities> UnitAbilities { get; set; }
        public virtual DbSet<UnitAbilityModifiers> UnitAbilityModifiers { get; set; }
        public virtual DbSet<UnitAiInfos> UnitAiInfos { get; set; }
        public virtual DbSet<UnitAiTypes> UnitAiTypes { get; set; }
        public virtual DbSet<UnitCaptures> UnitCaptures { get; set; }
        public virtual DbSet<UnitCommands> UnitCommands { get; set; }
        public virtual DbSet<UnitFormationClasses> UnitFormationClasses { get; set; }
        public virtual DbSet<UnitNames> UnitNames { get; set; }
        public virtual DbSet<UnitOperations> UnitOperations { get; set; }
        public virtual DbSet<UnitPromotionClasses> UnitPromotionClasses { get; set; }
        public virtual DbSet<UnitPromotionModifiers> UnitPromotionModifiers { get; set; }
        public virtual DbSet<UnitPromotionPrereqs> UnitPromotionPrereqs { get; set; }
        public virtual DbSet<UnitPromotions> UnitPromotions { get; set; }
        public virtual DbSet<UnitReplaces> UnitReplaces { get; set; }
        public virtual DbSet<UnitUpgrades> UnitUpgrades { get; set; }
        public virtual DbSet<Unit_BuildingPrereqs> Unit_BuildingPrereqs { get; set; }
        public virtual DbSet<Unit_RebellionTags> Unit_RebellionTags { get; set; }
        public virtual DbSet<Unit_RockbandResults_XP2> Unit_RockbandResults_XP2 { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Units_XP2> Units_XP2 { get; set; }
        public virtual DbSet<Victories> Victories { get; set; }
        public virtual DbSet<Visibilities> Visibilities { get; set; }
        public virtual DbSet<Visibilities_XP2> Visibilities_XP2 { get; set; }
        public virtual DbSet<Vocabularies> Vocabularies { get; set; }
        public virtual DbSet<VotingBlockers> VotingBlockers { get; set; }
        public virtual DbSet<WMDs> WMDs { get; set; }
        public virtual DbSet<Wars> Wars { get; set; }
        public virtual DbSet<Yields> Yields { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Model Auto-Created
            //modelBuilder.Entity<Adjacency_YieldChanges>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Adjacency_YieldChanges)
            //    ;//.Map(m => m.ToTable("ExcludedAdjacencies").MapLeftKey("YieldChangeId").MapRightKey("TraitType"));


            //modelBuilder.Entity<Adjacency_YieldChanges>()
            //    .HasMany(e => e.Improvements1)
            //    .WithMany(e => e.Adjacency_YieldChanges1)
            //    ;//.Map(m => m.ToTable("Improvement_Adjacencies").MapLeftKey("YieldChangeId").MapRightKey("ImprovementType"));


            modelBuilder.Entity<Agendas>()
                .HasOptional(e => e.RandomAgendas)
                .WithRequired(e => e.Agendas);

            modelBuilder.Entity<Agendas>()
                .HasOptional(e => e.RandomAgendas_XP2)
                .WithRequired(e => e.Agendas);

            //modelBuilder.Entity<Agendas>()
            //    .HasMany(e => e.Agendas1)
            //    .WithMany(e => e.Agendas2)
            //    ;//.Map(m => m.ToTable("ExclusiveAgendas").MapLeftKey("AgendaTwo").MapRightKey("AgendaOne"));


            modelBuilder.Entity<AgendaTags>()
                .HasMany(e => e.RandomAgendas_XP2)
                .WithRequired(e => e.AgendaTags)
                .HasForeignKey(e => e.AgendaTag)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<AgendaTags>()
            //    .HasMany(e => e.Civics)
            //    .WithMany(e => e.AgendaTags)
            //    ;//.Map(m => m.ToTable("RandomAgendaCivicTags").MapLeftKey("AgendaTag").MapRightKey("CivicType"));


            //modelBuilder.Entity<AgendaTags>()
            //    .HasMany(e => e.Eras)
            //    .WithMany(e => e.AgendaTags)
            //    ;//.Map(m => m.ToTable("RandomAgendaEraTags").MapLeftKey("AgendaTag").MapRightKey("EraType"));


            modelBuilder.Entity<AiEvents>()
                .HasMany(e => e.TriggeredBehaviorTrees)
                .WithRequired(e => e.AiEvents)
                .HasForeignKey(e => e.AIEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiListTypes>()
                .HasMany(e => e.AiFavoredItems)
                .WithRequired(e => e.AiListTypes);

            //modelBuilder.Entity<AiListTypes>()
            //    .HasMany(e => e.AiLists)
            //    .WithRequired(e => e.AiListTypes)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<AiListTypes>()
            //    .HasMany(e => e.Strategies)
            //    .WithMany(e => e.AiListTypes)
            //    ;//.Map(m => m.ToTable("Strategy_Priorities").MapLeftKey("ListType").MapRightKey("StrategyType"));


            modelBuilder.Entity<AiOperationDefs>()
                .HasMany(e => e.AiOperationTeams)
                .WithRequired(e => e.AiOperationDefs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiOperationDefs>()
                .HasMany(e => e.AllowedOperations)
                .WithRequired(e => e.AiOperationDefs)
                .HasForeignKey(e => e.OperationDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiOperationLists>()
                .HasMany(e => e.Agendas)
                .WithOptional(e => e.AiOperationLists)
                .HasForeignKey(e => e.OperationList);

            modelBuilder.Entity<AiOperationLists>()
                .HasMany(e => e.AiOperationLimits)
                .WithRequired(e => e.AiOperationLists)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiOperationLists>()
                .HasMany(e => e.AiOperationLists1)
                .WithOptional(e => e.AiOperationLists2)
                .HasForeignKey(e => e.BaseList);

            modelBuilder.Entity<AiOperationLists>()
                .HasMany(e => e.AllowedOperations)
                .WithRequired(e => e.AiOperationLists)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiOperationLists>()
                .HasMany(e => e.Leaders)
                .WithOptional(e => e.AiOperationLists)
                .HasForeignKey(e => e.OperationList);

            modelBuilder.Entity<AiOperationTypes>()
                .HasMany(e => e.AiOperationLimits)
                .WithRequired(e => e.AiOperationTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiTeams>()
                .HasMany(e => e.AiOperationTeams)
                .WithRequired(e => e.AiTeams)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AiTeams>()
                .HasMany(e => e.OpTeamRequirements)
                .WithRequired(e => e.AiTeams)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alliances>()
                .HasMany(e => e.AllianceEffects)
                .WithRequired(e => e.Alliances)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarbarianAttackForces>()
                .HasMany(e => e.BarbarianTribeForces)
                .WithRequired(e => e.BarbarianAttackForces)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarbarianTribeNames>()
                .HasMany(e => e.BarbarianTribeForces)
                .WithRequired(e => e.BarbarianTribeNames)
                .HasForeignKey(e => e.SpecificTribeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarbarianTribes>()
                .HasMany(e => e.BarbarianTribeForces)
                .WithRequired(e => e.BarbarianTribes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BarbarianTribes>()
                .HasMany(e => e.BarbarianTribeNames)
                .WithRequired(e => e.BarbarianTribes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BehaviorTrees>()
                .HasMany(e => e.AiOperationDefs)
                .WithOptional(e => e.BehaviorTrees)
                .HasForeignKey(e => e.BehaviorTree);

            modelBuilder.Entity<BehaviorTrees>()
                .HasMany(e => e.BehaviorTreeNodes)
                .WithRequired(e => e.BehaviorTrees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BehaviorTrees>()
                .HasMany(e => e.BoostHandlers)
                .WithOptional(e => e.BehaviorTrees)
                .HasForeignKey(e => e.BehaviorTree);

            modelBuilder.Entity<BehaviorTrees>()
                .HasMany(e => e.TreeData)
                .WithRequired(e => e.BehaviorTrees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BehaviorTrees>()
                .HasMany(e => e.TriggeredBehaviorTrees)
                .WithRequired(e => e.BehaviorTrees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BeliefClasses>()
                .HasMany(e => e.Beliefs)
                .WithRequired(e => e.BeliefClasses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Beliefs>()
                .HasMany(e => e.BeliefModifiers)
                .WithRequired(e => e.Beliefs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoostNames>()
                .HasMany(e => e.BoostHandlers)
                .WithRequired(e => e.BoostNames)
                .HasForeignKey(e => e.TechBoostType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoostNames>()
                .HasMany(e => e.Boosts)
                .WithRequired(e => e.BoostNames)
                .HasForeignKey(e => e.BoostClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_GreatPersonPoints)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_GreatWorks)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_ResourceCosts)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasOptional(e => e.Building_TourismBombs_XP2)
                .WithRequired(e => e.Buildings);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_YieldChanges)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_YieldChangesBonusWithPower)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_YieldDistrictCopies)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Building_YieldsPerEra)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.BuildingModifiers)
                .WithRequired(e => e.Buildings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasOptional(e => e.Buildings_XP2)
                .WithRequired(e => e.Buildings);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.EmergencyScoreSources)
                .WithOptional(e => e.Buildings)
                .HasForeignKey(e => e.FromBuilding);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.GreatPersonIndividuals)
                .WithOptional(e => e.Buildings)
                .HasForeignKey(e => e.ActionRequiresMissingBuildingType);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Project_BuildingCosts)
                .WithRequired(e => e.Buildings)
                .HasForeignKey(e => e.ConsumedBuildingType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Buildings)
                .HasForeignKey(e => e.VisualBuildingType);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Projects_XP2)
                .WithOptional(e => e.Buildings)
                .HasForeignKey(e => e.CreateBuilding);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Projects_XP21)
                .WithOptional(e => e.Buildings1)
                .HasForeignKey(e => e.RequiredBuilding);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.StartingBuildings)
                .WithRequired(e => e.Buildings)
                .HasForeignKey(e => e.Building)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Unit_BuildingPrereqs)
                .WithRequired(e => e.Buildings)
                .HasForeignKey(e => e.PrereqBuilding)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Buildings1)
            //    .WithMany(e => e.Buildings2)
            //    ;//.Map(m => m.ToTable("BuildingPrereqs").MapLeftKey("PrereqBuilding").MapRightKey("Building"));


            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Buildings11)
            //    .WithMany(e => e.Buildings3)
            //    ;//.Map(m => m.ToTable("BuildingReplaces").MapLeftKey("ReplacesBuildingType").MapRightKey("CivUniqueBuildingType"));


            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Buildings12)
            //    .WithMany(e => e.Buildings4)
            //    ;//.Map(m => m.ToTable("MutuallyExclusiveBuildings").MapLeftKey("MutuallyExclusiveBuilding").MapRightKey("Building"));


            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.ObsoleteCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Adjacency_YieldChanges1)
                .WithOptional(e => e.Civics1)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Boosts)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.BoostingCivicType);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Boosts1)
                .WithOptional(e => e.Civics1)
                .HasForeignKey(e => e.CivicType);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.CivicQuotes)
                .WithRequired(e => e.Civics)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.CivicRandomCosts)
                .WithRequired(e => e.Civics)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civics>()
                .HasOptional(e => e.Civics_XP2)
                .WithRequired(e => e.Civics);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.DiplomaticActions)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.InitiatorObsoleteCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.DiplomaticActions1)
                .WithOptional(e => e.Civics1)
                .HasForeignKey(e => e.TargetPrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.DiplomaticActions2)
                .WithOptional(e => e.Civics2)
                .HasForeignKey(e => e.InitiatorPrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Districts)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Features)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.AddCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Governments)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Improvement_BonusYieldChanges)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Improvement_Tourism)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Improvement_ValidTerrains)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Improvements)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Policies)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasOptional(e => e.RandomAgendasForCivic)
                .WithRequired(e => e.Civics);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Resources)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.UnitCommands)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.UnitOperations)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Civics)
                .HasForeignKey(e => e.PrereqCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Units1)
                .WithOptional(e => e.Civics1)
                .HasForeignKey(e => e.MandatoryObsoleteCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Units2)
                .WithOptional(e => e.Civics2)
                .HasForeignKey(e => e.ObsoleteCivic);

            modelBuilder.Entity<Civics>()
                .HasMany(e => e.Units3)
                .WithOptional(e => e.Civics3)
                .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Civics1)
            //    .WithMany(e => e.Civics2)
            //    ;//.Map(m => m.ToTable("CivicPrereqs").MapLeftKey("PrereqCivic").MapRightKey("Civic"));


            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Eras1)
            //    .WithMany(e => e.Civics1)
            //    ;//.Map(m => m.ToTable("StartingBoostedCivics").MapLeftKey("Civic").MapRightKey("Era"));


            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Eras2)
            //    .WithMany(e => e.Civics2)
            //    ;//.Map(m => m.ToTable("StartingCivics").MapLeftKey("Civic").MapRightKey("Era"));


            modelBuilder.Entity<CivilizationLevels>()
                .HasMany(e => e.Civilizations)
                .WithRequired(e => e.CivilizationLevels)
                .HasForeignKey(e => e.StartingCivilizationLevelType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CivilizationLevels>()
                .HasMany(e => e.DiplomaticStartStates)
                .WithRequired(e => e.CivilizationLevels)
                .HasForeignKey(e => e.OpponentCivLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CivilizationLevels>()
                .HasMany(e => e.DiplomaticStartStates1)
                .WithRequired(e => e.CivilizationLevels1)
                .HasForeignKey(e => e.PlayerCivLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CivilizationLevels>()
                .HasMany(e => e.DiplomaticTriggeredTransitions)
                .WithRequired(e => e.CivilizationLevels)
                .HasForeignKey(e => e.OpponentCivilizationLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CivilizationLevels>()
                .HasMany(e => e.DiplomaticTriggeredTransitions1)
                .WithRequired(e => e.CivilizationLevels1)
                .HasForeignKey(e => e.CivilizationLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.CivilizationCitizenNames)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.CivilizationInfo)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.CivilizationLeaders)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.FavoredReligions)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.StartBiasFeatures)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.StartBiasResources)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Civilizations>()
                .HasOptional(e => e.StartBiasRivers)
                .WithRequired(e => e.Civilizations);

            modelBuilder.Entity<Civilizations>()
                .HasMany(e => e.StartBiasTerrains)
                .WithRequired(e => e.Civilizations)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Civilizations)
            //    ;//.Map(m => m.ToTable("CivilizationTraits").MapLeftKey("CivilizationType").MapRightKey("TraitType"));


            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.Civilizations1)
            //    .WithMany(e => e.Civilizations2)
            //    ;//.Map(m => m.ToTable("DuplicateCivilizations").MapLeftKey("OtherCivilizationType").MapRightKey("CivilizationType"));


            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedDeserts)
            //    .WithMany(e => e.Civilizations)
            //    ;//.Map(m => m.ToTable("NamedDesertCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedDesertType"));


            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedMountains)
            //    .WithMany(e => e.Civilizations)
            //    ;//.Map(m => m.ToTable("NamedMountainCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedMountainType"));


            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedRivers)
            //    .WithMany(e => e.Civilizations)
            //    ;//.Map(m => m.ToTable("NamedRiverCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedRiverType"));


            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedVolcanoes)
            //    .WithMany(e => e.Civilizations)
            //    ;//.Map(m => m.ToTable("NamedVolcanoCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedVolcanoType"));


            modelBuilder.Entity<CommemorationTypes>()
                .HasMany(e => e.CommemorationModifiers)
                .WithRequired(e => e.CommemorationTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommemorationTypes>()
                .HasMany(e => e.ComplimentModifiers)
                .WithRequired(e => e.CommemorationTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommemorationTypes>()
                .HasMany(e => e.DiplomaticActions_XP1)
                .WithOptional(e => e.CommemorationTypes)
                .HasForeignKey(e => e.RequiresGoldenAgeCommemorationType);

            modelBuilder.Entity<DataTypes>()
                .HasMany(e => e.NodeDataDefinitions)
                .WithRequired(e => e.DataTypes)
                .HasForeignKey(e => e.DataType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Difficulties_Gameplay>()
                .HasMany(e => e.AiFavoredItems)
                .WithOptional(e => e.Difficulties)
                .HasForeignKey(e => e.MaxDifficulty);

            modelBuilder.Entity<Difficulties_Gameplay>()
                .HasMany(e => e.AiFavoredItems1)
                .WithOptional(e => e.Difficulties1)
                .HasForeignKey(e => e.MinDifficulty);

            //modelBuilder.Entity<Difficulties_Gameplay>()
            //    .HasMany(e => e.AiLists)
            //    .WithOptional(e => e.Difficulties)
            //    .HasForeignKey(e => e.MinDifficulty);

            //modelBuilder.Entity<Difficulties_Gameplay>()
            //    .HasMany(e => e.AiLists1)
            //    .WithOptional(e => e.Difficulties1)
            //    .HasForeignKey(e => e.MaxDifficulty);

            modelBuilder.Entity<Difficulties_Gameplay>()
                .HasMany(e => e.BarbarianAttackForces)
                .WithOptional(e => e.Difficulties)
                .HasForeignKey(e => e.MaxTargetDifficulty);

            modelBuilder.Entity<Difficulties_Gameplay>()
                .HasMany(e => e.BarbarianAttackForces1)
                .WithOptional(e => e.Difficulties1)
                .HasForeignKey(e => e.MinTargetDifficulty);

            modelBuilder.Entity<Difficulties_Gameplay>()
                .HasMany(e => e.MajorStartingUnits)
                .WithRequired(e => e.Difficulties)
                .HasForeignKey(e => e.MinDifficulty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticActions>()
                .HasOptional(e => e.DiplomaticActions_XP1)
                .WithRequired(e => e.DiplomaticActions);

            modelBuilder.Entity<DiplomaticActions>()
                .HasOptional(e => e.DiplomaticActions_XP2)
                .WithRequired(e => e.DiplomaticActions);

            modelBuilder.Entity<DiplomaticActions>()
                .HasMany(e => e.DiplomaticStateActions)
                .WithRequired(e => e.DiplomaticActions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticStates>()
                .HasMany(e => e.DiplomaticStartStates)
                .WithRequired(e => e.DiplomaticStates)
                .HasForeignKey(e => e.DiplomaticStateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticStates>()
                .HasMany(e => e.DiplomaticStateActions)
                .WithOptional(e => e.DiplomaticStates)
                .HasForeignKey(e => e.TransitionToState);

            modelBuilder.Entity<DiplomaticStates>()
                .HasMany(e => e.DiplomaticStateActions1)
                .WithRequired(e => e.DiplomaticStates1)
                .HasForeignKey(e => e.StateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticStates>()
                .HasMany(e => e.DiplomaticStateTransitions)
                .WithRequired(e => e.DiplomaticStates)
                .HasForeignKey(e => e.BaseState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticStates>()
                .HasMany(e => e.DiplomaticStateTransitions1)
                .WithRequired(e => e.DiplomaticStates1)
                .HasForeignKey(e => e.TransitionState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticStates>()
                .HasMany(e => e.DiplomaticTriggeredTransitions)
                .WithRequired(e => e.DiplomaticStates)
                .HasForeignKey(e => e.TransitionState)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticTriggers)
            //    .WithMany(e => e.DiplomaticStates)
            //    ;//.Map(m => m.ToTable("DiplomaticTriggers_RequiredStates").MapLeftKey("RequiredState").MapRightKey("TriggerType"));


            modelBuilder.Entity<DiplomaticTriggers>()
                .HasMany(e => e.DiplomaticTriggeredTransitions)
                .WithRequired(e => e.DiplomaticTriggers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiplomaticVisibilitySources>()
                .HasOptional(e => e.DiplomaticVisibilitySources_XP1)
                .WithRequired(e => e.DiplomaticVisibilitySources);

            modelBuilder.Entity<Discussions>()
                .HasMany(e => e.CongressAiChanges)
                .WithRequired(e => e.Discussions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.AdjacentDistrict);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.AppealHousingChanges)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.PrereqDistrict);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Buildings1)
                .WithOptional(e => e.Districts1)
                .HasForeignKey(e => e.AdjacentDistrict);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.District_BuildChargeProductions)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.District_CitizenGreatPersonPoints)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.District_CitizenYieldChanges)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.District_GreatPersonPoints)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.District_TradeRouteYields)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            //Come back to this -Z
            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Districts_XP2);
            //.WithRequired(e => e.Districts)
            //.HasForeignKey(e => e.DistrictType)
            //.WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.EmergencyScoreSources)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.FromDistrict);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.GreatPersonClasses)
                .WithRequired(e => e.Districts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.GreatPersonIndividuals)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.ActionRequiresCompletedDistrictType);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.MajorStartingUnits)
                .WithRequired(e => e.Districts)
                .HasForeignKey(e => e.District)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.PrereqDistrict);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.StartingBuildings)
                .WithRequired(e => e.Districts)
                .HasForeignKey(e => e.District)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.UnitOperations)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.TargetDistrict);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Districts)
                .HasForeignKey(e => e.PrereqDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Adjacency_YieldChanges1)
            //    .WithMany(e => e.Districts1)
            //    ;//.Map(m => m.ToTable("District_Adjacencies").MapLeftKey("DistrictType").MapRightKey("YieldChangeId"));


            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Terrains)
            //    .WithMany(e => e.Districts)
            //    ;//.Map(m => m.ToTable("District_ValidTerrains").MapLeftKey("DistrictType").MapRightKey("TerrainType"));


            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Districts1)
            //    .WithOptional(e => e.Districts2);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Districts11)
            //    .WithMany(e => e.Districts3)
            //    ;//.Map(m => m.ToTable("MutuallyExclusiveDistricts").MapLeftKey("MutuallyExclusiveDistrict").MapRightKey("District"));


            modelBuilder.Entity<Emergencies_XP2>()
                .HasMany(e => e.EmergencyScoreSources)
                .WithRequired(e => e.Emergencies_XP2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmergencyAlliances>()
                .HasOptional(e => e.Emergencies_XP2)
                .WithRequired(e => e.EmergencyAlliances);

            modelBuilder.Entity<EmergencyAlliances>()
                .HasMany(e => e.EmergencyBuffs)
                .WithRequired(e => e.EmergencyAlliances)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmergencyAlliances>()
                .HasMany(e => e.EmergencyRewards)
                .WithRequired(e => e.EmergencyAlliances)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmergencyGoalTexts>()
                .HasMany(e => e.EmergencyAlliances)
                .WithRequired(e => e.EmergencyGoalTexts)
                .HasForeignKey(e => e.GoalText)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmergencyTexts>()
                .HasMany(e => e.EmergencyAlliances)
                .WithRequired(e => e.EmergencyTexts)
                .HasForeignKey(e => e.EmergencyText)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.BonusMinorStartingUnits)
                .WithRequired(e => e.Eras)
                .HasForeignKey(e => e.Era)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Civics)
                .WithRequired(e => e.Eras)
                .HasForeignKey(e => e.EraType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.CommemorationTypes)
                .WithOptional(e => e.Eras)
                .HasForeignKey(e => e.MaximumGameEra);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.CommemorationTypes1)
                .WithOptional(e => e.Eras1)
                .HasForeignKey(e => e.MinimumGameEra);

            modelBuilder.Entity<Eras>()
                .HasOptional(e => e.Eras_XP1)
                .WithRequired(e => e.Eras);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.GreatPersonIndividuals)
                .WithRequired(e => e.Eras)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.MajorStartingUnits)
                .WithRequired(e => e.Eras)
                .HasForeignKey(e => e.Era)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Moments)
                .WithOptional(e => e.Eras)
                .HasForeignKey(e => e.ObsoleteEra);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Moments1)
                .WithOptional(e => e.Eras1)
                .HasForeignKey(e => e.MaximumGameEra);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Moments2)
                .WithOptional(e => e.Eras2)
                .HasForeignKey(e => e.MinimumGameEra);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Policies_XP1)
                .WithOptional(e => e.Eras)
                .HasForeignKey(e => e.MaximumGameEra);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Policies_XP11)
                .WithOptional(e => e.Eras1)
                .HasForeignKey(e => e.MinimumGameEra);

            modelBuilder.Entity<Eras>()
                .HasOptional(e => e.RandomAgendasInEra)
                .WithRequired(e => e.Eras);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Routes)
                .WithOptional(e => e.Eras)
                .HasForeignKey(e => e.PrereqEra);

            modelBuilder.Entity<Eras>()
                .HasOptional(e => e.StartEras)
                .WithRequired(e => e.Eras);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.StartingBuildings)
                .WithRequired(e => e.Eras)
                .HasForeignKey(e => e.Era)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.StartingGovernments)
                .WithRequired(e => e.Eras)
                .HasForeignKey(e => e.Era)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eras>()
                .HasMany(e => e.Technologies)
                .WithRequired(e => e.Eras)
                .HasForeignKey(e => e.EraType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithOptional(e => e.Features)
                .HasForeignKey(e => e.AdjacentFeature);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Feature_AdjacentYields)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasOptional(e => e.Feature_Floodplains)
                .WithRequired(e => e.Features);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Feature_Removes)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.Feature_YieldChanges)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasOptional(e => e.Features_XP2)
                .WithRequired(e => e.Features);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.GreatPersonIndividuals)
                .WithOptional(e => e.Features)
                .HasForeignKey(e => e.ActionRequiresOnOrAdjacentFeatureType);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.RandomEvent_Yields)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.RandomEvents)
                .WithOptional(e => e.Features)
                .HasForeignKey(e => e.NaturalWonder);

            modelBuilder.Entity<Features>()
                .HasMany(e => e.StartBiasFeatures)
                .WithRequired(e => e.Features)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Buildings)
            //    .WithMany(e => e.Features)
            //    ;//.Map(m => m.ToTable("Building_RequiredFeatures").MapLeftKey("FeatureType").MapRightKey("BuildingType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Buildings1)
            //    .WithMany(e => e.Features1)
            //    ;//.Map(m => m.ToTable("Building_ValidFeatures").MapLeftKey("FeatureType").MapRightKey("BuildingType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Districts)
            //    .WithMany(e => e.Features)
            //    ;//.Map(m => m.ToTable("District_RequiredFeatures").MapLeftKey("FeatureType").MapRightKey("DistrictType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Features1)
            //    .WithMany(e => e.Features2)
            //    ;//.Map(m => m.ToTable("Feature_AdjacentFeatures").MapLeftKey("FeatureTypeAdjacent").MapRightKey("FeatureType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Features11)
            //    .WithMany(e => e.Features3)
            //    ;//.Map(m => m.ToTable("Feature_NotNearFeatures").MapLeftKey("FeatureTypeAvoid").MapRightKey("FeatureType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Improvements)
            //    .WithMany(e => e.Features)
            //    ;//.Map(m => m.ToTable("Improvement_InvalidAdjacentFeatures").MapLeftKey("FeatureType").MapRightKey("ImprovementType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Improvements1)
            //    .WithMany(e => e.Features1)
            //    ;//.Map(m => m.ToTable("Improvement_ValidFeatures").MapLeftKey("FeatureType").MapRightKey("ImprovementType"));


            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Resources)
            //    .WithMany(e => e.Features)
            //    ;//.Map(m => m.ToTable("Resource_ValidFeatures").MapLeftKey("FeatureType").MapRightKey("ResourceType"));


            modelBuilder.Entity<Flavors>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Flavors)
                .HasForeignKey(e => e.Flavor);

            modelBuilder.Entity<GameCapabilities>()
                .HasMany(e => e.GameCapabilityDependencies)
                .WithOptional(e => e.GameCapabilities)
                .HasForeignKey(e => e.DependsOnCapability);

            modelBuilder.Entity<GameCapabilities>()
                .HasMany(e => e.GameCapabilityDependencies1)
                .WithOptional(e => e.GameCapabilities1)
                .HasForeignKey(e => e.GameCapability);

            modelBuilder.Entity<GameEffects>()
                .HasMany(e => e.GameEffectArguments)
                .WithRequired(e => e.GameEffects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GameSpeed_Scalings>()
                .HasMany(e => e.GameSpeed_Durations)
                .WithRequired(e => e.GameSpeed_Scalings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GameSpeeds>()
                .HasMany(e => e.GameSpeed_Scalings)
                .WithRequired(e => e.GameSpeeds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GameSpeeds>()
                .HasMany(e => e.GameSpeed_Turns)
                .WithRequired(e => e.GameSpeeds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GoodyHuts>()
                .HasMany(e => e.GoodyHutSubTypes)
                .WithRequired(e => e.GoodyHuts)
                .HasForeignKey(e => e.GoodyHut)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GoodyHutSubTypes>()
                .HasOptional(e => e.GoodyHutSubTypes_XP2)
                .WithRequired(e => e.GoodyHutSubTypes);

            modelBuilder.Entity<GovernmentBonusNames>()
                .HasMany(e => e.Governments)
                .WithRequired(e => e.GovernmentBonusNames)
                .HasForeignKey(e => e.BonusType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Governments>()
                .HasMany(e => e.Government_SlotCounts)
                .WithRequired(e => e.Governments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Governments>()
                .HasMany(e => e.GovernmentModifiers)
                .WithRequired(e => e.Governments)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Governments>()
                .HasOptional(e => e.Governments_XP2)
                .WithRequired(e => e.Governments);

            modelBuilder.Entity<Governments>()
                .HasMany(e => e.StartingGovernments)
                .WithRequired(e => e.Governments)
                .HasForeignKey(e => e.Government)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GovernmentSlots>()
                .HasMany(e => e.Government_SlotCounts)
                .WithRequired(e => e.GovernmentSlots)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GovernmentSlots>()
                .HasMany(e => e.Policies)
                .WithRequired(e => e.GovernmentSlots)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GovernmentTiers>()
                .HasMany(e => e.Boosts)
                .WithOptional(e => e.GovernmentTiers)
                .HasForeignKey(e => e.GovernmentTierType);

            modelBuilder.Entity<GovernmentTiers>()
                .HasMany(e => e.Governments)
                .WithOptional(e => e.GovernmentTiers)
                .HasForeignKey(e => e.Tier);

            modelBuilder.Entity<GovernorPromotions>()
                .HasMany(e => e.GovernorPromotionModifiers)
                .WithRequired(e => e.GovernorPromotions)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<GovernorPromotions>()
            //    .HasMany(e => e.GovernorPromotions1)
            //    .WithMany(e => e.GovernorPromotions2)
            //    ;//.Map(m => m.ToTable("GovernorPromotionPrereqs").MapLeftKey("PrereqGovernorPromotion").MapRightKey("GovernorPromotionType"));


            //modelBuilder.Entity<GovernorPromotions>()
            //    .HasMany(e => e.Governors)
            //    .WithMany(e => e.GovernorPromotions)
            //    ;//.Map(m => m.ToTable("GovernorPromotionSets").MapLeftKey("GovernorPromotion").MapRightKey("GovernorType"));


            modelBuilder.Entity<Governors>()
                .HasMany(e => e.GovernorModifiers)
                .WithRequired(e => e.Governors)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Governors>()
                .HasOptional(e => e.Governors_XP2)
                .WithRequired(e => e.Governors);

            //modelBuilder.Entity<Governors>()
            //    .HasMany(e => e.Governors1)
            //    .WithMany(e => e.Governors2)
            //    ;//.Map(m => m.ToTable("GovernorReplaces").MapLeftKey("ReplacesGovernorType").MapRightKey("UniqueGovernorType"));


            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.Building_GreatPersonPoints)
                .WithRequired(e => e.GreatPersonClasses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.District_CitizenGreatPersonPoints)
                .WithRequired(e => e.GreatPersonClasses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.District_GreatPersonPoints)
                .WithRequired(e => e.GreatPersonClasses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.EmergencyScoreSources)
                .WithOptional(e => e.GreatPersonClasses)
                .HasForeignKey(e => e.FromGreatPerson);

            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.GreatPersonIndividuals)
                .WithRequired(e => e.GreatPersonClasses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.Map_GreatPersonClasses)
                .WithRequired(e => e.GreatPersonClasses)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.ObsoletePolicies)
            //    .WithOptional(e => e.GreatPersonClasses)
            //    .HasForeignKey(e => e.RequiresAvailableGreatPersonClass);

            modelBuilder.Entity<GreatPersonClasses>()
                .HasMany(e => e.Project_GreatPersonPoints)
                .WithRequired(e => e.GreatPersonClasses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatPersonIndividuals>()
                .HasMany(e => e.GreatPersonIndividualActionModifiers)
                .WithRequired(e => e.GreatPersonIndividuals)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatPersonIndividuals>()
                .HasMany(e => e.GreatPersonIndividualBirthModifiers)
                .WithRequired(e => e.GreatPersonIndividuals)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatWorkObjectTypes>()
                .HasMany(e => e.GreatPersonIndividuals)
                .WithOptional(e => e.GreatWorkObjectTypes)
                .HasForeignKey(e => e.ActionRequiresCityGreatWorkObjectType);

            modelBuilder.Entity<GreatWorkObjectTypes>()
                .HasMany(e => e.GreatWorks)
                .WithRequired(e => e.GreatWorkObjectTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatWorks>()
                .HasMany(e => e.GreatWork_YieldChanges)
                .WithRequired(e => e.GreatWorks)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GreatWorkSlotTypes>()
                .HasMany(e => e.Building_GreatWorks)
                .WithRequired(e => e.GreatWorkSlotTypes)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<GreatWorkSlotTypes>()
            //    .HasMany(e => e.GreatWorkObjectTypes)
            //    .WithMany(e => e.GreatWorkSlotTypes)
            //    ;//.Map(m => m.ToTable("GreatWork_ValidSubTypes").MapLeftKey("GreatWorkSlotType").MapRightKey("GreatWorkObjectType"));


            modelBuilder.Entity<Happinesses>()
                .HasOptional(e => e.Happinesses_XP1)
                .WithRequired(e => e.Happinesses);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithOptional(e => e.Improvements)
                .HasForeignKey(e => e.AdjacentImprovement);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Improvements)
                .HasForeignKey(e => e.AdjacentImprovement);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.GoodyHuts)
                .WithRequired(e => e.Improvements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.Improvement_BonusYieldChanges)
                .WithRequired(e => e.Improvements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Improvements>()
                .HasOptional(e => e.Improvement_Tourism)
                .WithRequired(e => e.Improvements);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.Improvement_ValidResources)
                .WithRequired(e => e.Improvements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.Improvement_ValidTerrains)
                .WithRequired(e => e.Improvements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.Improvement_YieldChanges)
                .WithRequired(e => e.Improvements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Improvements>()
                .HasMany(e => e.ImprovementModifiers)
                .WithRequired(e => e.Improvements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Improvements>()
                .HasOptional(e => e.Improvements_XP2)
                .WithRequired(e => e.Improvements);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Resources)
            //    .WithMany(e => e.Improvements)
            //    ;//.Map(m => m.ToTable("Improvement_ValidAdjacentResources").MapLeftKey("ImprovementType").MapRightKey("ResourceType"));


            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.RandomEvents)
            //    .WithMany(e => e.Improvements)
            //    ;//.Map(m => m.ToTable("RandomEvent_PillagedImprovements").MapLeftKey("ImprovementType").MapRightKey("RandomEventType"));


            modelBuilder.Entity<Kinds>()
                .HasMany(e => e.Types)
                .WithRequired(e => e.Kinds)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leaders>()
                .HasMany(e => e.AgendaPreferredLeaders)
                .WithRequired(e => e.Leaders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leaders>()
                .HasMany(e => e.CivilizationLeaders)
                .WithRequired(e => e.Leaders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leaders>()
                .HasMany(e => e.FavoredReligions)
                .WithRequired(e => e.Leaders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leaders>()
                .HasMany(e => e.LeaderInfo)
                .WithRequired(e => e.Leaders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leaders>()
                .HasMany(e => e.LeaderQuotes)
                .WithRequired(e => e.Leaders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Leaders>()
                .HasMany(e => e.Leaders1)
                .WithOptional(e => e.Leaders2)
                .HasForeignKey(e => e.InheritFrom);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Leaders11)
            //    .WithMany(e => e.Leaders3)
            //    ;//.Map(m => m.ToTable("DuplicateLeaders").MapLeftKey("OtherLeaderType").MapRightKey("LeaderType"));


            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Agendas)
            //    .WithMany(e => e.Leaders)
            //    ;//.Map(m => m.ToTable("HistoricalAgendas").MapLeftKey("LeaderType").MapRightKey("AgendaType"));


            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Leaders)
            //    ;//.Map(m => m.ToTable("LeaderTraits").MapLeftKey("LeaderType").MapRightKey("TraitType"));


            modelBuilder.Entity<Maps>()
                .HasMany(e => e.Map_GreatPersonClasses)

                .WithRequired(e => e.Maps)

                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Maps>()
                .HasOptional(e => e.Maps_XP2)

                .WithRequired(e => e.Maps);


            modelBuilder.Entity<Modifiers>()
                .HasMany(e => e.AllianceEffects)
                .WithRequired(e => e.Modifiers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modifiers>()
                .HasMany(e => e.EmergencyBuffs)
                .WithRequired(e => e.Modifiers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modifiers>()
                .HasMany(e => e.EmergencyRewards)
                .WithRequired(e => e.Modifiers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modifiers>()
                .HasMany(e => e.ModifierArguments)
                .WithRequired(e => e.Modifiers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modifiers>()
                .HasMany(e => e.ModifierStrings)
                .WithRequired(e => e.Modifiers)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.Civics)
            //    .WithMany(e => e.Modifiers)
            //    ;//.Map(m => m.ToTable("CivicModifiers").MapLeftKey("ModifierId").MapRightKey("CivicType"));


            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.Districts)
            //    .WithMany(e => e.Modifiers)
            //    ;//.Map(m => m.ToTable("DistrictModifiers").MapLeftKey("ModifierId").MapRightKey("DistrictType"));


            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Modifiers)
            //    ;//.Map(m => m.ToTable("TraitModifiers").MapLeftKey("ModifierId").MapRightKey("TraitType"));


            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.UnitAbilities)
            //    .WithMany(e => e.Modifiers)
            //    ;//.Map(m => m.ToTable("UnitAbilityModifiers").MapLeftKey("ModifierId").MapRightKey("UnitAbilityType"));


            modelBuilder.Entity<MomentDataTypes>()
                .HasMany(e => e.MomentIllustrations)
                .WithRequired(e => e.MomentDataTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MomentIllustrationTypes>()
                .HasMany(e => e.MomentIllustrations)
                .WithRequired(e => e.MomentIllustrationTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NodeDefinitions>()
                .HasMany(e => e.BehaviorTreeNodes)
                .WithRequired(e => e.NodeDefinitions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NodeDefinitions>()
                .HasMany(e => e.NodeDataDefinitions)
                .WithRequired(e => e.NodeDefinitions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Policies>()
                .HasMany(e => e.Governments)
                .WithOptional(e => e.Policies)
                .HasForeignKey(e => e.PolicyToUnlock);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.ObsoletePolicies)
            //    .WithRequired(e => e.Policies)
            //    .HasForeignKey(e => e.ObsoletePolicy)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.ObsoletePolicies1)
            //    .WithRequired(e => e.Policies1)
            //    .HasForeignKey(e => e.PolicyType)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Policies>()
                .HasMany(e => e.PolicyModifiers)
                .WithRequired(e => e.Policies)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.Governments1)
            //    .WithMany(e => e.Policies1)
            //    ;//.Map(m => m.ToTable("Policy_GovernmentExclusives_XP2").MapLeftKey("PolicyType").MapRightKey("GovernmentType"));


            modelBuilder.Entity<Projects>()
                .HasMany(e => e.EmergencyScoreSources)
                .WithOptional(e => e.Projects)
                .HasForeignKey(e => e.FromProject);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Project_BuildingCosts)
                .WithRequired(e => e.Projects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Project_GreatPersonPoints)
                .WithRequired(e => e.Projects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Project_ResourceCosts)
                .WithRequired(e => e.Projects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.Project_YieldConversions)
                .WithRequired(e => e.Projects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.ProjectCompletionModifiers)
                .WithRequired(e => e.Projects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.ProjectPrereqs)
                .WithRequired(e => e.Projects)
                .HasForeignKey(e => e.PrereqProjectType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasMany(e => e.ProjectPrereqs1)
                .WithRequired(e => e.Projects1)
                .HasForeignKey(e => e.ProjectType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Projects>()
                .HasOptional(e => e.Projects_XP1)
                .WithRequired(e => e.Projects);

            modelBuilder.Entity<Projects>()
                .HasOptional(e => e.Projects_XP2)
                .WithRequired(e => e.Projects);

            modelBuilder.Entity<Projects_XP2>()
                .HasMany(e => e.EmergencyScoreSources)
                .WithOptional(e => e.Projects_XP2)
                .HasForeignKey(e => e.FromProject);

            modelBuilder.Entity<Projects_XP2>()
                .HasMany(e => e.Project_BuildingCosts)
                .WithRequired(e => e.Projects_XP2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProposalTypes>()
                .HasMany(e => e.Discussions)
                .WithRequired(e => e.ProposalTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PseudoYields>()
                .HasMany(e => e.CongressAiChanges)
                .WithRequired(e => e.PseudoYields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PseudoYields>()
                .HasMany(e => e.GreatWorkObjectTypes)
                .WithRequired(e => e.PseudoYields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PseudoYields>()
                .HasMany(e => e.Strategy_YieldPriorities)
                .WithRequired(e => e.PseudoYields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RandomAgendas>()
                .HasMany(e => e.AgendaPreferredLeaders)
                .WithRequired(e => e.RandomAgendas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RandomEvents>()
                .HasMany(e => e.CoastalLowlands)
                .WithRequired(e => e.RandomEvents)
                .HasForeignKey(e => e.SubmergedEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RandomEvents>()
                .HasMany(e => e.CoastalLowlands1)
                .WithRequired(e => e.RandomEvents1)
                .HasForeignKey(e => e.FloodedEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RandomEvents>()
                .HasMany(e => e.RandomEvent_Damages)
                .WithRequired(e => e.RandomEvents)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RandomEvents>()
                .HasMany(e => e.RandomEvent_Frequencies)
                .WithRequired(e => e.RandomEvents)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RandomEvents>()
                .HasMany(e => e.RandomEvent_Yields)
                .WithRequired(e => e.RandomEvents)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RealismSettings>()
                .HasMany(e => e.RandomEvent_Frequencies)
                .WithRequired(e => e.RealismSettings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Religions>()
                .HasMany(e => e.FavoredReligions)
                .WithRequired(e => e.Religions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirements>()
                .HasMany(e => e.RequirementArguments)
                .WithRequired(e => e.Requirements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Requirements>()
                .HasMany(e => e.RequirementStrings)
                .WithRequired(e => e.Requirements)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequirementSets>()
                .HasMany(e => e.EmergencyAlliances)
                .WithOptional(e => e.RequirementSets)
                .HasForeignKey(e => e.MemberRequirementSet);

            modelBuilder.Entity<RequirementSets>()
                .HasMany(e => e.Modifiers)
                .WithOptional(e => e.RequirementSets)
                .HasForeignKey(e => e.SubjectRequirementSetId);

            modelBuilder.Entity<RequirementSets>()
                .HasMany(e => e.Modifiers1)
                .WithOptional(e => e.RequirementSets1)
                .HasForeignKey(e => e.OwnerRequirementSetId);

            //modelBuilder.Entity<RequirementSets>()
            //    .HasMany(e => e.Requirements)
            //    .WithMany(e => e.RequirementSets)
            //    ;//.Map(m => m.ToTable("RequirementSetRequirements").MapLeftKey("RequirementSetId").MapRightKey("RequirementId"));


            modelBuilder.Entity<Resolutions>()
                .HasMany(e => e.CongressAiChanges)
                .WithRequired(e => e.Resolutions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resolutions>()
                .HasMany(e => e.ResolutionEffects)
                .WithRequired(e => e.Resolutions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.BarbarianTribes)
                .WithOptional(e => e.Resources)
                .HasForeignKey(e => e.RequiredResource);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Building_ResourceCosts)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Resources)
                .HasForeignKey(e => e.AdjacentResource);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Buildings_XP2)
                .WithOptional(e => e.Resources)
                .HasForeignKey(e => e.ResourceTypeConvertedToPower);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Improvement_ValidResources)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Project_ResourceCosts)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Resources)
                .HasForeignKey(e => e.PrereqResource);

            modelBuilder.Entity<Resources>()
                .HasOptional(e => e.Resource_Consumption)
                .WithRequired(e => e.Resources);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Resource_Harvests)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Resource_TradeRouteYields)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Resource_YieldChanges)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Route_ResourceCosts)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.StartBiasResources)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Resources)
                .HasForeignKey(e => e.StrategicResource);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Units_XP2)
                .WithOptional(e => e.Resources)
                .HasForeignKey(e => e.ResourceMaintenanceType);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Terrains)
            //    .WithMany(e => e.Resources)
            //    ;//.Map(m => m.ToTable("Resource_ValidTerrains").MapLeftKey("ResourceType").MapRightKey("TerrainType"));


            modelBuilder.Entity<Routes>()
                .HasMany(e => e.Route_ResourceCosts)
                .WithRequired(e => e.Routes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Routes>()
                .HasOptional(e => e.Routes_XP2)
                .WithRequired(e => e.Routes);

            modelBuilder.Entity<ScoringCategories>()
                .HasMany(e => e.ScoringLineItems)
                .WithRequired(e => e.ScoringCategories)
                .HasForeignKey(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShapeDefinitions>()
                .HasMany(e => e.NodeDefinitions)
                .WithRequired(e => e.ShapeDefinitions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StartEras>()
                .HasOptional(e => e.StartEras_XP2)
                .WithRequired(e => e.StartEras);

            modelBuilder.Entity<Strategies>()
                .HasMany(e => e.Strategy_YieldPriorities)
                .WithRequired(e => e.Strategies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Strategies>()
                .HasMany(e => e.StrategyConditions)
                .WithRequired(e => e.Strategies)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Tags>()
            //    .HasMany(e => e.Types)
            //    .WithMany(e => e.Tags)
            //    ;//.Map(m => m.ToTable("TypeTags").MapLeftKey("Tag").MapRightKey("Type"));


            modelBuilder.Entity<TargetTypes>()
                .HasMany(e => e.AiOperationDefs)
                .WithRequired(e => e.TargetTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.ObsoleteTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Adjacency_YieldChanges1)
                .WithOptional(e => e.Technologies1)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Boosts)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.TechnologyType);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Boosts1)
                .WithOptional(e => e.Technologies1)
                .HasForeignKey(e => e.BoostingTechType);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.DiplomaticActions)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.TargetPrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.DiplomaticActions1)
                .WithOptional(e => e.Technologies1)
                .HasForeignKey(e => e.InitiatorPrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.DiplomaticVisibilitySources)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Districts)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Features)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.RemoveTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Improvement_BonusYieldChanges)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Improvement_Tourism)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Improvement_ValidTerrains)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Improvements)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Policies)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Projects)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Resource_Consumption)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.ObsoleteTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Resource_Harvests)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Resources)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Routes_XP2)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasOptional(e => e.Technologies_XP2)
                .WithRequired(e => e.Technologies);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.TechnologyModifiers)
                .WithRequired(e => e.Technologies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.TechnologyQuotes)
                .WithRequired(e => e.Technologies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.TechnologyRandomCosts)
                .WithRequired(e => e.Technologies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.UnitCommands)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.UnitOperations)
                .WithOptional(e => e.Technologies)
                .HasForeignKey(e => e.PrereqTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Units1)
                .WithOptional(e => e.Technologies1)
                .HasForeignKey(e => e.ObsoleteTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Units2)
                .WithOptional(e => e.Technologies2)
                .HasForeignKey(e => e.MandatoryObsoleteTech);

            modelBuilder.Entity<Technologies>()
                .HasMany(e => e.Units3)
                .WithOptional(e => e.Technologies3)
                .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Eras1)
            //    .WithMany(e => e.Technologies1)
            //    ;//.Map(m => m.ToTable("StartingBoostedTechnologies").MapLeftKey("Technology").MapRightKey("Era"));


            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Technologies1)
            //    .WithMany(e => e.Technologies2)
            //    ;//.Map(m => m.ToTable("TechnologyPrereqs").MapLeftKey("PrereqTech").MapRightKey("Technology"));


            modelBuilder.Entity<Technologies_XP2>()
                .HasMany(e => e.Routes_XP2)
                .WithOptional(e => e.Technologies_XP2)
                .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<TerrainClasses>()
            //    .HasMany(e => e.Terrains)
            //    .WithMany(e => e.TerrainClasses)
            //    ;//.Map(m => m.ToTable("TerrainClass_Terrains").MapLeftKey("TerrainClassType").MapRightKey("TerrainType"));


            modelBuilder.Entity<Terrains>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithOptional(e => e.Terrains)
                .HasForeignKey(e => e.AdjacentTerrain);

            modelBuilder.Entity<Terrains>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Terrains)
                .HasForeignKey(e => e.CityAdjacentTerrain);

            modelBuilder.Entity<Terrains>()
                .HasMany(e => e.Improvement_ValidTerrains)
                .WithRequired(e => e.Terrains)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terrains>()
                .HasMany(e => e.StartBiasTerrains)
                .WithRequired(e => e.Terrains)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Terrains>()
                .HasMany(e => e.Terrain_YieldChanges)
                .WithRequired(e => e.Terrains)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Buildings1)
            //    .WithMany(e => e.Terrains1)
            //    ;//.Map(m => m.ToTable("Building_ValidTerrains").MapLeftKey("TerrainType").MapRightKey("BuildingType"));


            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Features)
            //    .WithMany(e => e.Terrains)
            //    ;//.Map(m => m.ToTable("Feature_AdjacentTerrains").MapLeftKey("TerrainType").MapRightKey("FeatureType"));


            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Features1)
            //    .WithMany(e => e.Terrains1)
            //    ;//.Map(m => m.ToTable("Feature_NotAdjacentTerrains").MapLeftKey("TerrainType").MapRightKey("FeatureType"));


            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Features2)
            //    .WithMany(e => e.Terrains2)
            //    ;//.Map(m => m.ToTable("Feature_ValidTerrains").MapLeftKey("TerrainType").MapRightKey("FeatureType"));


            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Improvements)
            //    .WithMany(e => e.Terrains)
            //    ;//.Map(m => m.ToTable("Improvement_ValidAdjacentTerrains").MapLeftKey("TerrainType").MapRightKey("ImprovementType"));


            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.RandomEvents)
            //    .WithMany(e => e.Terrains)
            //    ;//.Map(m => m.ToTable("RandomEvent_Terrains").MapLeftKey("TerrainType").MapRightKey("RandomEventType"));


            modelBuilder.Entity<Traits>()
                .HasMany(e => e.DiplomaticVisibilitySources_XP1)
                .WithOptional(e => e.Traits)
                .HasForeignKey(e => e.TradePostTrait);

            modelBuilder.Entity<Traits>()
                .HasMany(e => e.Districts)
                .WithOptional(e => e.Traits)
                .HasForeignKey(e => e.TraitType);

            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.Agendas)
            //    .WithMany(e => e.Traits)
            //    ;//.Map(m => m.ToTable("AgendaTraits").MapLeftKey("TraitType").MapRightKey("AgendaType"));


            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.Districts1)
            //    .WithMany(e => e.Traits1)
            //    ;//.Map(m => m.ToTable("ExcludedDistricts").MapLeftKey("TraitType").MapRightKey("DistrictType"));


            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.GreatPersonClasses)
            //    .WithMany(e => e.Traits)
            //    ;//.Map(m => m.ToTable("ExcludedGreatPersonClasses").MapLeftKey("TraitType").MapRightKey("GreatPersonClassType"));


            modelBuilder.Entity<TurnSegments>()
                .HasMany(e => e.TurnPhases)
                .WithOptional(e => e.TurnSegments)
                .HasForeignKey(e => e.InactiveSegmentType);

            modelBuilder.Entity<TurnSegments>()
                .HasMany(e => e.TurnPhases1)
                .WithRequired(e => e.TurnSegments1)
                .HasForeignKey(e => e.ActiveSegmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Alliances)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Beliefs)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Buildings)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Civics)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Civilizations)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Defeats)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.DiplomaticActions)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Discussions)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Districts)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasMany(e => e.DynamicModifiers)
                .WithRequired(e => e.Types)
                .HasForeignKey(e => e.EffectType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.DynamicModifiers1)
                .WithRequired(e => e.Types1);

            modelBuilder.Entity<Types>()
                .HasMany(e => e.DynamicModifiers2)
                .WithRequired(e => e.Types2)
                .HasForeignKey(e => e.CollectionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.EmergencyAlliances)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Eras)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Features)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.GameCapabilities)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.GameEffects)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Gossips)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Governments)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Governors)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.GreatPersonClasses)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.GreatPersonIndividuals)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Improvements)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Leaders)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.LoadingInfo)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasMany(e => e.MomentIllustrations)
                .WithRequired(e => e.Types)
                .HasForeignKey(e => e.GameDataType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Moments)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Policies)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Projects)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.ProposalBlockers)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.ProposalTypes)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Quests)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Religions)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Resolutions)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Resources)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Routes)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Technologies)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Traits)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasMany(e => e.TypeProperties)
                .WithRequired(e => e.Types)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.UnitPromotionClasses)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.UnitPromotions)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Units)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.Victories)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<Types>()
                .HasOptional(e => e.VotingBlockers)
                .WithRequired(e => e.Types);

            modelBuilder.Entity<UnitAiTypes>()
                .HasMany(e => e.OpTeamRequirements)
                .WithRequired(e => e.UnitAiTypes)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<UnitAiTypes>()
            //    .HasMany(e => e.Units)
            //    .WithMany(e => e.UnitAiTypes)
            //    ;//.Map(m => m.ToTable("UnitAiInfos").MapLeftKey("AiType").MapRightKey("UnitType"));


            modelBuilder.Entity<UnitPromotionClasses>()
                .HasMany(e => e.UnitPromotions)
                .WithOptional(e => e.UnitPromotionClasses)
                .HasForeignKey(e => e.PromotionClass);

            modelBuilder.Entity<UnitPromotionClasses>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.UnitPromotionClasses)
                .HasForeignKey(e => e.PromotionClass);

            modelBuilder.Entity<UnitPromotions>()
                .HasMany(e => e.UnitPromotionModifiers)
                .WithRequired(e => e.UnitPromotions)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<UnitPromotions>()
            //    .HasMany(e => e.UnitPromotions1)
            //    .WithMany(e => e.UnitPromotions2)
            //    ;//.Map(m => m.ToTable("UnitPromotionPrereqs").MapLeftKey("UnitPromotion").MapRightKey("PrereqUnitPromotion"));


            modelBuilder.Entity<Units>()
                .HasMany(e => e.BonusMinorStartingUnits)
                .WithRequired(e => e.Units)
                .HasForeignKey(e => e.Unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.Boosts)
                .WithOptional(e => e.Units)
                .HasForeignKey(e => e.Unit2Type);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.Boosts1)
                .WithOptional(e => e.Units1)
                .HasForeignKey(e => e.Unit1Type);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.District_BuildChargeProductions)
                .WithRequired(e => e.Units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.GreatPersonClasses)
                .WithRequired(e => e.Units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.MajorStartingUnits)
                .WithRequired(e => e.Units)
                .HasForeignKey(e => e.Unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.Technologies)
                .WithOptional(e => e.Units)
                .HasForeignKey(e => e.EmbarkUnitType);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.Unit_BuildingPrereqs)
                .WithRequired(e => e.Units)
                .HasForeignKey(e => e.Unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Units>()
                .HasOptional(e => e.Units_XP2)
                .WithRequired(e => e.Units);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Improvements)
            //    .WithMany(e => e.Units)
            //    ;//.Map(m => m.ToTable("Improvement_ValidBuildUnits").MapLeftKey("UnitType").MapRightKey("ImprovementType"));


            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Routes)
            //    .WithMany(e => e.Units)
            //    ;//.Map(m => m.ToTable("Route_ValidBuildUnits").MapLeftKey("UnitType").MapRightKey("RouteType"));


            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Units1)
            //    .WithMany(e => e.Units2)
            //    ;//.Map(m => m.ToTable("UnitCaptures").MapLeftKey("BecomesUnitType").MapRightKey("CapturedUnitType"));


            //modelBuilder.Entity<Units>()
            //    .HasOptional(e => e.Units11)
            //    .WithMany(e => e.Units3);

            //modelBuilder.Entity<Units>()
            //    .HasOptional(e => e.Units12)
            //    .WithMany(e => e.Units4);

            modelBuilder.Entity<Visibilities>()
                .HasMany(e => e.RandomAgendasForCivic)
                .WithRequired(e => e.Visibilities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Visibilities>()
                .HasMany(e => e.RandomAgendasInEra)
                .WithRequired(e => e.Visibilities)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Visibilities>()
                .HasOptional(e => e.Visibilities_XP2)
                .WithRequired(e => e.Visibilities);

            modelBuilder.Entity<Vocabularies>()
                .HasMany(e => e.Tags)
                .WithRequired(e => e.Vocabularies)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Adjacency_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.AiBuildSpecializations)
                .WithRequired(e => e.Yields)
                .HasForeignKey(e => e.PrioritizationYield)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.AiBuildSpecializations1)
                .WithOptional(e => e.Yields1)
                .HasForeignKey(e => e.BuildingYield);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Building_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Building_YieldChangesBonusWithPower)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Building_YieldDistrictCopies)
                .WithRequired(e => e.Yields)
                .HasForeignKey(e => e.NewYieldType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Building_YieldDistrictCopies1)
                .WithRequired(e => e.Yields1)
                .HasForeignKey(e => e.OldYieldType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Building_YieldsPerEra)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Buildings)
                .WithOptional(e => e.Yields)
                .HasForeignKey(e => e.PurchaseYield);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.CongressAiChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.District_CitizenYieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.District_TradeRouteYields)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Feature_AdjacentYields)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Feature_Removes)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Feature_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.GreatWork_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Improvement_BonusYieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Improvement_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Improvements)
                .WithOptional(e => e.Yields)
                .HasForeignKey(e => e.YieldFromAppeal);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Project_YieldConversions)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.RandomEvent_Yields)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Resource_Harvests)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Resource_TradeRouteYields)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Resource_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Strategy_YieldPriorities)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Terrain_YieldChanges)
                .WithRequired(e => e.Yields)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.Yields)
                .HasForeignKey(e => e.PurchaseYield);

            modelBuilder.Entity<Yields>()
                .HasMany(e => e.Units1)
                .WithOptional(e => e.Yields1)
                .HasForeignKey(e => e.PurchaseYield);

            #region EF Core Test 1
            ////EF Core 1 
            //modelBuilder.Entity<Adjacency_YieldChanges>()
            //    .HasMany<Traits>(e => e.Traits)
            //    .WithMany(e => e.Adjacency_YieldChanges)
            //    .Map(m => m.ToTable("ExcludedAdjacencies").MapLeftKey("YieldChangeId").MapRightKey("TraitType"));

            //modelBuilder.Entity<Adjacency_YieldChanges>()
            //    .HasMany(e => e.Improvements1)
            //    .WithMany(e => e.Adjacency_YieldChanges1)
            //    .Map(m => m.ToTable("Improvement_Adjacencies").MapLeftKey("YieldChangeId").MapRightKey("ImprovementType"));

            //modelBuilder.Entity<Agendas>()
            //    .HasOptional(e => e.RandomAgendas)
            //    .WithOne(e => e.Agendas);

            //modelBuilder.Entity<Agendas>()
            //    .HasOptional(e => e.RandomAgendas_XP2)
            //    .WithOne(e => e.Agendas);

            //modelBuilder.Entity<Agendas>()
            //    .HasMany(e => e.Agendas1)
            //    .WithMany(e => e.Agendas2)
            //    .Map(m => m.ToTable("ExclusiveAgendas").MapLeftKey("AgendaTwo").MapRightKey("AgendaOne"));

            //modelBuilder.Entity<AgendaTags>()
            //    .HasMany(e => e.RandomAgendas_XP2)
            //    .WithOne(e => e.AgendaTags)
            //    .HasForeignKey(e => e.AgendaTag)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AgendaTags>()
            //    .HasMany(e => e.Civics)
            //    .WithMany(e => e.AgendaTags)
            //    .Map(m => m.ToTable("RandomAgendaCivicTags").MapLeftKey("AgendaTag").MapRightKey("CivicType"));

            //modelBuilder.Entity<AgendaTags>()
            //    .HasMany(e => e.Eras)
            //    .WithMany(e => e.AgendaTags)
            //    .Map(m => m.ToTable("RandomAgendaEraTags").MapLeftKey("AgendaTag").MapRightKey("EraType"));

            //modelBuilder.Entity<AiEvents>()
            //    .HasMany(e => e.TriggeredBehaviorTrees)
            //    .WithOne(e => e.AiEvents)
            //    .HasForeignKey(e => e.AIEvent)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiListTypes>()
            //    .HasMany(e => e.AiFavoredItems)
            //    .WithOne(e => e.AiListTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiListTypes>()
            //    .HasMany(e => e.AiLists)
            //    .WithOne(e => e.AiListTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiListTypes>()
            //    .HasMany(e => e.Strategies)
            //    .WithMany(e => e.AiListTypes)
            //    .Map(m => m.ToTable("Strategy_Priorities").MapLeftKey("ListType").MapRightKey("StrategyType"));

            //modelBuilder.Entity<AiOperationDefs>()
            //    .HasMany(e => e.AiOperationTeams)
            //    .WithOne(e => e.AiOperationDefs)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiOperationDefs>()
            //    .HasMany(e => e.AllowedOperations)
            //    .WithOne(e => e.AiOperationDefs)
            //    .HasForeignKey(e => e.OperationDef)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiOperationLists>()
            //    .HasMany(e => e.Agendas)
            //    .WithOptional(e => e.AiOperationLists)
            //    .HasForeignKey(e => e.OperationList);

            //modelBuilder.Entity<AiOperationLists>()
            //    .HasMany(e => e.AiOperationLimits)
            //    .WithOne(e => e.AiOperationLists)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiOperationLists>()
            //    .HasMany(e => e.AiOperationLists1)
            //    .WithOptional(e => e.AiOperationLists2)
            //    .HasForeignKey(e => e.BaseList);

            //modelBuilder.Entity<AiOperationLists>()
            //    .HasMany(e => e.AllowedOperations)
            //    .WithOne(e => e.AiOperationLists)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiOperationLists>()
            //    .HasMany(e => e.Leaders)
            //    .WithOptional(e => e.AiOperationLists)
            //    .HasForeignKey(e => e.OperationList);

            //modelBuilder.Entity<AiOperationTypes>()
            //    .HasMany(e => e.AiOperationLimits)
            //    .WithOne(e => e.AiOperationTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiTeams>()
            //    .HasMany(e => e.AiOperationTeams)
            //    .WithOne(e => e.AiTeams)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<AiTeams>()
            //    .HasMany(e => e.OpTeamRequirements)
            //    .WithOne(e => e.AiTeams)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Alliances>()
            //    .HasMany(e => e.AllianceEffects)
            //    .WithOne(e => e.Alliances)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BarbarianAttackForces>()
            //    .HasMany(e => e.BarbarianTribeForces)
            //    .WithOne(e => e.BarbarianAttackForces)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BarbarianTribeNames>()
            //    .HasMany(e => e.BarbarianTribeForces)
            //    .WithOne(e => e.BarbarianTribeNames)
            //    .HasForeignKey(e => e.SpecificTribeType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BarbarianTribes>()
            //    .HasMany(e => e.BarbarianTribeForces)
            //    .WithOne(e => e.BarbarianTribes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BarbarianTribes>()
            //    .HasMany(e => e.BarbarianTribeNames)
            //    .WithOne(e => e.BarbarianTribes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BehaviorTrees>()
            //    .HasMany(e => e.AiOperationDefs)
            //    .WithOptional(e => e.BehaviorTrees)
            //    .HasForeignKey(e => e.BehaviorTree);

            //modelBuilder.Entity<BehaviorTrees>()
            //    .HasMany(e => e.BehaviorTreeNodes)
            //    .WithOne(e => e.BehaviorTrees)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BehaviorTrees>()
            //    .HasMany(e => e.BoostHandlers)
            //    .WithOptional(e => e.BehaviorTrees)
            //    .HasForeignKey(e => e.BehaviorTree);

            //modelBuilder.Entity<BehaviorTrees>()
            //    .HasMany(e => e.TreeData)
            //    .WithOne(e => e.BehaviorTrees)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BehaviorTrees>()
            //    .HasMany(e => e.TriggeredBehaviorTrees)
            //    .WithOne(e => e.BehaviorTrees)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BeliefClasses>()
            //    .HasMany(e => e.Beliefs)
            //    .WithOne(e => e.BeliefClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Beliefs>()
            //    .HasMany(e => e.BeliefModifiers)
            //    .WithOne(e => e.Beliefs)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BoostNames>()
            //    .HasMany(e => e.BoostHandlers)
            //    .WithOne(e => e.BoostNames)
            //    .HasForeignKey(e => e.TechBoostType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<BoostNames>()
            //    .HasMany(e => e.Boosts)
            //    .WithOne(e => e.BoostNames)
            //    .HasForeignKey(e => e.BoostClass)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_GreatPersonPoints)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_GreatWorks)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_ResourceCosts)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasOptional(e => e.Building_TourismBombs_XP2)
            //    .WithOne(e => e.Buildings);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_YieldChanges)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_YieldChangesBonusWithPower)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_YieldDistrictCopies)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Building_YieldsPerEra)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.BuildingModifiers)
            //    .WithOne(e => e.Buildings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasOptional(e => e.Buildings_XP2)
            //    .WithOne(e => e.Buildings);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.EmergencyScoreSources)
            //    .WithOptional(e => e.Buildings)
            //    .HasForeignKey(e => e.FromBuilding);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.GreatPersonIndividuals)
            //    .WithOptional(e => e.Buildings)
            //    .HasForeignKey(e => e.ActionRequiresMissingBuildingType);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Project_BuildingCosts)
            //    .WithOne(e => e.Buildings)
            //    .HasForeignKey(e => e.ConsumedBuildingType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Projects)
            //    .WithOptional(e => e.Buildings)
            //    .HasForeignKey(e => e.VisualBuildingType);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Projects_XP2)
            //    .WithOptional(e => e.Buildings)
            //    .HasForeignKey(e => e.CreateBuilding);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Projects_XP21)
            //    .WithOptional(e => e.Buildings1)
            //    .HasForeignKey(e => e.RequiredBuilding);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.StartingBuildings)
            //    .WithOne(e => e.Buildings)
            //    .HasForeignKey(e => e.Building)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Unit_BuildingPrereqs)
            //    .WithOne(e => e.Buildings)
            //    .HasForeignKey(e => e.PrereqBuilding)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Buildings1)
            //    .WithMany(e => e.Buildings2)
            //    .Map(m => m.ToTable("BuildingPrereqs").MapLeftKey("PrereqBuilding").MapRightKey("Building"));

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Buildings11)
            //    .WithMany(e => e.Buildings3)
            //    .Map(m => m.ToTable("BuildingReplaces").MapLeftKey("ReplacesBuildingType").MapRightKey("CivUniqueBuildingType"));

            //modelBuilder.Entity<Buildings>()
            //    .HasMany(e => e.Buildings12)
            //    .WithMany(e => e.Buildings4)
            //    .Map(m => m.ToTable("MutuallyExclusiveBuildings").MapLeftKey("MutuallyExclusiveBuilding").MapRightKey("Building"));

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.ObsoleteCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Adjacency_YieldChanges1)
            //    .WithOptional(e => e.Civics1)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Boosts)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.BoostingCivicType);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Boosts1)
            //    .WithOptional(e => e.Civics1)
            //    .HasForeignKey(e => e.CivicType);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.CivicQuotes)
            //    .WithOne(e => e.Civics)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.CivicRandomCosts)
            //    .WithOne(e => e.Civics)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civics>()
            //    .HasOptional(e => e.Civics_XP2)
            //    .WithOne(e => e.Civics);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.DiplomaticActions)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.InitiatorObsoleteCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.DiplomaticActions1)
            //    .WithOptional(e => e.Civics1)
            //    .HasForeignKey(e => e.TargetPrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.DiplomaticActions2)
            //    .WithOptional(e => e.Civics2)
            //    .HasForeignKey(e => e.InitiatorPrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Districts)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Features)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.AddCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Governments)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Improvement_BonusYieldChanges)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Improvement_Tourism)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Improvement_ValidTerrains)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Improvements)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Policies)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Projects)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasOptional(e => e.RandomAgendasForCivic)
            //    .WithOne(e => e.Civics);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Resources)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.UnitCommands)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.UnitOperations)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Units)
            //    .WithOptional(e => e.Civics)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Units1)
            //    .WithOptional(e => e.Civics1)
            //    .HasForeignKey(e => e.MandatoryObsoleteCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Units2)
            //    .WithOptional(e => e.Civics2)
            //    .HasForeignKey(e => e.ObsoleteCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Units3)
            //    .WithOptional(e => e.Civics3)
            //    .HasForeignKey(e => e.PrereqCivic);

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Civics1)
            //    .WithMany(e => e.Civics2)
            //    .Map(m => m.ToTable("CivicPrereqs").MapLeftKey("PrereqCivic").MapRightKey("Civic"));

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Eras1)
            //    .WithMany(e => e.Civics1)
            //    .Map(m => m.ToTable("StartingBoostedCivics").MapLeftKey("Civic").MapRightKey("Era"));

            //modelBuilder.Entity<Civics>()
            //    .HasMany(e => e.Eras2)
            //    .WithMany(e => e.Civics2)
            //    .Map(m => m.ToTable("StartingCivics").MapLeftKey("Civic").MapRightKey("Era"));

            //modelBuilder.Entity<CivilizationLevels>()
            //    .HasMany(e => e.Civilizations)
            //    .WithOne(e => e.CivilizationLevels)
            //    .HasForeignKey(e => e.StartingCivilizationLevelType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<CivilizationLevels>()
            //    .HasMany(e => e.DiplomaticStartStates)
            //    .WithOne(e => e.CivilizationLevels)
            //    .HasForeignKey(e => e.OpponentCivLevel)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<CivilizationLevels>()
            //    .HasMany(e => e.DiplomaticStartStates1)
            //    .WithOne(e => e.CivilizationLevels1)
            //    .HasForeignKey(e => e.PlayerCivLevel)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<CivilizationLevels>()
            //    .HasMany(e => e.DiplomaticTriggeredTransitions)
            //    .WithOne(e => e.CivilizationLevels)
            //    .HasForeignKey(e => e.OpponentCivilizationLevel)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<CivilizationLevels>()
            //    .HasMany(e => e.DiplomaticTriggeredTransitions1)
            //    .WithOne(e => e.CivilizationLevels1)
            //    .HasForeignKey(e => e.CivilizationLevel)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.CivilizationCitizenNames)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.CivilizationInfo)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.CivilizationLeaders)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.FavoredReligions)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.StartBiasFeatures)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.StartBiasResources)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasOptional(e => e.StartBiasRivers)
            //    .WithOne(e => e.Civilizations);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.StartBiasTerrains)
            //    .WithOne(e => e.Civilizations)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Civilizations)
            //    .Map(m => m.ToTable("CivilizationTraits").MapLeftKey("CivilizationType").MapRightKey("TraitType"));

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.Civilizations1)
            //    .WithMany(e => e.Civilizations2)
            //    .Map(m => m.ToTable("DuplicateCivilizations").MapLeftKey("OtherCivilizationType").MapRightKey("CivilizationType"));

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedDeserts)
            //    .WithMany(e => e.Civilizations)
            //    .Map(m => m.ToTable("NamedDesertCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedDesertType"));

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedMountains)
            //    .WithMany(e => e.Civilizations)
            //    .Map(m => m.ToTable("NamedMountainCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedMountainType"));

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedRivers)
            //    .WithMany(e => e.Civilizations)
            //    .Map(m => m.ToTable("NamedRiverCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedRiverType"));

            //modelBuilder.Entity<Civilizations>()
            //    .HasMany(e => e.NamedVolcanoes)
            //    .WithMany(e => e.Civilizations)
            //    .Map(m => m.ToTable("NamedVolcanoCivilizations").MapLeftKey("CivilizationType").MapRightKey("NamedVolcanoType"));

            //modelBuilder.Entity<CommemorationTypes>()
            //    .HasMany(e => e.CommemorationModifiers)
            //    .WithOne(e => e.CommemorationTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<CommemorationTypes>()
            //    .HasMany(e => e.ComplimentModifiers)
            //    .WithOne(e => e.CommemorationTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<CommemorationTypes>()
            //    .HasMany(e => e.DiplomaticActions_XP1)
            //    .WithOptional(e => e.CommemorationTypes)
            //    .HasForeignKey(e => e.RequiresGoldenAgeCommemorationType);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.AiFavoredItems)
            //    .WithOptional(e => e.Difficulties)
            //    .HasForeignKey(e => e.MaxDifficulty);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.AiFavoredItems1)
            //    .WithOptional(e => e.Difficulties1)
            //    .HasForeignKey(e => e.MinDifficulty);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.AiLists)
            //    .WithOptional(e => e.Difficulties)
            //    .HasForeignKey(e => e.MinDifficulty);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.AiLists1)
            //    .WithOptional(e => e.Difficulties1)
            //    .HasForeignKey(e => e.MaxDifficulty);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.BarbarianAttackForces)
            //    .WithOptional(e => e.Difficulties)
            //    .HasForeignKey(e => e.MaxTargetDifficulty);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.BarbarianAttackForces1)
            //    .WithOptional(e => e.Difficulties1)
            //    .HasForeignKey(e => e.MinTargetDifficulty);

            //modelBuilder.Entity<Difficulties>()
            //    .HasMany(e => e.MajorStartingUnits)
            //    .WithOne(e => e.Difficulties)
            //    .HasForeignKey(e => e.MinDifficulty)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticActions>()
            //    .HasOptional(e => e.DiplomaticActions_XP1)
            //    .WithOne(e => e.DiplomaticActions);

            //modelBuilder.Entity<DiplomaticActions>()
            //    .HasOptional(e => e.DiplomaticActions_XP2)
            //    .WithOne(e => e.DiplomaticActions);

            //modelBuilder.Entity<DiplomaticActions>()
            //    .HasMany(e => e.DiplomaticStateActions)
            //    .WithOne(e => e.DiplomaticActions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticStartStates)
            //    .WithOne(e => e.DiplomaticStates)
            //    .HasForeignKey(e => e.DiplomaticStateType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticStateActions)
            //    .WithOptional(e => e.DiplomaticStates)
            //    .HasForeignKey(e => e.TransitionToState);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticStateActions1)
            //    .WithOne(e => e.DiplomaticStates1)
            //    .HasForeignKey(e => e.StateType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticStateTransitions)
            //    .WithOne(e => e.DiplomaticStates)
            //    .HasForeignKey(e => e.BaseState)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticStateTransitions1)
            //    .WithOne(e => e.DiplomaticStates1)
            //    .HasForeignKey(e => e.TransitionState)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticTriggeredTransitions)
            //    .WithOne(e => e.DiplomaticStates)
            //    .HasForeignKey(e => e.TransitionState)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticStates>()
            //    .HasMany(e => e.DiplomaticTriggers)
            //    .WithMany(e => e.DiplomaticStates)
            //    .Map(m => m.ToTable("DiplomaticTriggers_RequiredStates").MapLeftKey("RequiredState").MapRightKey("TriggerType"));

            //modelBuilder.Entity<DiplomaticTriggers>()
            //    .HasMany(e => e.DiplomaticTriggeredTransitions)
            //    .WithOne(e => e.DiplomaticTriggers)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<DiplomaticVisibilitySources>()
            //    .HasOptional(e => e.DiplomaticVisibilitySources_XP1)
            //    .WithOne(e => e.DiplomaticVisibilitySources);

            //modelBuilder.Entity<Discussions>()
            //    .HasMany(e => e.CongressAiChanges)
            //    .WithOne(e => e.Discussions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.AdjacentDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.AppealHousingChanges)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.PrereqDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Buildings1)
            //    .WithOptional(e => e.Districts1)
            //    .HasForeignKey(e => e.AdjacentDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.District_BuildChargeProductions)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.District_CitizenGreatPersonPoints)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.District_CitizenYieldChanges)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.District_GreatPersonPoints)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.District_TradeRouteYields)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasOptional(e => e.Districts_XP2)
            //    .WithOne(e => e.Districts);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.EmergencyScoreSources)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.FromDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.GreatPersonClasses)
            //    .WithOne(e => e.Districts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.GreatPersonIndividuals)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.ActionRequiresCompletedDistrictType);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.MajorStartingUnits)
            //    .WithOne(e => e.Districts)
            //    .HasForeignKey(e => e.District)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Projects)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.PrereqDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.StartingBuildings)
            //    .WithOne(e => e.Districts)
            //    .HasForeignKey(e => e.District)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.UnitOperations)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.TargetDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Units)
            //    .WithOptional(e => e.Districts)
            //    .HasForeignKey(e => e.PrereqDistrict);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Adjacency_YieldChanges1)
            //    .WithMany(e => e.Districts1)
            //    .Map(m => m.ToTable("District_Adjacencies").MapLeftKey("DistrictType").MapRightKey("YieldChangeId"));

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Terrains)
            //    .WithMany(e => e.Districts)
            //    .Map(m => m.ToTable("District_ValidTerrains").MapLeftKey("DistrictType").MapRightKey("TerrainType"));

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Districts1)
            //    .WithOptional(e => e.Districts2);

            //modelBuilder.Entity<Districts>()
            //    .HasMany(e => e.Districts11)
            //    .WithMany(e => e.Districts3)
            //    .Map(m => m.ToTable("MutuallyExclusiveDistricts").MapLeftKey("MutuallyExclusiveDistrict").MapRightKey("District"));

            //modelBuilder.Entity<Emergencies_XP2>()
            //    .HasMany(e => e.EmergencyScoreSources)
            //    .WithOne(e => e.Emergencies_XP2)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<EmergencyAlliances>()
            //    .HasOptional(e => e.Emergencies_XP2)
            //    .WithOne(e => e.EmergencyAlliances);

            //modelBuilder.Entity<EmergencyAlliances>()
            //    .HasMany(e => e.EmergencyBuffs)
            //    .WithOne(e => e.EmergencyAlliances)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<EmergencyAlliances>()
            //    .HasMany(e => e.EmergencyRewards)
            //    .WithOne(e => e.EmergencyAlliances)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<EmergencyGoalTexts>()
            //    .HasMany(e => e.EmergencyAlliances)
            //    .WithOne(e => e.EmergencyGoalTexts)
            //    .HasForeignKey(e => e.GoalText)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<EmergencyTexts>()
            //    .HasMany(e => e.EmergencyAlliances)
            //    .WithOne(e => e.EmergencyTexts)
            //    .HasForeignKey(e => e.EmergencyText)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.BonusMinorStartingUnits)
            //    .WithOne(e => e.Eras)
            //    .HasForeignKey(e => e.Era)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Civics)
            //    .WithOne(e => e.Eras)
            //    .HasForeignKey(e => e.EraType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.CommemorationTypes)
            //    .WithOptional(e => e.Eras)
            //    .HasForeignKey(e => e.MaximumGameEra);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.CommemorationTypes1)
            //    .WithOptional(e => e.Eras1)
            //    .HasForeignKey(e => e.MinimumGameEra);

            //modelBuilder.Entity<Eras>()
            //    .HasOptional(e => e.Eras_XP1)
            //    .WithOne(e => e.Eras);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.GreatPersonIndividuals)
            //    .WithOne(e => e.Eras)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.MajorStartingUnits)
            //    .WithOne(e => e.Eras)
            //    .HasForeignKey(e => e.Era)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Moments)
            //    .WithOptional(e => e.Eras)
            //    .HasForeignKey(e => e.ObsoleteEra);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Moments1)
            //    .WithOptional(e => e.Eras1)
            //    .HasForeignKey(e => e.MaximumGameEra);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Moments2)
            //    .WithOptional(e => e.Eras2)
            //    .HasForeignKey(e => e.MinimumGameEra);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Policies_XP1)
            //    .WithOptional(e => e.Eras)
            //    .HasForeignKey(e => e.MaximumGameEra);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Policies_XP11)
            //    .WithOptional(e => e.Eras1)
            //    .HasForeignKey(e => e.MinimumGameEra);

            //modelBuilder.Entity<Eras>()
            //    .HasOptional(e => e.RandomAgendasInEra)
            //    .WithOne(e => e.Eras);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Routes)
            //    .WithOptional(e => e.Eras)
            //    .HasForeignKey(e => e.PrereqEra);

            //modelBuilder.Entity<Eras>()
            //    .HasOptional(e => e.StartEras)
            //    .WithOne(e => e.Eras);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.StartingBuildings)
            //    .WithOne(e => e.Eras)
            //    .HasForeignKey(e => e.Era)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.StartingGovernments)
            //    .WithOne(e => e.Eras)
            //    .HasForeignKey(e => e.Era)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Eras>()
            //    .HasMany(e => e.Technologies)
            //    .WithOne(e => e.Eras)
            //    .HasForeignKey(e => e.EraType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOptional(e => e.Features)
            //    .HasForeignKey(e => e.AdjacentFeature);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Feature_AdjacentYields)
            //    .WithOne(e => e.Features)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Features>()
            //    .HasOptional(e => e.Feature_Floodplains)
            //    .WithOne(e => e.Features);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Feature_Removes)
            //    .WithOne(e => e.Features)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Feature_YieldChanges)
            //    .WithOne(e => e.Features)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Features>()
            //    .HasOptional(e => e.Features_XP2)
            //    .WithOne(e => e.Features);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.GreatPersonIndividuals)
            //    .WithOptional(e => e.Features)
            //    .HasForeignKey(e => e.ActionRequiresOnOrAdjacentFeatureType);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.RandomEvent_Yields)
            //    .WithOne(e => e.Features)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.RandomEvents)
            //    .WithOptional(e => e.Features)
            //    .HasForeignKey(e => e.NaturalWonder);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.StartBiasFeatures)
            //    .WithOne(e => e.Features)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Buildings)
            //    .WithMany(e => e.Features)
            //    .Map(m => m.ToTable("Building_RequiredFeatures").MapLeftKey("FeatureType").MapRightKey("BuildingType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Buildings1)
            //    .WithMany(e => e.Features1)
            //    .Map(m => m.ToTable("Building_ValidFeatures").MapLeftKey("FeatureType").MapRightKey("BuildingType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Districts)
            //    .WithMany(e => e.Features)
            //    .Map(m => m.ToTable("District_RequiredFeatures").MapLeftKey("FeatureType").MapRightKey("DistrictType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Features1)
            //    .WithMany(e => e.Features2)
            //    .Map(m => m.ToTable("Feature_AdjacentFeatures").MapLeftKey("FeatureTypeAdjacent").MapRightKey("FeatureType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Features11)
            //    .WithMany(e => e.Features3)
            //    .Map(m => m.ToTable("Feature_NotNearFeatures").MapLeftKey("FeatureTypeAvoid").MapRightKey("FeatureType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Improvements)
            //    .WithMany(e => e.Features)
            //    .Map(m => m.ToTable("Improvement_InvalidAdjacentFeatures").MapLeftKey("FeatureType").MapRightKey("ImprovementType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Improvements1)
            //    .WithMany(e => e.Features1)
            //    .Map(m => m.ToTable("Improvement_ValidFeatures").MapLeftKey("FeatureType").MapRightKey("ImprovementType"));

            //modelBuilder.Entity<Features>()
            //    .HasMany(e => e.Resources)
            //    .WithMany(e => e.Features)
            //    .Map(m => m.ToTable("Resource_ValidFeatures").MapLeftKey("FeatureType").MapRightKey("ResourceType"));

            //modelBuilder.Entity<Flavors>()
            //    .HasMany(e => e.Units)
            //    .WithOptional(e => e.Flavors)
            //    .HasForeignKey(e => e.Flavor);

            //modelBuilder.Entity<GameCapabilities>()
            //    .HasMany(e => e.GameCapabilityDependencies)
            //    .WithOptional(e => e.GameCapabilities)
            //    .HasForeignKey(e => e.DependsOnCapability);

            //modelBuilder.Entity<GameCapabilities>()
            //    .HasMany(e => e.GameCapabilityDependencies1)
            //    .WithOptional(e => e.GameCapabilities1)
            //    .HasForeignKey(e => e.GameCapability);

            //modelBuilder.Entity<GameEffects>()
            //    .HasMany(e => e.GameEffectArguments)
            //    .WithOne(e => e.GameEffects)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GameSpeed_Scalings>()
            //    .HasMany(e => e.GameSpeed_Durations)
            //    .WithOne(e => e.GameSpeed_Scalings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GameSpeeds>()
            //    .HasMany(e => e.GameSpeed_Scalings)
            //    .WithOne(e => e.GameSpeeds)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GameSpeeds>()
            //    .HasMany(e => e.GameSpeed_Turns)
            //    .WithOne(e => e.GameSpeeds)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GoodyHuts>()
            //    .HasMany(e => e.GoodyHutSubTypes)
            //    .WithOne(e => e.GoodyHuts)
            //    .HasForeignKey(e => e.GoodyHut)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GoodyHutSubTypes>()
            //    .HasOptional(e => e.GoodyHutSubTypes_XP2)
            //    .WithOne(e => e.GoodyHutSubTypes);

            //modelBuilder.Entity<GovernmentBonusNames>()
            //    .HasMany(e => e.Governments)
            //    .WithOne(e => e.GovernmentBonusNames)
            //    .HasForeignKey(e => e.BonusType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Governments>()
            //    .HasMany(e => e.Government_SlotCounts)
            //    .WithOne(e => e.Governments)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Governments>()
            //    .HasMany(e => e.GovernmentModifiers)
            //    .WithOne(e => e.Governments)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Governments>()
            //    .HasOptional(e => e.Governments_XP2)
            //    .WithOne(e => e.Governments);

            //modelBuilder.Entity<Governments>()
            //    .HasMany(e => e.StartingGovernments)
            //    .WithOne(e => e.Governments)
            //    .HasForeignKey(e => e.Government)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GovernmentSlots>()
            //    .HasMany(e => e.Government_SlotCounts)
            //    .WithOne(e => e.GovernmentSlots)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GovernmentSlots>()
            //    .HasMany(e => e.Policies)
            //    .WithOne(e => e.GovernmentSlots)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GovernmentTiers>()
            //    .HasMany(e => e.Boosts)
            //    .WithOptional(e => e.GovernmentTiers)
            //    .HasForeignKey(e => e.GovernmentTierType);

            //modelBuilder.Entity<GovernmentTiers>()
            //    .HasMany(e => e.Governments)
            //    .WithOptional(e => e.GovernmentTiers)
            //    .HasForeignKey(e => e.Tier);

            //modelBuilder.Entity<GovernorPromotions>()
            //    .HasMany(e => e.GovernorPromotionModifiers)
            //    .WithOne(e => e.GovernorPromotions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GovernorPromotions>()
            //    .HasMany(e => e.GovernorPromotions1)
            //    .WithMany(e => e.GovernorPromotions2)
            //    .Map(m => m.ToTable("GovernorPromotionPrereqs").MapLeftKey("PrereqGovernorPromotion").MapRightKey("GovernorPromotionType"));

            //modelBuilder.Entity<GovernorPromotions>()
            //    .HasMany(e => e.Governors)
            //    .WithMany(e => e.GovernorPromotions)
            //    .Map(m => m.ToTable("GovernorPromotionSets").MapLeftKey("GovernorPromotion").MapRightKey("GovernorType"));

            //modelBuilder.Entity<Governors>()
            //    .HasMany(e => e.GovernorModifiers)
            //    .WithOne(e => e.Governors)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Governors>()
            //    .HasOptional(e => e.Governors_XP2)
            //    .WithOne(e => e.Governors);

            //modelBuilder.Entity<Governors>()
            //    .HasMany(e => e.Governors1)
            //    .WithMany(e => e.Governors2)
            //    .Map(m => m.ToTable("GovernorReplaces").MapLeftKey("ReplacesGovernorType").MapRightKey("UniqueGovernorType"));

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.Building_GreatPersonPoints)
            //    .WithOne(e => e.GreatPersonClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.District_CitizenGreatPersonPoints)
            //    .WithOne(e => e.GreatPersonClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.District_GreatPersonPoints)
            //    .WithOne(e => e.GreatPersonClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.EmergencyScoreSources)
            //    .WithOptional(e => e.GreatPersonClasses)
            //    .HasForeignKey(e => e.FromGreatPerson);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.GreatPersonIndividuals)
            //    .WithOne(e => e.GreatPersonClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.Map_GreatPersonClasses)
            //    .WithOne(e => e.GreatPersonClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.ObsoletePolicies)
            //    .WithOptional(e => e.GreatPersonClasses)
            //    .HasForeignKey(e => e.RequiresAvailableGreatPersonClass);

            //modelBuilder.Entity<GreatPersonClasses>()
            //    .HasMany(e => e.Project_GreatPersonPoints)
            //    .WithOne(e => e.GreatPersonClasses)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonIndividuals>()
            //    .HasMany(e => e.GreatPersonIndividualActionModifiers)
            //    .WithOne(e => e.GreatPersonIndividuals)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatPersonIndividuals>()
            //    .HasMany(e => e.GreatPersonIndividualBirthModifiers)
            //    .WithOne(e => e.GreatPersonIndividuals)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatWorkObjectTypes>()
            //    .HasMany(e => e.GreatPersonIndividuals)
            //    .WithOptional(e => e.GreatWorkObjectTypes)
            //    .HasForeignKey(e => e.ActionRequiresCityGreatWorkObjectType);

            //modelBuilder.Entity<GreatWorkObjectTypes>()
            //    .HasMany(e => e.GreatWorks)
            //    .WithOne(e => e.GreatWorkObjectTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatWorks>()
            //    .HasMany(e => e.GreatWork_YieldChanges)
            //    .WithOne(e => e.GreatWorks)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatWorkSlotTypes>()
            //    .HasMany(e => e.Building_GreatWorks)
            //    .WithOne(e => e.GreatWorkSlotTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<GreatWorkSlotTypes>()
            //    .HasMany(e => e.GreatWorkObjectTypes)
            //    .WithMany(e => e.GreatWorkSlotTypes)
            //    .Map(m => m.ToTable("GreatWork_ValidSubTypes").MapLeftKey("GreatWorkSlotType").MapRightKey("GreatWorkObjectType"));

            //modelBuilder.Entity<Happinesses>()
            //    .HasOptional(e => e.Happinesses_XP1)
            //    .WithOne(e => e.Happinesses);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOptional(e => e.Improvements)
            //    .HasForeignKey(e => e.AdjacentImprovement);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Improvements)
            //    .HasForeignKey(e => e.AdjacentImprovement);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.GoodyHuts)
            //    .WithOne(e => e.Improvements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Improvement_BonusYieldChanges)
            //    .WithOne(e => e.Improvements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Improvements>()
            //    .HasOptional(e => e.Improvement_Tourism)
            //    .WithOne(e => e.Improvements);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Improvement_ValidResources)
            //    .WithOne(e => e.Improvements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Improvement_ValidTerrains)
            //    .WithOne(e => e.Improvements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Improvement_YieldChanges)
            //    .WithOne(e => e.Improvements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.ImprovementModifiers)
            //    .WithOne(e => e.Improvements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Improvements>()
            //    .HasOptional(e => e.Improvements_XP2)
            //    .WithOne(e => e.Improvements);

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.Resources)
            //    .WithMany(e => e.Improvements)
            //    .Map(m => m.ToTable("Improvement_ValidAdjacentResources").MapLeftKey("ImprovementType").MapRightKey("ResourceType"));

            //modelBuilder.Entity<Improvements>()
            //    .HasMany(e => e.RandomEvents)
            //    .WithMany(e => e.Improvements)
            //    .Map(m => m.ToTable("RandomEvent_PillagedImprovements").MapLeftKey("ImprovementType").MapRightKey("RandomEventType"));

            //modelBuilder.Entity<Kinds>()
            //    .HasMany(e => e.Types)
            //    .WithOne(e => e.Kinds)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.AgendaPreferredLeaders)
            //    .WithOne(e => e.Leaders)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.CivilizationLeaders)
            //    .WithOne(e => e.Leaders)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.FavoredReligions)
            //    .WithOne(e => e.Leaders)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.LeaderInfo)
            //    .WithOne(e => e.Leaders)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.LeaderQuotes)
            //    .WithOne(e => e.Leaders)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Leaders1)
            //    .WithOptional(e => e.Leaders2)
            //    .HasForeignKey(e => e.InheritFrom);

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Leaders11)
            //    .WithMany(e => e.Leaders3)
            //    .Map(m => m.ToTable("DuplicateLeaders").MapLeftKey("OtherLeaderType").MapRightKey("LeaderType"));

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Agendas)
            //    .WithMany(e => e.Leaders)
            //    .Map(m => m.ToTable("HistoricalAgendas").MapLeftKey("LeaderType").MapRightKey("AgendaType"));

            //modelBuilder.Entity<Leaders>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Leaders)
            //    .Map(m => m.ToTable("LeaderTraits").MapLeftKey("LeaderType").MapRightKey("TraitType"));

            //modelBuilder.Entity<Maps>()
            //    .HasMany(e => e.Map_GreatPersonClasses)
            //    .WithOne(e => e.Maps)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Maps>()
            //    .HasOptional(e => e.Maps_XP2)
            //    .WithOne(e => e.Maps);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.AllianceEffects)
            //    .WithOne(e => e.Modifiers)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.EmergencyBuffs)
            //    .WithOne(e => e.Modifiers)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.EmergencyRewards)
            //    .WithOne(e => e.Modifiers)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.ModifierArguments)
            //    .WithOne(e => e.Modifiers)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.ModifierStrings)
            //    .WithOne(e => e.Modifiers)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.Civics)
            //    .WithMany(e => e.Modifiers)
            //    .Map(m => m.ToTable("CivicModifiers").MapLeftKey("ModifierId").MapRightKey("CivicType"));

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.Districts)
            //    .WithMany(e => e.Modifiers)
            //    .Map(m => m.ToTable("DistrictModifiers").MapLeftKey("ModifierId").MapRightKey("DistrictType"));

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.Traits)
            //    .WithMany(e => e.Modifiers)
            //    .Map(m => m.ToTable("TraitModifiers").MapLeftKey("ModifierId").MapRightKey("TraitType"));

            //modelBuilder.Entity<Modifiers>()
            //    .HasMany(e => e.UnitAbilities)
            //    .WithMany(e => e.Modifiers)
            //    .Map(m => m.ToTable("UnitAbilityModifiers").MapLeftKey("ModifierId").MapRightKey("UnitAbilityType"));

            //modelBuilder.Entity<MomentDataTypes>()
            //    .HasMany(e => e.MomentIllustrations)
            //    .WithOne(e => e.MomentDataTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<MomentIllustrationTypes>()
            //    .HasMany(e => e.MomentIllustrations)
            //    .WithOne(e => e.MomentIllustrationTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<NodeDefinitions>()
            //    .HasMany(e => e.BehaviorTreeNodes)
            //    .WithOne(e => e.NodeDefinitions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<NodeDefinitions>()
            //    .HasMany(e => e.NodeDataDefinitions)
            //    .WithOne(e => e.NodeDefinitions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.Governments)
            //    .WithOptional(e => e.Policies)
            //    .HasForeignKey(e => e.PolicyToUnlock);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.ObsoletePolicies)
            //    .WithOne(e => e.Policies)
            //    .HasForeignKey(e => e.ObsoletePolicy)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.ObsoletePolicies1)
            //    .WithOne(e => e.Policies1)
            //    .HasForeignKey(e => e.PolicyType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.PolicyModifiers)
            //    .WithOne(e => e.Policies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Policies>()
            //    .HasMany(e => e.Governments1)
            //    .WithMany(e => e.Policies1)
            //    .Map(m => m.ToTable("Policy_GovernmentExclusives_XP2").MapLeftKey("PolicyType").MapRightKey("GovernmentType"));

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.EmergencyScoreSources)
            //    .WithOptional(e => e.Projects)
            //    .HasForeignKey(e => e.FromProject);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.Project_BuildingCosts)
            //    .WithOne(e => e.Projects)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.Project_GreatPersonPoints)
            //    .WithOne(e => e.Projects)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.Project_ResourceCosts)
            //    .WithOne(e => e.Projects)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.Project_YieldConversions)
            //    .WithOne(e => e.Projects)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.ProjectCompletionModifiers)
            //    .WithOne(e => e.Projects)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.ProjectPrereqs)
            //    .WithOne(e => e.Projects)
            //    .HasForeignKey(e => e.PrereqProjectType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasMany(e => e.ProjectPrereqs1)
            //    .WithOne(e => e.Projects1)
            //    .HasForeignKey(e => e.ProjectType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Projects>()
            //    .HasOptional(e => e.Projects_XP1)
            //    .WithOne(e => e.Projects);

            //modelBuilder.Entity<Projects>()
            //    .HasOptional(e => e.Projects_XP2)
            //    .WithOne(e => e.Projects);

            //modelBuilder.Entity<Projects_XP2>()
            //    .HasMany(e => e.EmergencyScoreSources)
            //    .WithOptional(e => e.Projects_XP2)
            //    .HasForeignKey(e => e.FromProject);

            //modelBuilder.Entity<Projects_XP2>()
            //    .HasMany(e => e.Project_BuildingCosts)
            //    .WithOne(e => e.Projects_XP2)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ProposalTypes>()
            //    .HasMany(e => e.Discussions)
            //    .WithOne(e => e.ProposalTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<PseudoYields>()
            //    .HasMany(e => e.CongressAiChanges)
            //    .WithOne(e => e.PseudoYields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<PseudoYields>()
            //    .HasMany(e => e.GreatWorkObjectTypes)
            //    .WithOne(e => e.PseudoYields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<PseudoYields>()
            //    .HasMany(e => e.Strategy_YieldPriorities)
            //    .WithOne(e => e.PseudoYields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RandomAgendas>()
            //    .HasMany(e => e.AgendaPreferredLeaders)
            //    .WithOne(e => e.RandomAgendas)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RandomEvents>()
            //    .HasMany(e => e.CoastalLowlands)
            //    .WithOne(e => e.RandomEvents)
            //    .HasForeignKey(e => e.SubmergedEvent)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RandomEvents>()
            //    .HasMany(e => e.CoastalLowlands1)
            //    .WithOne(e => e.RandomEvents1)
            //    .HasForeignKey(e => e.FloodedEvent)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RandomEvents>()
            //    .HasMany(e => e.RandomEvent_Damages)
            //    .WithOne(e => e.RandomEvents)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RandomEvents>()
            //    .HasMany(e => e.RandomEvent_Frequencies)
            //    .WithOne(e => e.RandomEvents)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RandomEvents>()
            //    .HasMany(e => e.RandomEvent_Yields)
            //    .WithOne(e => e.RandomEvents)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RealismSettings>()
            //    .HasMany(e => e.RandomEvent_Frequencies)
            //    .WithOne(e => e.RealismSettings)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Religions>()
            //    .HasMany(e => e.FavoredReligions)
            //    .WithOne(e => e.Religions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Requirements>()
            //    .HasMany(e => e.RequirementArguments)
            //    .WithOne(e => e.Requirements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Requirements>()
            //    .HasMany(e => e.RequirementStrings)
            //    .WithOne(e => e.Requirements)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<RequirementSets>()
            //    .HasMany(e => e.EmergencyAlliances)
            //    .WithOptional(e => e.RequirementSets)
            //    .HasForeignKey(e => e.MemberRequirementSet);

            //modelBuilder.Entity<RequirementSets>()
            //    .HasMany(e => e.Modifiers)
            //    .WithOptional(e => e.RequirementSets)
            //    .HasForeignKey(e => e.SubjectRequirementSetId);

            //modelBuilder.Entity<RequirementSets>()
            //    .HasMany(e => e.Modifiers1)
            //    .WithOptional(e => e.RequirementSets1)
            //    .HasForeignKey(e => e.OwnerRequirementSetId);

            //modelBuilder.Entity<RequirementSets>()
            //    .HasMany(e => e.Requirements)
            //    .WithMany(e => e.RequirementSets)
            //    .Map(m => m.ToTable("RequirementSetRequirements").MapLeftKey("RequirementSetId").MapRightKey("RequirementId"));

            //modelBuilder.Entity<Resolutions>()
            //    .HasMany(e => e.CongressAiChanges)
            //    .WithOne(e => e.Resolutions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resolutions>()
            //    .HasMany(e => e.ResolutionEffects)
            //    .WithOne(e => e.Resolutions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.BarbarianTribes)
            //    .WithOptional(e => e.Resources)
            //    .HasForeignKey(e => e.RequiredResource);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Building_ResourceCosts)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Resources)
            //    .HasForeignKey(e => e.AdjacentResource);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Buildings_XP2)
            //    .WithOptional(e => e.Resources)
            //    .HasForeignKey(e => e.ResourceTypeConvertedToPower);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Improvement_ValidResources)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Project_ResourceCosts)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Projects)
            //    .WithOptional(e => e.Resources)
            //    .HasForeignKey(e => e.PrereqResource);

            //modelBuilder.Entity<Resources>()
            //    .HasOptional(e => e.Resource_Consumption)
            //    .WithOne(e => e.Resources);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Resource_Harvests)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Resource_TradeRouteYields)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Resource_YieldChanges)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Route_ResourceCosts)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.StartBiasResources)
            //    .WithOne(e => e.Resources)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Units)
            //    .WithOptional(e => e.Resources)
            //    .HasForeignKey(e => e.StrategicResource);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Units_XP2)
            //    .WithOptional(e => e.Resources)
            //    .HasForeignKey(e => e.ResourceMaintenanceType);

            //modelBuilder.Entity<Resources>()
            //    .HasMany(e => e.Terrains)
            //    .WithMany(e => e.Resources)
            //    .Map(m => m.ToTable("Resource_ValidTerrains").MapLeftKey("ResourceType").MapRightKey("TerrainType"));

            //modelBuilder.Entity<Routes>()
            //    .HasMany(e => e.Route_ResourceCosts)
            //    .WithOne(e => e.Routes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Routes>()
            //    .HasOptional(e => e.Routes_XP2)
            //    .WithOne(e => e.Routes);

            //modelBuilder.Entity<ScoringCategories>()
            //    .HasMany(e => e.ScoringLineItems)
            //    .WithOne(e => e.ScoringCategories)
            //    .HasForeignKey(e => e.Category)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ShapeDefinitions>()
            //    .HasMany(e => e.NodeDefinitions)
            //    .WithOne(e => e.ShapeDefinitions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<StartEras>()
            //    .HasOptional(e => e.StartEras_XP2)
            //    .WithOne(e => e.StartEras);

            //modelBuilder.Entity<Strategies>()
            //    .HasMany(e => e.Strategy_YieldPriorities)
            //    .WithOne(e => e.Strategies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Strategies>()
            //    .HasMany(e => e.StrategyConditions)
            //    .WithOne(e => e.Strategies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Tags>()
            //    .HasMany(e => e.Types)
            //    .WithMany(e => e.Tags)
            //    .Map(m => m.ToTable("TypeTags").MapLeftKey("Tag").MapRightKey("Type"));

            //modelBuilder.Entity<TargetTypes>()
            //    .HasMany(e => e.AiOperationDefs)
            //    .WithOne(e => e.TargetTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.ObsoleteTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Adjacency_YieldChanges1)
            //    .WithOptional(e => e.Technologies1)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Boosts)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.TechnologyType);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Boosts1)
            //    .WithOptional(e => e.Technologies1)
            //    .HasForeignKey(e => e.BoostingTechType);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.DiplomaticActions)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.TargetPrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.DiplomaticActions1)
            //    .WithOptional(e => e.Technologies1)
            //    .HasForeignKey(e => e.InitiatorPrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.DiplomaticVisibilitySources)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Districts)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Features)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.RemoveTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Improvement_BonusYieldChanges)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Improvement_Tourism)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Improvement_ValidTerrains)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Improvements)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Policies)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Projects)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Resource_Consumption)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.ObsoleteTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Resource_Harvests)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Resources)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Routes_XP2)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasOptional(e => e.Technologies_XP2)
            //    .WithOne(e => e.Technologies);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.TechnologyModifiers)
            //    .WithOne(e => e.Technologies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.TechnologyQuotes)
            //    .WithOne(e => e.Technologies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.TechnologyRandomCosts)
            //    .WithOne(e => e.Technologies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.UnitCommands)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.UnitOperations)
            //    .WithOptional(e => e.Technologies)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Units1)
            //    .WithOptional(e => e.Technologies1)
            //    .HasForeignKey(e => e.ObsoleteTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Units2)
            //    .WithOptional(e => e.Technologies2)
            //    .HasForeignKey(e => e.MandatoryObsoleteTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Units3)
            //    .WithOptional(e => e.Technologies3)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Eras1)
            //    .WithMany(e => e.Technologies1)
            //    .Map(m => m.ToTable("StartingBoostedTechnologies").MapLeftKey("Technology").MapRightKey("Era"));

            //modelBuilder.Entity<Technologies>()
            //    .HasMany(e => e.Technologies1)
            //    .WithMany(e => e.Technologies2)
            //    .Map(m => m.ToTable("TechnologyPrereqs").MapLeftKey("PrereqTech").MapRightKey("Technology"));

            //modelBuilder.Entity<Technologies_XP2>()
            //    .HasMany(e => e.Routes_XP2)
            //    .WithOptional(e => e.Technologies_XP2)
            //    .HasForeignKey(e => e.PrereqTech);

            //modelBuilder.Entity<TerrainClasses>()
            //    .HasMany(e => e.Terrains)
            //    .WithMany(e => e.TerrainClasses)
            //    .Map(m => m.ToTable("TerrainClass_Terrains").MapLeftKey("TerrainClassType").MapRightKey("TerrainType"));

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOptional(e => e.Terrains)
            //    .HasForeignKey(e => e.AdjacentTerrain);

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Terrains)
            //    .HasForeignKey(e => e.CityAdjacentTerrain);

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Improvement_ValidTerrains)
            //    .WithOne(e => e.Terrains)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.StartBiasTerrains)
            //    .WithOne(e => e.Terrains)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Terrain_YieldChanges)
            //    .WithOne(e => e.Terrains)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Buildings1)
            //    .WithMany(e => e.Terrains1)
            //    .Map(m => m.ToTable("Building_ValidTerrains").MapLeftKey("TerrainType").MapRightKey("BuildingType"));

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Features)
            //    .WithMany(e => e.Terrains)
            //    .Map(m => m.ToTable("Feature_AdjacentTerrains").MapLeftKey("TerrainType").MapRightKey("FeatureType"));

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Features1)
            //    .WithMany(e => e.Terrains1)
            //    .Map(m => m.ToTable("Feature_NotAdjacentTerrains").MapLeftKey("TerrainType").MapRightKey("FeatureType"));

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Features2)
            //    .WithMany(e => e.Terrains2)
            //    .Map(m => m.ToTable("Feature_ValidTerrains").MapLeftKey("TerrainType").MapRightKey("FeatureType"));

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.Improvements)
            //    .WithMany(e => e.Terrains)
            //    .Map(m => m.ToTable("Improvement_ValidAdjacentTerrains").MapLeftKey("TerrainType").MapRightKey("ImprovementType"));

            //modelBuilder.Entity<Terrains>()
            //    .HasMany(e => e.RandomEvents)
            //    .WithMany(e => e.Terrains)
            //    .Map(m => m.ToTable("RandomEvent_Terrains").MapLeftKey("TerrainType").MapRightKey("RandomEventType"));

            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.DiplomaticVisibilitySources_XP1)
            //    .WithOptional(e => e.Traits)
            //    .HasForeignKey(e => e.TradePostTrait);

            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.Districts)
            //    .WithOptional(e => e.Traits)
            //    .HasForeignKey(e => e.TraitType);

            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.Agendas)
            //    .WithMany(e => e.Traits)
            //    .Map(m => m.ToTable("AgendaTraits").MapLeftKey("TraitType").MapRightKey("AgendaType"));

            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.Districts1)
            //    .WithMany(e => e.Traits1)
            //    .Map(m => m.ToTable("ExcludedDistricts").MapLeftKey("TraitType").MapRightKey("DistrictType"));

            //modelBuilder.Entity<Traits>()
            //    .HasMany(e => e.GreatPersonClasses)
            //    .WithMany(e => e.Traits)
            //    .Map(m => m.ToTable("ExcludedGreatPersonClasses").MapLeftKey("TraitType").MapRightKey("GreatPersonClassType"));

            //modelBuilder.Entity<TurnSegments>()
            //    .HasMany(e => e.TurnPhases)
            //    .WithOptional(e => e.TurnSegments)
            //    .HasForeignKey(e => e.InactiveSegmentType);

            //modelBuilder.Entity<TurnSegments>()
            //    .HasMany(e => e.TurnPhases1)
            //    .WithOne(e => e.TurnSegments1)
            //    .HasForeignKey(e => e.ActiveSegmentType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Alliances)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Beliefs)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Buildings)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Civics)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Civilizations)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Defeats)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.DiplomaticActions)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Discussions)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Districts)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasMany(e => e.DynamicModifiers)
            //    .WithOne(e => e.Types)
            //    .HasForeignKey(e => e.EffectType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.DynamicModifiers1)
            //    .WithOne(e => e.Types1);

            //modelBuilder.Entity<Types>()
            //    .HasMany(e => e.DynamicModifiers2)
            //    .WithOne(e => e.Types2)
            //    .HasForeignKey(e => e.CollectionType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.EmergencyAlliances)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Eras)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Features)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.GameCapabilities)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.GameEffects)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Gossips)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Governments)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Governors)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.GreatPersonClasses)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.GreatPersonIndividuals)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Improvements)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Leaders)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.LoadingInfo)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasMany(e => e.MomentIllustrations)
            //    .WithOne(e => e.Types)
            //    .HasForeignKey(e => e.GameDataType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Moments)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Policies)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Projects)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.ProposalBlockers)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.ProposalTypes)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Quests)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Religions)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Resolutions)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Resources)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Routes)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Technologies)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Traits)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasMany(e => e.TypeProperties)
            //    .WithOne(e => e.Types)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.UnitPromotionClasses)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.UnitPromotions)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Units)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.Victories)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<Types>()
            //    .HasOptional(e => e.VotingBlockers)
            //    .WithOne(e => e.Types);

            //modelBuilder.Entity<UnitAiTypes>()
            //    .HasMany(e => e.OpTeamRequirements)
            //    .WithOne(e => e.UnitAiTypes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UnitAiTypes>()
            //    .HasMany(e => e.Units)
            //    .WithMany(e => e.UnitAiTypes)
            //    .Map(m => m.ToTable("UnitAiInfos").MapLeftKey("AiType").MapRightKey("UnitType"));

            //modelBuilder.Entity<UnitPromotionClasses>()
            //    .HasMany(e => e.UnitPromotions)
            //    .WithOptional(e => e.UnitPromotionClasses)
            //    .HasForeignKey(e => e.PromotionClass);

            //modelBuilder.Entity<UnitPromotionClasses>()
            //    .HasMany(e => e.Units)
            //    .WithOptional(e => e.UnitPromotionClasses)
            //    .HasForeignKey(e => e.PromotionClass);

            //modelBuilder.Entity<UnitPromotions>()
            //    .HasMany(e => e.UnitPromotionModifiers)
            //    .WithOne(e => e.UnitPromotions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UnitPromotions>()
            //    .HasMany(e => e.UnitPromotions1)
            //    .WithMany(e => e.UnitPromotions2)
            //    .Map(m => m.ToTable("UnitPromotionPrereqs").MapLeftKey("UnitPromotion").MapRightKey("PrereqUnitPromotion"));

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.BonusMinorStartingUnits)
            //    .WithOne(e => e.Units)
            //    .HasForeignKey(e => e.Unit)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Boosts)
            //    .WithOptional(e => e.Units)
            //    .HasForeignKey(e => e.Unit2Type);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Boosts1)
            //    .WithOptional(e => e.Units1)
            //    .HasForeignKey(e => e.Unit1Type);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.District_BuildChargeProductions)
            //    .WithOne(e => e.Units)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.GreatPersonClasses)
            //    .WithOne(e => e.Units)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.MajorStartingUnits)
            //    .WithOne(e => e.Units)
            //    .HasForeignKey(e => e.Unit)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Technologies)
            //    .WithOptional(e => e.Units)
            //    .HasForeignKey(e => e.EmbarkUnitType);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Unit_BuildingPrereqs)
            //    .WithOne(e => e.Units)
            //    .HasForeignKey(e => e.Unit)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Units>()
            //    .HasOptional(e => e.Units_XP2)
            //    .WithOne(e => e.Units);

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Improvements)
            //    .WithMany(e => e.Units)
            //    .Map(m => m.ToTable("Improvement_ValidBuildUnits").MapLeftKey("UnitType").MapRightKey("ImprovementType"));

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Routes)
            //    .WithMany(e => e.Units)
            //    .Map(m => m.ToTable("Route_ValidBuildUnits").MapLeftKey("UnitType").MapRightKey("RouteType"));

            //modelBuilder.Entity<Units>()
            //    .HasMany(e => e.Units1)
            //    .WithMany(e => e.Units2)
            //    .Map(m => m.ToTable("UnitCaptures").MapLeftKey("BecomesUnitType").MapRightKey("CapturedUnitType"));

            //modelBuilder.Entity<Units>()
            //    .HasOptional(e => e.Units11)
            //    .WithMany(e => e.Units3);

            //modelBuilder.Entity<Units>()
            //    .HasOptional(e => e.Units12)
            //    .WithMany(e => e.Units4);

            //modelBuilder.Entity<Visibilities>()
            //    .HasMany(e => e.RandomAgendasForCivic)
            //    .WithOne(e => e.Visibilities)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Visibilities>()
            //    .HasMany(e => e.RandomAgendasInEra)
            //    .WithOne(e => e.Visibilities)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Visibilities>()
            //    .HasOptional(e => e.Visibilities_XP2)
            //    .WithOne(e => e.Visibilities);

            //modelBuilder.Entity<Vocabularies>()
            //    .HasMany(e => e.Tags)
            //    .WithOne(e => e.Vocabularies)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Adjacency_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.AiBuildSpecializations)
            //    .WithOne(e => e.Yields)
            //    .HasForeignKey(e => e.PrioritizationYield)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.AiBuildSpecializations1)
            //    .WithOptional(e => e.Yields1)
            //    .HasForeignKey(e => e.BuildingYield);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Building_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Building_YieldChangesBonusWithPower)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Building_YieldDistrictCopies)
            //    .WithOne(e => e.Yields)
            //    .HasForeignKey(e => e.NewYieldType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Building_YieldDistrictCopies1)
            //    .WithOne(e => e.Yields1)
            //    .HasForeignKey(e => e.OldYieldType)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Building_YieldsPerEra)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Buildings)
            //    .WithOptional(e => e.Yields)
            //    .HasForeignKey(e => e.PurchaseYield);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.CongressAiChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.District_CitizenYieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.District_TradeRouteYields)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Feature_AdjacentYields)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Feature_Removes)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Feature_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.GreatWork_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Improvement_BonusYieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Improvement_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Improvements)
            //    .WithOptional(e => e.Yields)
            //    .HasForeignKey(e => e.YieldFromAppeal);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Project_YieldConversions)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.RandomEvent_Yields)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Resource_Harvests)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Resource_TradeRouteYields)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Resource_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Strategy_YieldPriorities)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Terrain_YieldChanges)
            //    .WithOne(e => e.Yields)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Units)
            //    .WithOptional(e => e.Yields)
            //    .HasForeignKey(e => e.PurchaseYield);

            //modelBuilder.Entity<Yields>()
            //    .HasMany(e => e.Units1)
            //    .WithOptional(e => e.Yields1)
            //    .HasForeignKey(e => e.PurchaseYield);
            #endregion EF Core Test 1
            #region EF Core Test 2
            ////EF Core 2 
            //modelBuilder.Entity<AiOperationLimits>()
            //    .HasKey(u => new { u.ListType, u.OperationType });

            //modelBuilder.Entity<AiOperationTeams>()
            //    .HasKey(u => new { u.TeamName, u.OperationName });

            //modelBuilder.Entity<AllowedOperations>()
            //    .HasKey(u => new { u.ListType, u.OperationDef });

            //modelBuilder.Entity<AppealHousingChanges>()
            //    .HasKey(u => new { u.DistrictType, u.MinimumValue });

            //modelBuilder.Entity<BarbarianTribeForces>()
            //    .HasKey(u => new { u.AttackForceType, u.TribeType, u.SpecificTribeType });

            //modelBuilder.Entity<BeliefModifiers>()
            //    .HasKey(u => new { u.BeliefType, u.ModifierID });

            //modelBuilder.Entity<BonusMinorStartingUnits>()
            //    .HasKey(u => new { u.Unit, u.Era });

            //modelBuilder.Entity<Building_GreatPersonPoints>()
            //    .HasKey(u => new { u.BuildingType, u.GreatPersonClassType });

            //modelBuilder.Entity<Building_GreatWorks>()
            //    .HasKey(u => new { u.BuildingType, u.GreatWorkSlotType });

            ////Line 407. Where did this table so?
            //modelBuilder.Entity<Building_RequiredFeatures>()
            //    .HasKey(u => new { u.Language, u.Tag });
            #endregion EF Core Test 2
            #endregion Model Auto-Creating
        }
    }
}
