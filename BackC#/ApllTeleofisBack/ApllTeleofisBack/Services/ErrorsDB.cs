using ApllTeleofisBack.Constants;
using ApllTeleofisBack.Models;
using ApllTeleofisBack.Presenter;

namespace ApllTeleofisBack.Services
{
    public class ErrorsDB
    {
        public List<TerminalData> ReceiveValidTerminalDataColletions(List<DataTerminal> dataTerminals,int idTerminal,DateTime version)
        {
            List<TerminalData> newTerminalPresenters = new List<TerminalData>();
            List<DataTerminal> datas = new();

            //TerminalPresenter terminalPresenter = new TerminalPresenter();

            datas = dataTerminals.Where(x => x.GroupRegister > 0)
                                  .OrderBy(x => x.GroupRegister)
                                  .ToList();

            foreach (var dataTerm in datas)
            {
                newTerminalPresenters.Add(new TerminalData(dataTerm,idTerminal, version));
            }

            TerminalData tableJob = newTerminalPresenters.FirstOrDefault(x => x.Descriptions.Equals(ConstatansVariables.МЕТОД_РЕГУЛИРОВКИ));
            TerminalData settingTempr = newTerminalPresenters.FirstOrDefault(x => x.Descriptions.Equals(ConstatansVariables.УСТАВКА_Т_ПОДАЧИ));
            TerminalData setTempr = newTerminalPresenters.FirstOrDefault(x => x.Descriptions.Equals(ConstatansVariables.ЖЕЛАЕМАЯ_ТЕМПЕРАТУРА));

            if (tableJob != null && tableJob.Value.Equals("По улице"))
            {
                newTerminalPresenters.Remove(settingTempr);
                newTerminalPresenters.Reverse(9, 2);
            }
            else
                newTerminalPresenters.Remove(setTempr);

            if (newTerminalPresenters.Count > 0)
            {
                newTerminalPresenters.Reverse(0, 6);
                newTerminalPresenters.Reverse(1, 6);
                newTerminalPresenters.Reverse(2, 5);
                if (newTerminalPresenters.Count >= 26)
                    newTerminalPresenters.Reverse(22, 4);
            }

            return newTerminalPresenters;
            //await Task.Run(() =>
            //{
            //    foreach (var terminal in presenter.Terminals)
            //    {

            //        // var test = terminal.DataTerminalJournals.Where(x => x.DescriptionsTerminalError.Equals(ConstatansVariables.УПРАВЛЕНИЕ_НАСОСОМ)).FirstOrDefault();

            //        terminalPresenter = terminal;

            //        List<DataTermnalJournalPresenter> terminalRes = new List<DataTermnalJournalPresenter>(terminal.DataTerminalJournals.Where(x => x.GroupRegister > 0)
            //                                                                                                                            .OrderBy(x => x.GroupRegister)
            //                                                                                                                            .ToList());
            //        // var test = terminalRes.Where(x => x.DescriptionsTerminalError.Equals(ConstatansVariables.УПРАВЛЕНИЕ_НАСОСОМ)).FirstOrDefault();

            //        DataTermnalJournalPresenter tableJob = terminalRes.FirstOrDefault(x => x.DescriptionsTerminalError.Equals(ConstatansVariables.МЕТОД_РЕГУЛИРОВКИ));
            //        DataTermnalJournalPresenter settingTempr = terminalRes.FirstOrDefault(x => x.DescriptionsTerminalError.Equals(ConstatansVariables.УСТАВКА_Т_ПОДАЧИ));
            //        DataTermnalJournalPresenter setTempr = terminalRes.FirstOrDefault(x => x.DescriptionsTerminalError.Equals(ConstatansVariables.ЖЕЛАЕМАЯ_ТЕМПЕРАТУРА));

            //        terminalPresenter.DataTerminalJournals.Clear();

            //        if (tableJob != null && tableJob.ValueRegister.Equals("По улице"))
            //        {
            //            terminalRes.Remove(settingTempr);
            //            terminalRes.Reverse(9, 2);
            //        }
            //        else
            //            terminalRes.Remove(setTempr);

            //        if (terminalRes.Count > 0)
            //        {
            //            terminalRes.Reverse(0, 6);
            //            terminalRes.Reverse(1, 6);
            //            terminalRes.Reverse(2, 5);
            //            if (terminalRes.Count >= 26)
            //                terminalRes.Reverse(22, 4);
            //        }

            //        terminalPresenter.DataTerminalJournals.AddRange(terminalRes);

            //        newTerminalPresenters.Add(terminalPresenter);
            //    }
            //});

            //return newTerminalPresenters;

        }


        public List<ErrorTerminal> ReceiveValidErrorsTerminalColletions(List<JournalErrors> journalErrors,int idTerminal)
        {
            List<ErrorTerminal> errorTerminals = new List<ErrorTerminal>();
            errorTerminals = ReceiveValidErrorWithDB(journalErrors,idTerminal);

            // возвращаем в коллекцию угля меньше чем на сутки
            ErrorTerminal dataTermnalJournalPresenterCoalDay = ReceiveCoalDayError(journalErrors, idTerminal);
            if (dataTermnalJournalPresenterCoalDay != null)
                errorTerminals.Add(dataTermnalJournalPresenterCoalDay);

            // возвращаем в коллекцию связи
            ErrorTerminal dataTermnalJournalPresenterConnect = ReceiveConnectError(journalErrors, idTerminal);

            if (dataTermnalJournalPresenterConnect != null)
                errorTerminals.Add(dataTermnalJournalPresenterConnect);

            errorTerminals = errorTerminals.OrderByDescending(x => x.DataError).ToList();

            return errorTerminals;
        }

        List<ErrorTerminal> ReceiveValidErrorWithDB(List<JournalErrors> journalErrorsPresenters,int idTerminal)
        {
            List<JournalErrors> terminalErrors = new List<JournalErrors>();
            List<ErrorTerminal> dataTermnalJournalPresenters = new List<ErrorTerminal>();

            // JournalErrorsPresenter coalDay = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.УГЛЯ_МЕНЬШЕ_ЧЕМ_НА_СУТКИ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors noFaer = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.АВАРИЯ_НЕТ_ГОРЕНИЯ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors criticalEcsest = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.АВАРИЯ_КРИТИЧЕСКОЕ_СНИЖЕНИЕ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors noPower = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ПОТЕРЯ_МОЩНОСТИ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors criticalWater = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.УМЕНЬШЕНИЕ_ПРОТОКА_15)).OrderByDescending(x => x.Id).FirstOrDefault();
            // JournalErrorsPresenter deffenderBoiler = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ГАШЕНИЕ_КОТЕЛЬНОЙ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors reverseTempr = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ТЕМПЕРАТУРА_ОБРАТКИ_НИЖЕ_5)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors sypplyTempr = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ТЕМПЕРАТУРА_ПОДАЧИ_НИЖЕ_15)).OrderByDescending(x => x.Id).FirstOrDefault();

            JournalErrors lowPressure = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.НИЗКОЕ_ДАВЛЕНИЕ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors fireBunker = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОГОНЬ_В_БУНКЕРЕ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors no220 = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.НЕТ_220)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors onWater = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ВКЛЮЧЕНА_ПОДПИТКА_ВОДЫ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errorInnigs = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОШИБКА_АНАЛ_ДАТЧИКА_ПОДАЧИ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errorAigerAn = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОШИБКА_АНАЛ_ДАТЧИКА_ШНЕКА)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors noWaterTwo = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.НЕТ_ПРОТОКА_ВОДЫ_ПО_2_ДАТЧИКУ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors modeControl = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.РЕЖИМ_РУЧНОГО_УПРАВЛЕНИЯ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errorRAM = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОШИБКА_RAM)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errorAiger = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОГОНЬ_В_ШНЕКЕ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors crashAiger = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.АВАРИЯ_В_ШНЕКЕ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors noWater = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.НЕТ_ПРОТОКА_ВОДЫ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors crashPodduv = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.АВАРИЯ_ПОДДУВА)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors crasgBunker = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.АВАРИЯ_ДЫМОСОСА)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errorSensor = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОШИБКА_ДАТЧИКОВ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors UpRazn = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ПРЕВЫШЕНИЕ_РАЗНИЦЫ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors overheatRoom = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ПЕРЕГРЕВ_ПОМЕЩЕНИЯ)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errrorZolnick = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ОШИБКА_ЗОЛЬНИКА)).OrderByDescending(x => x.Id).FirstOrDefault();
            JournalErrors errrorTableJob = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.ГАШЕНИЕ_КОТЕЛЬНОЙ)).OrderByDescending(x => x.Id).FirstOrDefault();

            // if (coalDay != null && coalDay.Status)
            //    terminalErrors.Add(coalDay);

            if (noFaer != null && noFaer.Status)
                terminalErrors.Add(noFaer);

            if (criticalEcsest != null && criticalEcsest.Status)
                terminalErrors.Add(criticalEcsest);

            if (noPower != null && noPower.Status)
                terminalErrors.Add(noPower);

            if (criticalWater != null && criticalWater.Status)
                terminalErrors.Add(criticalWater);

            //if (deffenderBoiler != null && deffenderBoiler.Status)
            //    terminalErrors.Add(deffenderBoiler);

            if (reverseTempr != null && reverseTempr.Status)
                terminalErrors.Add(reverseTempr);

            if (sypplyTempr != null && sypplyTempr.Status)
                terminalErrors.Add(sypplyTempr);

            if (lowPressure != null && lowPressure.Status)
                terminalErrors.Add(lowPressure);

            if (fireBunker != null && fireBunker.Status)
                terminalErrors.Add(fireBunker);

            if (no220 != null && no220.Status)
                terminalErrors.Add(no220);

            if (onWater != null && onWater.Status)
                terminalErrors.Add(onWater);

            if (errorInnigs != null && errorInnigs.Status)
                terminalErrors.Add(errorInnigs);

            if (errorAigerAn != null && errorAigerAn.Status)
                terminalErrors.Add(errorAigerAn);

            if (noWaterTwo != null && noWaterTwo.Status)
                terminalErrors.Add(noWaterTwo);

            if (modeControl != null && modeControl.Status)
                terminalErrors.Add(modeControl);

            if (errorRAM != null && errorRAM.Status)
                terminalErrors.Add(errorRAM);

            if (errorAiger != null && errorAiger.Status)
                terminalErrors.Add(errorAiger);

            if (crashAiger != null && crashAiger.Status)
                terminalErrors.Add(crashAiger);

            if (noWater != null && noWater.Status)
                terminalErrors.Add(noWater);

            if (crashPodduv != null && crashPodduv.Status)
                terminalErrors.Add(crashPodduv);

            if (crasgBunker != null && crasgBunker.Status)
                terminalErrors.Add(crasgBunker);

            if (errorSensor != null && errorSensor.Status)
                terminalErrors.Add(errorSensor);

            if (UpRazn != null && UpRazn.Status)
                terminalErrors.Add(UpRazn);

            if (overheatRoom != null && overheatRoom.Status)
                terminalErrors.Add(overheatRoom);

            if (errrorZolnick != null && errrorZolnick.Status)
                terminalErrors.Add(errrorZolnick);

            if (errrorTableJob != null && errrorTableJob.Status)
                terminalErrors.Add(errrorTableJob);

            foreach (var error in terminalErrors)
            {
                dataTermnalJournalPresenters.Add(new ErrorTerminal(error,idTerminal));
            }

            dataTermnalJournalPresenters = dataTermnalJournalPresenters.OrderByDescending(x => x.DataError).ToList();

            return dataTermnalJournalPresenters;

        }

        ErrorTerminal ReceiveCoalDayError(List<JournalErrors> journalErrorsPresenters, int idTerminal)
        {
            JournalErrors journalError = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.УГЛЯ_МЕНЬШЕ_ЧЕМ_НА_СУТКИ))
                                                        .OrderByDescending(x => x.Id)
                                                        .FirstOrDefault();

            if (journalError != null && journalError.Status)
                return new ErrorTerminal(journalError,idTerminal);
            else
                return null;

        }

        ErrorTerminal ReceiveConnectError(List<JournalErrors> journalErrorsPresenters, int idTerminal)
        {
            JournalErrors journalError = journalErrorsPresenters.Where(x => x.NameDesc.Contains(ConstatansVariables.НЕТ_СВЯЗИ))
                                                        .OrderByDescending(x => x.Id)
                                                        .FirstOrDefault();

            if (journalError != null && journalError.Status)
                return new ErrorTerminal(journalError,idTerminal);
            else
                return null;

        }
    }
}
