global.mockEventEmit = () => {
  global.restoreEventEmit();
  global.eventBus = global.eventBus || {};
  global.eventBus.$emit = jest.fn();
  return global.eventBus.$emit;
};

global.restoreEventEmit = () => {
  if (global.eventBus && global.eventBus.$emit) {
    global.eventBus.$emit = undefined;
  }
};


global.mockEventOn = () => {
  global.restoreEventOn();
  global.eventBus = global.eventBus || {};
  global.eventBus.$on = jest.fn();
  return global.eventBus.$on;
};

global.restoreEventOn = () => {
  if (global.eventBus && global.eventBus.$on) {
    global.eventBus.$on = undefined;
  }
};
